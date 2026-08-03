using System;
using System.Drawing;
using System.Windows.Forms;

namespace CabconPMP
{
    public class ModernMenuRenderer : ToolStripProfessionalRenderer
    {
        private Color _backColor = Color.White;
        private Color _hoverColor = Color.FromArgb(240, 240, 240);
        private Color _selectedColor = Color.FromArgb(220, 230, 245);
        private Color _accentColor = Color.FromArgb(31, 58, 96); // Cabcon dark blue
        private Color _textColor = Color.FromArgb(40, 40, 40);

        public ModernMenuRenderer() : base(new CustomColorTable())
        {
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            // Draw overall background
            e.Graphics.Clear(_backColor);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var item = e.Item;
            var g = e.Graphics;

            if (item.IsOnDropDown)
            {
                // Dropdown items
                if (item.Selected)
                {
                    g.FillRectangle(new SolidBrush(_selectedColor), 2, 0, item.Width - 4, item.Height);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(_backColor), 0, 0, item.Width, item.Height);
                }
            }
            else
            {
                // Top-level "tabs"
                if (item.Selected || item.Pressed)
                {
                    g.FillRectangle(new SolidBrush(_hoverColor), 0, 0, item.Width, item.Height);
                    // Draw bottom accent line
                    g.FillRectangle(new SolidBrush(_accentColor), 0, item.Height - 3, item.Width, 3);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(_backColor), 0, 0, item.Width, item.Height);
                }
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = _textColor;
            base.OnRenderItemText(e);
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            // Remove the native image margin gradient
            e.Graphics.FillRectangle(new SolidBrush(_backColor), e.AffectedBounds);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // Draw a flat border for dropdowns, no border for main menu strip
            if (e.ToolStrip.IsDropDown)
            {
                e.Graphics.DrawRectangle(new Pen(Color.LightGray), 0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
            }
            else
            {
                // Optional: bottom border for the whole strip
                e.Graphics.DrawLine(new Pen(Color.LightGray), 0, e.ToolStrip.Height - 1, e.ToolStrip.Width, e.ToolStrip.Height - 1);
            }
        }
    }

    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground => Color.White;
        public override Color ImageMarginGradientBegin => Color.White;
        public override Color ImageMarginGradientMiddle => Color.White;
        public override Color ImageMarginGradientEnd => Color.White;
        public override Color MenuBorder => Color.LightGray;
        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuItemSelected => Color.FromArgb(220, 230, 245);
        public override Color MenuStripGradientBegin => Color.White;
        public override Color MenuStripGradientEnd => Color.White;
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(220, 230, 245);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(220, 230, 245);
        public override Color MenuItemPressedGradientBegin => Color.White;
        public override Color MenuItemPressedGradientEnd => Color.White;
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CabconPMP
{
    public class TransparentComboBox : ComboBox
    {
        public TransparentComboBox()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);

            this.BackColor = Color.Transparent;
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string text = this.Items[e.Index].ToString();
            using (Brush b = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, e.Font, b, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            // Enable high-quality ClearType text rendering
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Draw a permanent subtle border so it always looks like an input box
            using (Pen borderPen = new Pen(Color.FromArgb(160, 160, 160)))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }

            // Draw a very subtle semi-transparent background to make text readable against complex images
            using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(40, 255, 255, 255)))
            {
                e.Graphics.FillRectangle(bgBrush, 1, 1, this.Width - 2, this.Height - 2);
            }

            // Draw text
            if (this.SelectedIndex >= 0)
            {
                string text = this.Text;
                TextFormatFlags flags = TextFormatFlags.TextBoxControl | TextFormatFlags.VerticalCenter;
                Rectangle textRect = new Rectangle(2, 0, this.Width - 20, this.Height);
                TextRenderer.DrawText(e.Graphics, text, this.Font, textRect, this.ForeColor, flags);
            }

            // Draw dropdown arrow
            Rectangle arrowRect = new Rectangle(this.Width - 17, 0, 17, this.Height);
            ControlPaint.DrawComboButton(e.Graphics, arrowRect, ButtonState.Normal);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            this.Invalidate();
        }
    }
}

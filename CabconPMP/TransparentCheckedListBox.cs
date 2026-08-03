using System;
using System.Drawing;
using System.Windows.Forms;

namespace CabconPMP
{
    public class TransparentCheckedListBox : CheckedListBox
    {
        public TransparentCheckedListBox()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw, true);

            this.BackColor = Color.Transparent;
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
    }
}

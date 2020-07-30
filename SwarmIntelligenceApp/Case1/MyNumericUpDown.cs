using System;
using System.Windows.Forms;

namespace Case1
{
    public class MyNumericUpDown : NumericUpDown
    {
        public MyNumericUpDown()
        {
            Controls[0].Hide();
        }

        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }
    }
}

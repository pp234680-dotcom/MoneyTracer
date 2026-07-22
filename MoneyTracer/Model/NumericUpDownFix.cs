using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracer.Model
{
    public class NumericUpDownFix : System.Windows.Forms.NumericUpDown
    {
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            //This code is completely copied from online
            //But I'll still try to comment them
            

            HandledMouseEventArgs hme = e as HandledMouseEventArgs;
            if (hme != null)
                hme.Handled = true;

            this.Focus();

            if (e.Delta > 0 && this.Value < this.Maximum)
                this.Value += this.Increment;
            else if (e.Delta < 0 && this.Value > this.Minimum)
                this.Value -= this.Increment;
        }
    }
}

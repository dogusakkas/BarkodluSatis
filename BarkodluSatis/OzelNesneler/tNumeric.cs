using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.OzelNesneler
{
    public class tNumeric : TextBox
    {
        public tNumeric()
        {
            this.Size = new System.Drawing.Size(115, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "tNumeric";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Click += TNumeric_Click;
            this.KeyPress += TNumeric_KeyPress;
        }

        private void TNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TNumeric_Click(object sender, EventArgs e)
        {
            this.SelectAll();
        }
    }
}

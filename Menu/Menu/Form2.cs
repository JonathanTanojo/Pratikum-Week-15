using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttoncalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxdiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxdiscount.Checked == true)
            {
                panel1.Visible = panel1.Enabled;
            }
            else
            {
                panel1.Enabled = false;
            }
            
        }
    }
}

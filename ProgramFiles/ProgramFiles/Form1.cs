using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramFiles
{
    public partial class Form1 : Form
    {
        double addOnCost = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHamburger.Checked)
            {
                gbHandburger.Visible = true;
                gbPizza.Visible = false;
                gbSalad.Visible = false;

                if (gbHandburger.Visible)
                {
                    addOnCost = .75;
                }
            }
            else if (rdSalad.Checked)
            {
                gbHandburger.Visible = false;
                gbPizza.Visible = false;
                gbSalad.Visible = true;

                if (gbSalad.Visible)
                {
                    addOnCost = .25;
                }
            }
            else if (rdPizza.Checked)
            {
                gbHandburger.Visible = false;
                gbPizza.Visible = true;
                gbSalad.Visible = false;

                if (gbPizza.Visible)
                {
                    addOnCost = .50;
                }
            }

            label1.Text = addOnCost.ToString();
            
        }
    }
}

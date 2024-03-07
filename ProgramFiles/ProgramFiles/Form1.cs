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
        double addOnItemCost = 0;
        double subTotal = 0;
        double tax = 0.0775;
        int itemsChecked;
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
                subTotal = 6.95;
                gbHandburger.Visible = true;
                gbPizza.Visible = false;
                gbSalad.Visible = false;

                if (gbHandburger.Visible)
                {
                    addOnItemCost = .75;

                    foreach (Control c in gbPizza.Controls)
                    {
                        if( c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                    foreach (Control c in gbSalad.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                }
            }
            else if (rdSalad.Checked)
            {

                subTotal = 4.95;
                gbHandburger.Visible = false;
                gbPizza.Visible = false;
                gbSalad.Visible = true;

                if (gbSalad.Visible)
                {
                    addOnItemCost = .25;

                    foreach (Control c in gbHandburger.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                    foreach (Control c in gbPizza.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                }
            }
            else if (rdPizza.Checked)
            {

                subTotal = 5.95;
                gbHandburger.Visible = false;
                gbPizza.Visible = true;
                gbSalad.Visible = false;

                if (gbPizza.Visible)
                {
                    addOnItemCost = .50;

                    foreach (Control c in gbHandburger.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                    foreach (Control c in gbSalad.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                }   
            }




            double taxAmmount = subTotal * tax;
            double total = Math.Round(taxAmmount + subTotal,2);
            label1.Text = total.ToString();
            
        }
    }
}

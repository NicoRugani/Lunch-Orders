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
        double subTotal = 0;
        int itemsChecked;
        double addOnCost;
        double tax = 0.0775;

        public Form1()
        {
            InitializeComponent();
            clbAddOnItems.ItemCheck += clbAddOnItems_ItemCheck;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
            
            if (rdHamburger.Checked)
            {
                addOnCost = .75;
                subTotal = 6.95;
                lblAddOn.Text = "Add-on-items($.75/each)";
                clbAddOnItems.Items[0] = "Lettuce, Tomato, and onions";
                clbAddOnItems.Items[1] = "Ketchup, Mustard, and mayo";
                clbAddOnItems.Items[2] = "French fries";
            }
            else if (rdPizza.Checked)
            {
                addOnCost = .50;
                subTotal = 5.95;
                lblAddOn.Text = "Add-on-items($.50/each)";
                clbAddOnItems.Items[0] = "Pepperoni";
                clbAddOnItems.Items[1] = "Sausage";
                clbAddOnItems.Items[2] = "Olives";
            }
            else if (rdSalad.Checked)
            {
                addOnCost = .25;
                subTotal = 4.95;
                lblAddOn.Text = "Add-on-items($.25/each)";
                clbAddOnItems.Items[0] = "Croutons";
                clbAddOnItems.Items[1] = "Bacon bit";
                clbAddOnItems.Items[2] = "Bread sticks";
            }

            

        }

        private void clbAddOnItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                itemsChecked++;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                itemsChecked--;
            }

                
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double totalAddOnCost = addOnCost * itemsChecked;
            subTotal = subTotal + totalAddOnCost;
            double taxAmmount = Math.Round(subTotal * tax,2);
            double total = Math.Round(subTotal + taxAmmount,2);
            
            txtSubTotal.Text = subTotal.ToString();
            txtTax.Text = taxAmmount.ToString();
            txtTotal.Text = total.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

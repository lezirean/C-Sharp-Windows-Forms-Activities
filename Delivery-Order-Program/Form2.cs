using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Delivery_Order_Program
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // variables 
        double total = 0, cash = 0, change = 0;
        string transaction = "";

        private void UncheckAll(Control ctrl)
        {
            CheckBox chkBox = ctrl as CheckBox;
            if (chkBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    UncheckAll(child);
                }
            }
            else
            {
                chkBox.Checked = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // clear checkboxes 
            UncheckAll(this);

            total = 0; cash = 0; change = 0;
            txtTotal.Text = "";
            txtCash.Text = "";
            txtChange.Text = "";

            // clear combobox 
            this.cmbboxFoodService.SelectedIndex = -1;

            lblTransaction.Text = "";

            radbtnCash.Checked = false;
            radbtnGcash.Checked = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Burgers
            if(chkFlameGrilled.Checked)
            {
                total += 69;
            }
            if (chkWhopper.Checked)
            {
                total += 155;
            }
            if (chk4Cheese.Checked)
            {
                total += 185;
            }
            if (chkMushroomSwissKing.Checked)
            {
                total += 165;
            }
            if (chkXtraLongChicken.Checked)
            {
                total += 99;
            }

            // Drinks
            if (chkSoftDrink.Checked)
            {
                total += 50;
            }
            if (chkIcedTea.Checked)
            {
                total += 55;
            }
            if (chkBKJoeCoffee.Checked)
            {
                total += 75;
            }

            // Sidekicks
            if (chkFries.Checked)
            {
                total += 59;
            }
            if (chkOnionRings.Checked)
            {
                total += 59;
            }
            if (chkSundae.Checked)
            {
                total += 49;
            }


            if (this.cmbboxFoodService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value in Food Service combo box.");
                total = 0;
                cash = 0;
            } else
            {
                transaction = "For " + this.cmbboxFoodService.SelectedItem.ToString() + ", ";
            }

            if (!radbtnCash.Checked && !radbtnGcash.Checked)
            {
                MessageBox.Show("Please select payment mode using radio buttons.");
                total = 0;
                cash = 0;
            } else
            {
                if(radbtnCash.Checked == true)
                {
                    transaction += "Paid using " + radbtnCash.Text;
                } else
                {
                    transaction += "Paid using " + radbtnGcash.Text;
                }
                
            }


            if (string.IsNullOrEmpty(txtCash.Text))
            {
                txtCash.Focus();
                errCash.SetError(txtCash, "Please enter a value.");
                total = 0; // might be erroneous, debug!
            }
            else
            {
                errCash.SetError(txtCash, string.Empty);
                cash = Convert.ToDouble(txtCash.Text);

                if (total > cash)
                {
                    MessageBox.Show("Total can't be greater than Cash.");
                    total = 0;
                    cash = 0;
                    transaction = "";
                }
                else
                {
                    change = cash - total;
                }

            }


            // Computation and print

            txtTotal.Text = Convert.ToString(total);
            txtChange.Text = Convert.ToString(change);
            lblTransaction.Text = transaction;

            
        }
    }
}


// if form 2 close, then close form 1 too
// put radio button


// Application.OpenForms["FrmToBeClosed"].Close();
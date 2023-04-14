using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BORROMEO_Leila_Validating_Inputs
{
    public partial class ValidatingInputs : Form
    {
        public ValidatingInputs()
        {
            InitializeComponent();
            okBtn.Enabled = false;
            nameText.Tag = false;
            cityText.Tag = false;
            ageText.Tag = false;
        }

        private void TextBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == 0)
            {
                txt.BackColor = Color.Red;
                txt.Tag = false;
            }
            else
            {
                txt.BackColor = Color.White;
                txt.Tag = true;
            }

            okBtn.Enabled = ((bool)nameText.Tag && (bool)cityText.Tag && (bool)ageText.Tag);
        }

        private void ageText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                MessageBox.Show("Age field only accepts numeric values.");
                e.Handled = true;
            }
               
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            cityText.Text = "";
            ageText.Text = "";
            detailsRichText.Text = "";

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            detailsRichText.Text = "Name: " + nameText.Text + "\nCity: " +
               cityText.Text + "\nAge: " + ageText.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_Order_Program
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "user", password = "userpass";

            if(txtUsername.Text == username && txtPassword.Text == password) {
                
                form2.Show();

                Visible = false;

                if (form2.Visible == true)
                {
                    lblLoginStatus.Text = "";
                    txtPassword.Text = "";
                }
            } else {
                lblLoginStatus.Text = "Invalid login credentials.";
            }
        }
    }
}

// use radio button, the only one left
// optional to-do: thanks for ordering message (message box)
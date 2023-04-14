using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LoginForm : Form // fn f12 to go to forms
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // the X button on the form

        }

        private void showPasswordChkBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = showPasswordChkBox.Checked ? '\0' : '●';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

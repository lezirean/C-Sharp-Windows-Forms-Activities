using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Student_Progress_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtRollNo.Focus();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, m4, m5, total;
            float per;
            string div = "", result = "";
            m1 = Convert.ToInt32(txtDsa.Text);
            m2 = Convert.ToInt32(txtWebDev.Text);
            m3 = Convert.ToInt32(txtOs.Text);
            m4 = Convert.ToInt32(txtPython.Text);
            m5 = Convert.ToInt32(txtElective.Text);

            total = m1 + m2 + m3 + m4 + m5;
            per = total * 100 / 500.0f;
            if (m1 >= 35 && m2 >= 35 && m3 >= 35 && m4 >= 35 && m5 >= 35)
            {
                result = "PASS";
                if (per >= 60)
                    div = "I";
                else if (per >= 45)
                    div = "II";
                else
                    div = "III";
            }
            else
            {
                result = "FAIL";
                div = "NA";
            }
            txtTotal.Text = total.ToString();
            txtPercentage.Text = per.ToString();
            txtResult.Text = result;
            txtDivision.Text = div;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtRollNo.Text = "";
            txtName.Text = "";
            txtDsa.Text = "";
            txtWebDev.Text = "";
            txtOs.Text = "";
            txtPython.Text = "";
            txtElective.Text = "";
            txtTotal.Text = "";
            txtPercentage.Text = "";
            txtResult.Text = "";
            txtDivision.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Employee_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PopulateStates()
        {
            lstStates.Items.Add("Maharashtra");
            lstStates.Items.Add("MP");
            lstStates.Items.Add("Punjab");
            lstStates.Items.Add("Karnataka");
            lstStates.Items.Add("Goa");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateStates();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string details;
            details = "EmpNo: " + mskTxtEmpNo.Text;
            details += "\r\n\nName: " + txtName.Text;
            details += "\r\n\nAddress: " + txtAddress.Text;
            details += "\r\n\nCity: " + cmbCity.SelectedItem;
            details += "\r\n\nState: " + lstStates.SelectedItem;
            details += "\r\n\nDOB: " + dtpDOB.Value.ToShortDateString();
            details += "\r\n\nAge: " + numAge.Value.ToString();
            string gender = radMale.Checked ? "Male" : "Female";
            details += "\r\n\nGender: " + gender;

            string hobbies = "";
            foreach (string h in chkLstHobbies.CheckedItems)
                hobbies += h + "\r\n\t";
            details += "\r\nHobbies: " + hobbies;
            txtDetails.Text = details;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mskTxtEmpNo.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            cmbCity.SelectedIndex = -1;
            lstStates.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            numAge.Value = numAge.Minimum;
            radMale.Checked = false;
            radFemale.Checked = false;
            //unchek all items 
            for (int i = 0; i < chkLstHobbies.Items.Count; i++)
                chkLstHobbies.SetItemChecked(i, false);
            //removes blue selection 
            chkLstHobbies.ClearSelected();
            txtDetails.Text = "";
            mskTxtEmpNo.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

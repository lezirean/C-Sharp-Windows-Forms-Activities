using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            emp.EmpNo = Convert.ToInt32(txtEmpNo.Text);
            emp.Name = txtEmpName.Text;
            emp.BasicSalary = Convert.ToSingle(txtBasicSal.Text);
            emp.calculateSalary();
            txtHRA.Text = emp.HRA.ToString();
            txtTA.Text = emp.TA.ToString();
            txtDA.Text = emp.DA.ToString();
            txtPF.Text = emp.PF.ToString();
            txtTDS.Text = emp.TDS.ToString();
            txtGrossSal.Text = emp.GrossSalary.ToString();
            txtNetSal.Text = emp.NetSalary.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtBasicSal.Text = "";

            txtHRA.Text = "";
            txtTA.Text = "";
            txtDA.Text = "";

            txtPF.Text = "";
            txtTDS.Text = "";

            txtGrossSal.Text = "";
            txtNetSal.Text = "";

            emp.EmpNo = 0;
            emp.Name = "";
            emp.BasicSalary = 0;
            emp.HRA = 0;
            emp.TA = 0;
            emp.DA = 0;
            emp.PF = 0;
            emp.TDS = 0;
            emp.GrossSalary = 0;
            emp.NetSalary = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

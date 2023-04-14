using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BORROMEO_Leila_ScientificCalculator
{
    public partial class Form1 : Form
    {
        double no1, no2, result;
        string op;
        bool flag;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contentPanel.Visible = false;
            offBtn.Visible = false;
        }

        private void Digits_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                inputTxt.Text = "";
                flag = false;
            }
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            inputTxt.Text += btn.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {                
            no1 = Convert.ToDouble(inputTxt.Text);
            op = ((System.Windows.Forms.Button)sender).Text;
            flag = true;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToDouble(inputTxt.Text);
            switch (op)
            {
                case "+":
                    result = no1 + no2;
                    break;
                case "-":
                    result = no1 - no2;
                    break;
                case "*":
                    result = no1 * no2;
                    break;
                case "÷":
                     result = no1 / no2;
                    break;
                case "xʸ":
                    result = Math.Pow(no1, no2);
                    break;
            }
            inputTxt.Text = result.ToString();
            flag = true;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!inputTxt.Text.Contains("."))
                inputTxt.Text += ".";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            no1 = 0;
            no2 = 0;
            result = 0;
            inputTxt.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int length = inputTxt.TextLength - 1;
            string text = inputTxt.Text;
            inputTxt.Clear();
            for (int i = 0; i < length; i++)
                inputTxt.Text = inputTxt.Text + text[i];
        }

        private void factorialBtn_Click(object sender, EventArgs e)
        {
            if (inputTxt.Text.Contains("."))
            {
                MessageBox.Show("This function cannot take decimal values.");
                clearBtn_Click(sender, e);
            } else
            {
                int i, fact = 1;
                int number = Convert.ToInt32(inputTxt.Text);
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }

                inputTxt.Text = fact.ToString();
                // flag = true; // what is this for? but it's common in operator buttons & equals sign
            }
                
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {

            double number = Convert.ToDouble(inputTxt.Text);
            number = number * number;

            inputTxt.Text = number.ToString();
            // flag = true; // what is this for? but it's common in operator buttons & equals sign
        }

        private void onBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Visible = true;
            offBtn.Visible = true;
            onBtn.Visible = false;
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Visible = false;
            onBtn.Visible = true;
            offBtn.Visible = false;
        }

        private void absoluteBtn_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(inputTxt.Text);
            number = Math.Abs(number);

            inputTxt.Text = number.ToString();
            // flag = true; // what is this for? but it's common in operator buttons & equals sign
        }

        private void negativeBtn_Click(object sender, EventArgs e)
        {
            if (inputTxt.Text.StartsWith("-"))
            {
                //It's negative now, so strip the `-` sign to make it positive
                inputTxt.Text = inputTxt.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(inputTxt.Text) && decimal.Parse(inputTxt.Text) != 0)
            {
                //It's positive now, so prefix the value with the `-` sign to make it negative
                inputTxt.Text = "-" + inputTxt.Text;
            }
        }
    }

    //private void onBtn_Click(object sender, EventArgs e)
    //{
    //    contentPanel.Visible = true;
    //    offBtn.Visible = true;
    //    onBtn.Visible = false;
    //}

    //private void offBtn_Click(object sender, EventArgs e)
    //{
    //    contentPanel.Visible = false;
    //    onBtn.Visible = true;
    //    offBtn.Visible = false;
    //}
}


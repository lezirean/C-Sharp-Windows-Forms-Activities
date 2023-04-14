using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Final_Project
{
    public partial class ReceiptForm : Form
    {
        //String fullname = "", studentNo = "", yearLevelAndCourse = "", purposeOfRequest = "";
        //String requestedDocuments = "", certifications = "";
        //String notes = "";

        MySqlConnection con = new MySqlConnection(
            "server=localhost; userid=root; password=; database=onlineapplicationrecords;"
            );
        MySqlCommand cmd;
        MySqlDataAdapter data;

        String receiptNo, receiptDate;
        Byte[] receiptImage;

        string sql;
        int result;
        public ReceiptForm(string fullname, string studentNo, string yearLevelAndCourse, string purposeOfRequest, string requestedDocuments, string certifications, string notes, string receiptNo, string receiptDate, Byte[] receiptImage)
        {            
            InitializeComponent();

            // receiptContainerPicBox.Image == null
            //officialReceiptNoText
            // !dateReflectedOnOfficialReceiptMaskedText.MaskCompleted
            this.fullNameText.Text = fullname;
            this.studentNoText.Text = studentNo;
            this.yearLevelAndCourseText.Text = yearLevelAndCourse;
            this.purposeOfRequestText.Text = purposeOfRequest;
            this.requestedDocumentsText.Text = requestedDocuments;
            this.certificationsText.Text = certifications;
            this.messageText.Text = notes;

            this.receiptNo = receiptNo;
            this.receiptDate = receiptDate;
            this.receiptImage = receiptImage;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string filePath = @"C:\Users\Leila Borromeo\Documents\PUP 3rd Year\First Semester\IT Elective 1 (C# and .NET)\IT Elective - Final_Project\OnlineAppRecords\" + fullNameText.Text + ".txt";
            //    StreamWriter writer = new StreamWriter(filePath);

            //    using (writer)
            //    {
            //        writer.WriteLine("Fill out date: " + DateTime.Now.ToString("M/d/yyyy hh:mm:ss"));
            //        writer.WriteLine("Full name: " + fullNameText.Text);
            //        writer.WriteLine("Student Number: " + studentNoText.Text);
            //        writer.WriteLine("Year Level and Course: " + yearLevelAndCourseText.Text);
            //        writer.WriteLine("Purpose of Request: " + purposeOfRequestText.Text);
            //        writer.WriteLine("Requested Documents: " + requestedDocumentsText.Text);
            //        writer.WriteLine("Certifications: " + certificationsText.Text);
            //        writer.WriteLine("Note: " + messageText.Text);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("An error has occurred.\nYour record has not been saved.", "Error" );
            //}


            DateTime timeNow = DateTime.Today;

            if (String.IsNullOrEmpty(receiptNo) || String.IsNullOrEmpty(receiptDate) || receiptImage == null || receiptImage.Length == 0)
            {
                sql = "INSERT INTO records (fullName, studentNumber, yearLevelAndCourse, purposeOfRequest, requestedDocuments, certifications, notes, dateToday) VALUES " +
               "('" + fullNameText.Text + "', '" + studentNoText.Text + "', '" + yearLevelAndCourseText.Text + "', '" + purposeOfRequestText.Text + "', '" + requestedDocumentsText.Text + "', '" + certificationsText.Text + "', '" + messageText.Text + "', '" + timeNow.ToString("yyyy/MM/dd") + "')";

                insertDB(sql, "Error: Record has not been saved to database.", "Success: Record has been saved to database.");
                
            } 
            else
            {
                sql = "INSERT INTO records (fullName, studentNumber, yearLevelAndCourse, purposeOfRequest, requestedDocuments, certifications, notes, dateToday, receiptNumber, receiptDate, receiptImage) VALUES " +
              "('" + fullNameText.Text + "', '" + studentNoText.Text + "', '" + yearLevelAndCourseText.Text + "', '" + purposeOfRequestText.Text + "', '" + requestedDocumentsText.Text + "', '" + certificationsText.Text + "', '" + messageText.Text + "', '"+ timeNow.ToString("yyyy/MM/dd") + "', '"+receiptNo+ "', '"+receiptDate+ "', '"+receiptImage+"')";

                insertDB(sql, "Error: Record has not been saved to database.", "Success: Record has been saved to database.");
            }


            EntryForm entryForm = new EntryForm();
            entryForm.Show();
            this.Close();
        }

        private void insertDB(string sql, string msg_false, string msg_true)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                con.Close();
            }
        }

    }
}

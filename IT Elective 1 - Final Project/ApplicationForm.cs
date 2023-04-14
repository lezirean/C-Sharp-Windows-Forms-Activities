using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        int panel = 0;
        bool isSubmitted = false;
        String imageLocation = "";

        private void showPage(int panel)
        {
            if(panel == 1)
            {
                termsAndConditionsPanel.Visible = true;
                infoPanel.Visible = false;
                inputReceiptDetailsPanel.Visible = false;
                messagePanel.Visible = false;
                previousBtn.Enabled = false;
                nextBtn.Enabled = true;
                submitBtn.Enabled = false;
            }
            else if (panel == 2)
            {
                termsAndConditionsPanel.Visible = false;
                infoPanel.Visible = true;
                inputReceiptDetailsPanel.Visible = false;
                messagePanel.Visible = false;
                previousBtn.Enabled = true;
                nextBtn.Enabled = true;
                submitBtn.Enabled = false;
            }
            else if (panel == 3)
            {
                termsAndConditionsPanel.Visible = false;
                infoPanel.Visible = false;
                inputReceiptDetailsPanel.Visible = true;
                messagePanel.Visible = false;
                previousBtn.Enabled = true;
                nextBtn.Enabled = true;
                submitBtn.Enabled = false;
            }
            else if (panel == 4)
            {
                termsAndConditionsPanel.Visible = false;
                infoPanel.Visible = false;
                inputReceiptDetailsPanel.Visible = false;
                messagePanel.Visible = true;
                previousBtn.Enabled = true;
                nextBtn.Enabled = false;
                submitBtn.Enabled = true;
            }

        }

        private void ApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // call something like a clear btn to clear all the form
            // this.Hide();

            //EntryForm entryForm = new EntryForm();
            //entryForm.Show();
            if (isSubmitted == false)
            {
                EntryForm entryForm = new EntryForm();
                entryForm.Show();
            }
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            showPage(++panel);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // if terms&conditions panel is visible
            if (panel == 1)
            {
                bool isOK = true;

                if (!dataPrivacyChkBox.Checked || !onSiteTransactionChkBox.Checked || !threeWorkingDaysChkBox.Checked || !torChkBox.Checked || !authorizationLetterChkBox.Checked || !unclaimedDocsChkBox.Checked)
                {
                    isOK = false;
                }

                if (!isOK)
                {
                    MessageBox.Show("Please tick all checkboxes.");
                } else
                {
                    showPage(++panel);
                }
            } 
            else if (panel == 2) // if info panel is visible
            {
                bool isOK = true;

                if (!msRdBtn.Checked && !mrRdBtn.Checked && !mrsRdBtn.Checked && !mxRdBtn.Checked)
                {
                    isOK = false;
                }

                if (addressText.Text == "" || firstNameText.Text == "" || middleNameText.Text == "" || lastNameText.Text == "" || !contactNoMaskedText.MaskCompleted || string.IsNullOrEmpty(courseCmbBox.Text) || string.IsNullOrEmpty(yearLevelCmbBox.Text) || !studentNoMaskedText.MaskCompleted || !contactNoMaskedText.MaskCompleted || !yearAdmittedMaskedText.MaskCompleted || !lastSYAttendedMaskedText.MaskCompleted)
                {
                    isOK = false;
                }

                if (docsRequestedChkListBox.CheckedItems.Count == 0 || certificationChkListBox.CheckedItems.Count == 0 || string.IsNullOrEmpty(purposeOfRequestCmbBox.Text))
                {
                    isOK = false;
                }

                if (!firstCopyYesRdBtn.Checked && !firstCopyNoRdBtn.Checked)
                {
                    isOK = false;
                }

                if (!isOK)
                {
                    MessageBox.Show("Please accomplish all fields.");
                }
                else
                { 
                    // check which firstCopy radio button has been checked
                    if (firstCopyYesRdBtn.Checked)
                    {
                        panel += 2;
                        showPage(panel);
                    } else if (firstCopyNoRdBtn.Checked)
                    {
                        showPage(++panel);
                    }  
                }
            } 
            else if (panel == 3)
            {
                bool isOK = true;

                if (string.IsNullOrEmpty(officialReceiptNoText.Text) || !dateReflectedOnOfficialReceiptMaskedText.MaskCompleted || receiptContainerPicBox.Image == null)
                {
                    isOK = false;
                }

                if (!isOK)
                {
                    MessageBox.Show("Please accomplish all fields.");
                } 
                else
                {
                    showPage(++panel);
                }
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if(panel == 4)
            {
                panel -= 2;
                showPage(panel);
            } else
            {
                showPage(--panel);
            }
           
        }

        private void uploadReceiptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    receiptContainerPicBox.ImageLocation = imageLocation;
                }
            } catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // code here if yes ang sagot, aka the user is sure they want to submit
            if (MessageBox.Show("Are you sure you want to submit now?\nMake sure all the information you've input are correct.", "Double check your information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isSubmitted = true;
                String honorific = "";
                String fullname, studentNo, yearLevelAndCourse, purposeOfRequest, docs, certs, notes;
                String receiptNo, receiptDate;
               
                ReceiptForm receipt;

                if (mrRdBtn.Checked)
                {
                    honorific = "Mr.";
                } else if (msRdBtn.Checked)
                {
                    honorific = "Ms.";
                } else if (mrsRdBtn.Checked)
                {
                    honorific = "Mrs.";
                } else
                {
                    honorific = "Mx.";
                }

                fullname = honorific + " " + firstNameText.Text + " " + middleNameText.Text + " " + lastNameText.Text;
                studentNo = studentNoMaskedText.Text;
                yearLevelAndCourse = yearLevelCmbBox.SelectedItem.ToString() + ", " + courseCmbBox.SelectedItem.ToString();
                purposeOfRequest = purposeOfRequestCmbBox.SelectedItem.ToString();

                Byte[] receiptImage = null;
                receiptNo = officialReceiptNoText.Text;
                receiptDate = dateReflectedOnOfficialReceiptMaskedText.Text;
                if (receiptContainerPicBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    receiptContainerPicBox.Image.Save(ms, receiptContainerPicBox.Image.RawFormat);
                    receiptImage = ms.ToArray();
                }
 

                string endl = Environment.NewLine;

                if (docsRequestedChkListBox.CheckedIndices.Count == 0)
                {
                    docs = "N/A";
                } else
                {
                    docs = "";
                    for (int x = 0; x < docsRequestedChkListBox.CheckedItems.Count; x++)
                    {
                        docs = docs + (x + 1).ToString() + ". " + docsRequestedChkListBox.CheckedItems[x].ToString() + endl;
                    }
                }

                certs = "";
                for (int x = 0; x < certificationChkListBox.CheckedItems.Count; x++)
                {
                    certs = certs + (x + 1).ToString() + ". " + certificationChkListBox.CheckedItems[x].ToString() + endl;
                }

                if (string.IsNullOrEmpty(messageText.Text))
                {
                    notes = "N/A";                
                } else
                {
                    notes = messageText.Text;
                }

                receipt = new ReceiptForm(fullname, studentNo, yearLevelAndCourse, purposeOfRequest, docs, certs, notes, receiptNo, receiptDate, receiptImage);
                receipt.Show();
                this.Close();

            }
        }

        private void firstCopyYesRdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void firstCopyNoRdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

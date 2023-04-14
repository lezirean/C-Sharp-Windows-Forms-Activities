namespace BORROMEO_Leila_Validating_Inputs
{
    partial class ValidatingInputs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.validatingInputsLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.detailsGrpBox = new System.Windows.Forms.GroupBox();
            this.detailsRichText = new System.Windows.Forms.RichTextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.detailsGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // validatingInputsLbl
            // 
            this.validatingInputsLbl.AutoSize = true;
            this.validatingInputsLbl.BackColor = System.Drawing.Color.Transparent;
            this.validatingInputsLbl.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatingInputsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.validatingInputsLbl.Location = new System.Drawing.Point(125, 32);
            this.validatingInputsLbl.Name = "validatingInputsLbl";
            this.validatingInputsLbl.Size = new System.Drawing.Size(228, 31);
            this.validatingInputsLbl.TabIndex = 0;
            this.validatingInputsLbl.Text = "Validating Inputs";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nameLbl.Location = new System.Drawing.Point(22, 135);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(101, 132);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 25);
            this.nameText.TabIndex = 0;
            this.nameText.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.BackColor = System.Drawing.Color.Transparent;
            this.cityLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cityLbl.Location = new System.Drawing.Point(22, 177);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(32, 17);
            this.cityLbl.TabIndex = 0;
            this.cityLbl.Text = "City";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(101, 174);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 25);
            this.cityText.TabIndex = 1;
            this.cityText.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.BackColor = System.Drawing.Color.Transparent;
            this.ageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ageLbl.Location = new System.Drawing.Point(22, 223);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(33, 17);
            this.ageLbl.TabIndex = 0;
            this.ageLbl.Text = "Age";
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(101, 220);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 25);
            this.ageText.TabIndex = 2;
            this.ageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageText_KeyPress);
            this.ageText.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
            // 
            // detailsGrpBox
            // 
            this.detailsGrpBox.BackColor = System.Drawing.Color.Transparent;
            this.detailsGrpBox.Controls.Add(this.detailsRichText);
            this.detailsGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.detailsGrpBox.Location = new System.Drawing.Point(244, 108);
            this.detailsGrpBox.Name = "detailsGrpBox";
            this.detailsGrpBox.Size = new System.Drawing.Size(200, 146);
            this.detailsGrpBox.TabIndex = 5;
            this.detailsGrpBox.TabStop = false;
            this.detailsGrpBox.Text = "Details";
            // 
            // detailsRichText
            // 
            this.detailsRichText.BackColor = System.Drawing.Color.White;
            this.detailsRichText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsRichText.Font = new System.Drawing.Font("HP Simplified Hans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsRichText.Location = new System.Drawing.Point(0, 16);
            this.detailsRichText.Name = "detailsRichText";
            this.detailsRichText.ReadOnly = true;
            this.detailsRichText.Size = new System.Drawing.Size(200, 130);
            this.detailsRichText.TabIndex = 0;
            this.detailsRichText.Text = "";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.okBtn.Location = new System.Drawing.Point(278, 293);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.clearBtn.Location = new System.Drawing.Point(369, 293);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ValidatingInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BORROMEO_Leila_Validating_Inputs.Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 351);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.detailsGrpBox);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.validatingInputsLbl);
            this.Font = new System.Drawing.Font("HP Simplified Hans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ValidatingInputs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validating Inputs";
            this.detailsGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label validatingInputsLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.GroupBox detailsGrpBox;
        private System.Windows.Forms.RichTextBox detailsRichText;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}


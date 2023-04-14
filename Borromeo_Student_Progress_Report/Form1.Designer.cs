namespace Borromeo_Student_Progress_Report
{
    partial class Form1
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpboxScores = new System.Windows.Forms.GroupBox();
            this.grpboxResult = new System.Windows.Forms.GroupBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDSA = new System.Windows.Forms.Label();
            this.lblWebDev = new System.Windows.Forms.Label();
            this.txtDsa = new System.Windows.Forms.TextBox();
            this.txtWebDev = new System.Windows.Forms.TextBox();
            this.lblOperatingSystems = new System.Windows.Forms.Label();
            this.lblPython = new System.Windows.Forms.Label();
            this.lblElective = new System.Windows.Forms.Label();
            this.txtOs = new System.Windows.Forms.TextBox();
            this.txtPython = new System.Windows.Forms.TextBox();
            this.txtElective = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.grpboxScores.SuspendLayout();
            this.grpboxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(204, 38);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(245, 23);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Student Progress Report";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRollNo.Location = new System.Drawing.Point(43, 85);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(57, 18);
            this.lblRollNo.TabIndex = 1;
            this.lblRollNo.Text = "Roll No.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(43, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // grpboxScores
            // 
            this.grpboxScores.Controls.Add(this.lblElective);
            this.grpboxScores.Controls.Add(this.lblPython);
            this.grpboxScores.Controls.Add(this.lblOperatingSystems);
            this.grpboxScores.Controls.Add(this.lblDSA);
            this.grpboxScores.Controls.Add(this.txtElective);
            this.grpboxScores.Controls.Add(this.txtPython);
            this.grpboxScores.Controls.Add(this.txtOs);
            this.grpboxScores.Controls.Add(this.txtWebDev);
            this.grpboxScores.Controls.Add(this.txtDsa);
            this.grpboxScores.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxScores.Location = new System.Drawing.Point(46, 155);
            this.grpboxScores.Name = "grpboxScores";
            this.grpboxScores.Size = new System.Drawing.Size(245, 204);
            this.grpboxScores.TabIndex = 2;
            this.grpboxScores.TabStop = false;
            this.grpboxScores.Text = "Scores";
            // 
            // grpboxResult
            // 
            this.grpboxResult.Controls.Add(this.lblPercentage);
            this.grpboxResult.Controls.Add(this.txtPercentage);
            this.grpboxResult.Controls.Add(this.lblResult);
            this.grpboxResult.Controls.Add(this.txtTotal);
            this.grpboxResult.Controls.Add(this.lblDivision);
            this.grpboxResult.Controls.Add(this.txtDivision);
            this.grpboxResult.Controls.Add(this.lblTotal);
            this.grpboxResult.Controls.Add(this.txtResult);
            this.grpboxResult.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxResult.Location = new System.Drawing.Point(326, 155);
            this.grpboxResult.Name = "grpboxResult";
            this.grpboxResult.Size = new System.Drawing.Size(263, 204);
            this.grpboxResult.TabIndex = 3;
            this.grpboxResult.TabStop = false;
            this.grpboxResult.Text = "Result";
            // 
            // txtRollNo
            // 
            this.txtRollNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.ForeColor = System.Drawing.Color.Black;
            this.txtRollNo.Location = new System.Drawing.Point(121, 82);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(140, 23);
            this.txtRollNo.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(121, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 23);
            this.txtName.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOk.Location = new System.Drawing.Point(328, 388);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightBlue;
            this.btnNew.Location = new System.Drawing.Point(422, 388);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(514, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDSA
            // 
            this.lblDSA.AutoSize = true;
            this.lblDSA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDSA.Location = new System.Drawing.Point(16, 33);
            this.lblDSA.Name = "lblDSA";
            this.lblDSA.Size = new System.Drawing.Size(35, 18);
            this.lblDSA.TabIndex = 1;
            this.lblDSA.Text = "DSA";
            // 
            // lblWebDev
            // 
            this.lblWebDev.AutoSize = true;
            this.lblWebDev.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebDev.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWebDev.Location = new System.Drawing.Point(62, 222);
            this.lblWebDev.Name = "lblWebDev";
            this.lblWebDev.Size = new System.Drawing.Size(69, 18);
            this.lblWebDev.TabIndex = 1;
            this.lblWebDev.Text = "Web Dev";
            // 
            // txtDsa
            // 
            this.txtDsa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDsa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDsa.Location = new System.Drawing.Point(115, 29);
            this.txtDsa.Name = "txtDsa";
            this.txtDsa.Size = new System.Drawing.Size(100, 22);
            this.txtDsa.TabIndex = 2;
            // 
            // txtWebDev
            // 
            this.txtWebDev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebDev.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtWebDev.Location = new System.Drawing.Point(115, 63);
            this.txtWebDev.Name = "txtWebDev";
            this.txtWebDev.Size = new System.Drawing.Size(100, 22);
            this.txtWebDev.TabIndex = 3;
            // 
            // lblOperatingSystems
            // 
            this.lblOperatingSystems.AutoSize = true;
            this.lblOperatingSystems.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystems.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOperatingSystems.Location = new System.Drawing.Point(16, 102);
            this.lblOperatingSystems.Name = "lblOperatingSystems";
            this.lblOperatingSystems.Size = new System.Drawing.Size(27, 18);
            this.lblOperatingSystems.TabIndex = 1;
            this.lblOperatingSystems.Text = "OS";
            // 
            // lblPython
            // 
            this.lblPython.AutoSize = true;
            this.lblPython.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPython.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPython.Location = new System.Drawing.Point(16, 135);
            this.lblPython.Name = "lblPython";
            this.lblPython.Size = new System.Drawing.Size(53, 18);
            this.lblPython.TabIndex = 1;
            this.lblPython.Text = "Python";
            // 
            // lblElective
            // 
            this.lblElective.AutoSize = true;
            this.lblElective.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElective.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblElective.Location = new System.Drawing.Point(15, 168);
            this.lblElective.Name = "lblElective";
            this.lblElective.Size = new System.Drawing.Size(75, 18);
            this.lblElective.TabIndex = 1;
            this.lblElective.Text = "JP Elective";
            // 
            // txtOs
            // 
            this.txtOs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOs.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtOs.Location = new System.Drawing.Point(115, 98);
            this.txtOs.Name = "txtOs";
            this.txtOs.Size = new System.Drawing.Size(100, 22);
            this.txtOs.TabIndex = 4;
            // 
            // txtPython
            // 
            this.txtPython.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPython.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPython.Location = new System.Drawing.Point(115, 133);
            this.txtPython.Name = "txtPython";
            this.txtPython.Size = new System.Drawing.Size(100, 22);
            this.txtPython.TabIndex = 5;
            // 
            // txtElective
            // 
            this.txtElective.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElective.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtElective.Location = new System.Drawing.Point(115, 167);
            this.txtElective.Name = "txtElective";
            this.txtElective.Size = new System.Drawing.Size(100, 22);
            this.txtElective.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Coral;
            this.txtTotal.Location = new System.Drawing.Point(125, 34);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 7;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentage.ForeColor = System.Drawing.Color.Coral;
            this.txtPercentage.Location = new System.Drawing.Point(125, 68);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.ReadOnly = true;
            this.txtPercentage.Size = new System.Drawing.Size(100, 23);
            this.txtPercentage.TabIndex = 8;
            // 
            // txtDivision
            // 
            this.txtDivision.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivision.ForeColor = System.Drawing.Color.Coral;
            this.txtDivision.Location = new System.Drawing.Point(125, 103);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.ReadOnly = true;
            this.txtDivision.Size = new System.Drawing.Size(100, 23);
            this.txtDivision.TabIndex = 9;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Coral;
            this.txtResult.Location = new System.Drawing.Point(125, 138);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 23);
            this.txtResult.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(20, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 18);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDivision.Location = new System.Drawing.Point(20, 104);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(55, 18);
            this.lblDivision.TabIndex = 1;
            this.lblDivision.Text = "Division";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblResult.Location = new System.Drawing.Point(20, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 18);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPercentage.Location = new System.Drawing.Point(20, 69);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(81, 18);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.Text = "Percentage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.lblWebDev);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.grpboxResult);
            this.Controls.Add(this.grpboxScores);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Student Progress Report";
            this.grpboxScores.ResumeLayout(false);
            this.grpboxScores.PerformLayout();
            this.grpboxResult.ResumeLayout(false);
            this.grpboxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpboxScores;
        private System.Windows.Forms.GroupBox grpboxResult;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblElective;
        private System.Windows.Forms.Label lblPython;
        private System.Windows.Forms.Label lblOperatingSystems;
        private System.Windows.Forms.Label lblDSA;
        private System.Windows.Forms.TextBox txtElective;
        private System.Windows.Forms.TextBox txtPython;
        private System.Windows.Forms.TextBox txtOs;
        private System.Windows.Forms.TextBox txtWebDev;
        private System.Windows.Forms.TextBox txtDsa;
        private System.Windows.Forms.Label lblWebDev;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtResult;
    }
}


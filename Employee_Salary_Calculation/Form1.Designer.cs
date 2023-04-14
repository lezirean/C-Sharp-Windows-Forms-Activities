namespace Employee_Salary_Calculation
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtBasicSal = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAllowances = new System.Windows.Forms.GroupBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.lblTA = new System.Windows.Forms.Label();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblTDS = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtTDS = new System.Windows.Forms.TextBox();
            this.grpSalary = new System.Windows.Forms.GroupBox();
            this.txtGrossSal = new System.Windows.Forms.TextBox();
            this.lblNetSal = new System.Windows.Forms.Label();
            this.txtNetSal = new System.Windows.Forms.TextBox();
            this.lblGrossSal = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBasicInfo.SuspendLayout();
            this.grpAllowances.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(21, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(484, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Employee Management Application";
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBasicInfo.Controls.Add(this.txtBasicSal);
            this.grpBasicInfo.Controls.Add(this.txtEmpName);
            this.grpBasicInfo.Controls.Add(this.txtEmpNo);
            this.grpBasicInfo.Controls.Add(this.label3);
            this.grpBasicInfo.Controls.Add(this.label2);
            this.grpBasicInfo.Controls.Add(this.label1);
            this.grpBasicInfo.Location = new System.Drawing.Point(25, 76);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(546, 118);
            this.grpBasicInfo.TabIndex = 1;
            this.grpBasicInfo.TabStop = false;
            // 
            // txtBasicSal
            // 
            this.txtBasicSal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSal.Location = new System.Drawing.Point(277, 79);
            this.txtBasicSal.Name = "txtBasicSal";
            this.txtBasicSal.Size = new System.Drawing.Size(121, 23);
            this.txtBasicSal.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(277, 51);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(121, 23);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNo.Location = new System.Drawing.Point(277, 23);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(121, 23);
            this.txtEmpNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Basic Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee No.";
            // 
            // grpAllowances
            // 
            this.grpAllowances.BackColor = System.Drawing.Color.Transparent;
            this.grpAllowances.Controls.Add(this.txtHRA);
            this.grpAllowances.Controls.Add(this.lblTA);
            this.grpAllowances.Controls.Add(this.txtDA);
            this.grpAllowances.Controls.Add(this.txtTA);
            this.grpAllowances.Controls.Add(this.lblDA);
            this.grpAllowances.Controls.Add(this.lblHRA);
            this.grpAllowances.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAllowances.Location = new System.Drawing.Point(25, 210);
            this.grpAllowances.Name = "grpAllowances";
            this.grpAllowances.Size = new System.Drawing.Size(263, 231);
            this.grpAllowances.TabIndex = 2;
            this.grpAllowances.TabStop = false;
            this.grpAllowances.Text = "Allowances";
            // 
            // txtHRA
            // 
            this.txtHRA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHRA.Location = new System.Drawing.Point(9, 64);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(241, 23);
            this.txtHRA.TabIndex = 1;
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTA.Location = new System.Drawing.Point(7, 100);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(140, 16);
            this.lblTA.TabIndex = 0;
            this.lblTA.Text = "Travelling Allowance";
            // 
            // txtDA
            // 
            this.txtDA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDA.Location = new System.Drawing.Point(11, 178);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(239, 23);
            this.txtDA.TabIndex = 1;
            // 
            // txtTA
            // 
            this.txtTA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTA.Location = new System.Drawing.Point(10, 122);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(240, 23);
            this.txtTA.TabIndex = 1;
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDA.Location = new System.Drawing.Point(9, 158);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(138, 16);
            this.lblDA.TabIndex = 0;
            this.lblDA.Text = "Dearness Allowance";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRA.Location = new System.Drawing.Point(8, 40);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(153, 16);
            this.lblHRA.TabIndex = 0;
            this.lblHRA.Text = "House Rent Allowance";
            // 
            // lblTDS
            // 
            this.lblTDS.AutoSize = true;
            this.lblTDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDS.Location = new System.Drawing.Point(14, 64);
            this.lblTDS.Name = "lblTDS";
            this.lblTDS.Size = new System.Drawing.Size(35, 16);
            this.lblTDS.TabIndex = 0;
            this.lblTDS.Text = "TDS";
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPF.Location = new System.Drawing.Point(14, 37);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(24, 16);
            this.lblPF.TabIndex = 0;
            this.lblPF.Text = "PF";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtPF);
            this.groupBox1.Controls.Add(this.lblTDS);
            this.groupBox1.Controls.Add(this.lblPF);
            this.groupBox1.Controls.Add(this.txtTDS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deductions";
            // 
            // txtPF
            // 
            this.txtPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPF.Location = new System.Drawing.Point(72, 37);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(169, 22);
            this.txtPF.TabIndex = 1;
            // 
            // txtTDS
            // 
            this.txtTDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDS.Location = new System.Drawing.Point(72, 63);
            this.txtTDS.Name = "txtTDS";
            this.txtTDS.Size = new System.Drawing.Size(169, 22);
            this.txtTDS.TabIndex = 1;
            // 
            // grpSalary
            // 
            this.grpSalary.BackColor = System.Drawing.Color.Transparent;
            this.grpSalary.Controls.Add(this.txtGrossSal);
            this.grpSalary.Controls.Add(this.lblNetSal);
            this.grpSalary.Controls.Add(this.txtNetSal);
            this.grpSalary.Controls.Add(this.lblGrossSal);
            this.grpSalary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalary.Location = new System.Drawing.Point(302, 339);
            this.grpSalary.Name = "grpSalary";
            this.grpSalary.Size = new System.Drawing.Size(269, 102);
            this.grpSalary.TabIndex = 4;
            this.grpSalary.TabStop = false;
            // 
            // txtGrossSal
            // 
            this.txtGrossSal.Location = new System.Drawing.Point(120, 30);
            this.txtGrossSal.Name = "txtGrossSal";
            this.txtGrossSal.Size = new System.Drawing.Size(121, 23);
            this.txtGrossSal.TabIndex = 1;
            // 
            // lblNetSal
            // 
            this.lblNetSal.AutoSize = true;
            this.lblNetSal.Location = new System.Drawing.Point(13, 59);
            this.lblNetSal.Name = "lblNetSal";
            this.lblNetSal.Size = new System.Drawing.Size(76, 16);
            this.lblNetSal.TabIndex = 0;
            this.lblNetSal.Text = "Net Salary";
            // 
            // txtNetSal
            // 
            this.txtNetSal.Location = new System.Drawing.Point(120, 62);
            this.txtNetSal.Name = "txtNetSal";
            this.txtNetSal.Size = new System.Drawing.Size(121, 23);
            this.txtNetSal.TabIndex = 1;
            // 
            // lblGrossSal
            // 
            this.lblGrossSal.AutoSize = true;
            this.lblGrossSal.Location = new System.Drawing.Point(14, 33);
            this.lblGrossSal.Name = "lblGrossSal";
            this.lblGrossSal.Size = new System.Drawing.Size(89, 16);
            this.lblGrossSal.TabIndex = 0;
            this.lblGrossSal.Text = "Gross Salary";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnNew.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(405, 470);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(496, 470);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(314, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Employee_Salary_Calculation.Properties.Resources.luke_chesser_pJadQetzTkI_unsplash;
            this.ClientSize = new System.Drawing.Size(596, 515);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grpSalary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAllowances);
            this.Controls.Add(this.grpBasicInfo);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Employee Salary Calculation";
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.grpAllowances.ResumeLayout(false);
            this.grpAllowances.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSalary.ResumeLayout(false);
            this.grpSalary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.GroupBox grpAllowances;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpSalary;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBasicSal;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.Label lblTDS;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtTDS;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtGrossSal;
        private System.Windows.Forms.Label lblNetSal;
        private System.Windows.Forms.TextBox txtNetSal;
        private System.Windows.Forms.Label lblGrossSal;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.Label lblHRA;
    }
}


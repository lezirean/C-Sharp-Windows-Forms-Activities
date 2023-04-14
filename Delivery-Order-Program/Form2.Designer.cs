namespace Delivery_Order_Program
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picboxLogin = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.grpboxBurgers = new System.Windows.Forms.GroupBox();
            this.chkXtraLongChicken = new System.Windows.Forms.CheckBox();
            this.chkMushroomSwissKing = new System.Windows.Forms.CheckBox();
            this.chk4Cheese = new System.Windows.Forms.CheckBox();
            this.chkWhopper = new System.Windows.Forms.CheckBox();
            this.chkFlameGrilled = new System.Windows.Forms.CheckBox();
            this.grpboxDrinks = new System.Windows.Forms.GroupBox();
            this.chkBKJoeCoffee = new System.Windows.Forms.CheckBox();
            this.chkIcedTea = new System.Windows.Forms.CheckBox();
            this.chkSoftDrink = new System.Windows.Forms.CheckBox();
            this.grpboxSidekicks = new System.Windows.Forms.GroupBox();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.chkOnionRings = new System.Windows.Forms.CheckBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.cmbboxFoodService = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.errCash = new System.Windows.Forms.ErrorProvider(this.components);
            this.radbtnCash = new System.Windows.Forms.RadioButton();
            this.radbtnGcash = new System.Windows.Forms.RadioButton();
            this.lblFoodService = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).BeginInit();
            this.grpboxBurgers.SuspendLayout();
            this.grpboxDrinks.SuspendLayout();
            this.grpboxSidekicks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCash)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxLogin
            // 
            this.picboxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxLogin.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogin.Image")));
            this.picboxLogin.Location = new System.Drawing.Point(14, 12);
            this.picboxLogin.Name = "picboxLogin";
            this.picboxLogin.Size = new System.Drawing.Size(73, 78);
            this.picboxLogin.TabIndex = 5;
            this.picboxLogin.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Linen;
            this.lblMenu.Location = new System.Drawing.Point(93, 33);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(127, 44);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Menu";
            // 
            // grpboxBurgers
            // 
            this.grpboxBurgers.BackColor = System.Drawing.Color.Transparent;
            this.grpboxBurgers.Controls.Add(this.chkXtraLongChicken);
            this.grpboxBurgers.Controls.Add(this.chkMushroomSwissKing);
            this.grpboxBurgers.Controls.Add(this.chk4Cheese);
            this.grpboxBurgers.Controls.Add(this.chkWhopper);
            this.grpboxBurgers.Controls.Add(this.chkFlameGrilled);
            this.grpboxBurgers.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxBurgers.ForeColor = System.Drawing.Color.Linen;
            this.grpboxBurgers.Location = new System.Drawing.Point(13, 112);
            this.grpboxBurgers.Name = "grpboxBurgers";
            this.grpboxBurgers.Size = new System.Drawing.Size(270, 223);
            this.grpboxBurgers.TabIndex = 7;
            this.grpboxBurgers.TabStop = false;
            this.grpboxBurgers.Text = "Burgers";
            // 
            // chkXtraLongChicken
            // 
            this.chkXtraLongChicken.AutoSize = true;
            this.chkXtraLongChicken.Location = new System.Drawing.Point(7, 180);
            this.chkXtraLongChicken.Name = "chkXtraLongChicken";
            this.chkXtraLongChicken.Size = new System.Drawing.Size(238, 24);
            this.chkXtraLongChicken.TabIndex = 4;
            this.chkXtraLongChicken.Text = "X-TRA LONG CHICKEN (Php. 99)";
            this.chkXtraLongChicken.UseVisualStyleBackColor = true;
            // 
            // chkMushroomSwissKing
            // 
            this.chkMushroomSwissKing.AutoSize = true;
            this.chkMushroomSwissKing.Location = new System.Drawing.Point(7, 145);
            this.chkMushroomSwissKing.Name = "chkMushroomSwissKing";
            this.chkMushroomSwissKing.Size = new System.Drawing.Size(263, 24);
            this.chkMushroomSwissKing.TabIndex = 3;
            this.chkMushroomSwissKing.Text = "MUSHROOM SWISS KING (Php. 165)";
            this.chkMushroomSwissKing.UseVisualStyleBackColor = true;
            // 
            // chk4Cheese
            // 
            this.chk4Cheese.AutoSize = true;
            this.chk4Cheese.Location = new System.Drawing.Point(7, 110);
            this.chk4Cheese.Name = "chk4Cheese";
            this.chk4Cheese.Size = new System.Drawing.Size(241, 24);
            this.chk4Cheese.TabIndex = 2;
            this.chk4Cheese.Text = "4-CHEESE WHOPPER (Php.  185)";
            this.chk4Cheese.UseVisualStyleBackColor = true;
            // 
            // chkWhopper
            // 
            this.chkWhopper.AutoSize = true;
            this.chkWhopper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkWhopper.Location = new System.Drawing.Point(7, 68);
            this.chkWhopper.Name = "chkWhopper";
            this.chkWhopper.Size = new System.Drawing.Size(172, 44);
            this.chkWhopper.TabIndex = 1;
            this.chkWhopper.Text = "WHOPPER (Php. 155)\r\n\r\n";
            this.chkWhopper.UseVisualStyleBackColor = true;
            // 
            // chkFlameGrilled
            // 
            this.chkFlameGrilled.AutoSize = true;
            this.chkFlameGrilled.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlameGrilled.Location = new System.Drawing.Point(6, 40);
            this.chkFlameGrilled.Name = "chkFlameGrilled";
            this.chkFlameGrilled.Size = new System.Drawing.Size(263, 42);
            this.chkFlameGrilled.TabIndex = 0;
            this.chkFlameGrilled.Text = "FLAME-GRILLED CHEESEBURGER (Php. 69)\r\n\r\n";
            this.chkFlameGrilled.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkFlameGrilled.UseVisualStyleBackColor = true;
            // 
            // grpboxDrinks
            // 
            this.grpboxDrinks.BackColor = System.Drawing.Color.Transparent;
            this.grpboxDrinks.Controls.Add(this.chkBKJoeCoffee);
            this.grpboxDrinks.Controls.Add(this.chkIcedTea);
            this.grpboxDrinks.Controls.Add(this.chkSoftDrink);
            this.grpboxDrinks.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxDrinks.ForeColor = System.Drawing.Color.Linen;
            this.grpboxDrinks.Location = new System.Drawing.Point(302, 112);
            this.grpboxDrinks.Name = "grpboxDrinks";
            this.grpboxDrinks.Size = new System.Drawing.Size(191, 223);
            this.grpboxDrinks.TabIndex = 7;
            this.grpboxDrinks.TabStop = false;
            this.grpboxDrinks.Text = "Drinks";
            // 
            // chkBKJoeCoffee
            // 
            this.chkBKJoeCoffee.AutoSize = true;
            this.chkBKJoeCoffee.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBKJoeCoffee.Location = new System.Drawing.Point(13, 144);
            this.chkBKJoeCoffee.Name = "chkBKJoeCoffee";
            this.chkBKJoeCoffee.Size = new System.Drawing.Size(169, 23);
            this.chkBKJoeCoffee.TabIndex = 2;
            this.chkBKJoeCoffee.Text = "BK JOE COFFEE (Php. 75)";
            this.chkBKJoeCoffee.UseVisualStyleBackColor = true;
            // 
            // chkIcedTea
            // 
            this.chkIcedTea.AutoSize = true;
            this.chkIcedTea.Location = new System.Drawing.Point(14, 98);
            this.chkIcedTea.Name = "chkIcedTea";
            this.chkIcedTea.Size = new System.Drawing.Size(155, 24);
            this.chkIcedTea.TabIndex = 1;
            this.chkIcedTea.Text = "ICED TEA (Php. 55)";
            this.chkIcedTea.UseVisualStyleBackColor = true;
            // 
            // chkSoftDrink
            // 
            this.chkSoftDrink.AutoSize = true;
            this.chkSoftDrink.Location = new System.Drawing.Point(14, 52);
            this.chkSoftDrink.Name = "chkSoftDrink";
            this.chkSoftDrink.Size = new System.Drawing.Size(174, 24);
            this.chkSoftDrink.TabIndex = 0;
            this.chkSoftDrink.Text = "SOFT DRINK (Php. 50)";
            this.chkSoftDrink.UseVisualStyleBackColor = true;
            // 
            // grpboxSidekicks
            // 
            this.grpboxSidekicks.BackColor = System.Drawing.Color.Transparent;
            this.grpboxSidekicks.Controls.Add(this.chkSundae);
            this.grpboxSidekicks.Controls.Add(this.chkOnionRings);
            this.grpboxSidekicks.Controls.Add(this.chkFries);
            this.grpboxSidekicks.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxSidekicks.ForeColor = System.Drawing.Color.Linen;
            this.grpboxSidekicks.Location = new System.Drawing.Point(511, 112);
            this.grpboxSidekicks.Name = "grpboxSidekicks";
            this.grpboxSidekicks.Size = new System.Drawing.Size(234, 223);
            this.grpboxSidekicks.TabIndex = 7;
            this.grpboxSidekicks.TabStop = false;
            this.grpboxSidekicks.Text = "Sidekicks";
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(20, 145);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(148, 24);
            this.chkSundae.TabIndex = 2;
            this.chkSundae.Text = "SUNDAE (Php. 49)";
            this.chkSundae.UseVisualStyleBackColor = true;
            // 
            // chkOnionRings
            // 
            this.chkOnionRings.AutoSize = true;
            this.chkOnionRings.Location = new System.Drawing.Point(20, 98);
            this.chkOnionRings.Name = "chkOnionRings";
            this.chkOnionRings.Size = new System.Drawing.Size(182, 24);
            this.chkOnionRings.TabIndex = 1;
            this.chkOnionRings.Text = "ONION RINGS (Php. 59)";
            this.chkOnionRings.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Location = new System.Drawing.Point(20, 52);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(132, 24);
            this.chkFries.TabIndex = 0;
            this.chkFries.Text = "FRIES (Php. 59)";
            this.chkFries.UseVisualStyleBackColor = true;
            // 
            // cmbboxFoodService
            // 
            this.cmbboxFoodService.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxFoodService.FormattingEnabled = true;
            this.cmbboxFoodService.Items.AddRange(new object[] {
            "Dine-in",
            "Take out",
            "Delivery"});
            this.cmbboxFoodService.Location = new System.Drawing.Point(113, 369);
            this.cmbboxFoodService.Name = "cmbboxFoodService";
            this.cmbboxFoodService.Size = new System.Drawing.Size(121, 24);
            this.cmbboxFoodService.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Linen;
            this.lblTotal.Location = new System.Drawing.Point(456, 371);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 22);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.Linen;
            this.lblCash.Location = new System.Drawing.Point(456, 409);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(51, 22);
            this.lblCash.TabIndex = 9;
            this.lblCash.Text = "Cash:";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.ForeColor = System.Drawing.Color.Linen;
            this.lblTransaction.Location = new System.Drawing.Point(507, 480);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(0, 20);
            this.lblTransaction.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTotal.Location = new System.Drawing.Point(511, 372);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(161, 23);
            this.txtTotal.TabIndex = 10;
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCash.Location = new System.Drawing.Point(511, 409);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(161, 23);
            this.txtCash.TabIndex = 10;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.Linen;
            this.lblChange.Location = new System.Drawing.Point(438, 448);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(71, 22);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "Change:";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Firebrick;
            this.txtChange.Location = new System.Drawing.Point(511, 448);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(161, 23);
            this.txtChange.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CadetBlue;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(531, 537);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(617, 537);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 26);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // errCash
            // 
            this.errCash.ContainerControl = this;
            // 
            // radbtnCash
            // 
            this.radbtnCash.AutoSize = true;
            this.radbtnCash.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnCash.ForeColor = System.Drawing.Color.Linen;
            this.radbtnCash.Location = new System.Drawing.Point(16, 420);
            this.radbtnCash.Name = "radbtnCash";
            this.radbtnCash.Size = new System.Drawing.Size(49, 17);
            this.radbtnCash.TabIndex = 12;
            this.radbtnCash.TabStop = true;
            this.radbtnCash.Text = "Cash";
            this.radbtnCash.UseVisualStyleBackColor = true;
            // 
            // radbtnGcash
            // 
            this.radbtnGcash.AutoSize = true;
            this.radbtnGcash.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnGcash.ForeColor = System.Drawing.Color.Linen;
            this.radbtnGcash.Location = new System.Drawing.Point(77, 420);
            this.radbtnGcash.Name = "radbtnGcash";
            this.radbtnGcash.Size = new System.Drawing.Size(56, 17);
            this.radbtnGcash.TabIndex = 13;
            this.radbtnGcash.TabStop = true;
            this.radbtnGcash.Text = "GCash";
            this.radbtnGcash.UseVisualStyleBackColor = true;
            // 
            // lblFoodService
            // 
            this.lblFoodService.AutoSize = true;
            this.lblFoodService.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodService.ForeColor = System.Drawing.Color.Linen;
            this.lblFoodService.Location = new System.Drawing.Point(13, 370);
            this.lblFoodService.Name = "lblFoodService";
            this.lblFoodService.Size = new System.Drawing.Size(96, 18);
            this.lblFoodService.TabIndex = 14;
            this.lblFoodService.Text = "Food Service:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(757, 610);
            this.Controls.Add(this.lblFoodService);
            this.Controls.Add(this.radbtnGcash);
            this.Controls.Add(this.radbtnCash);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbboxFoodService);
            this.Controls.Add(this.grpboxSidekicks);
            this.Controls.Add(this.grpboxDrinks);
            this.Controls.Add(this.grpboxBurgers);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.picboxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Burger King Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).EndInit();
            this.grpboxBurgers.ResumeLayout(false);
            this.grpboxBurgers.PerformLayout();
            this.grpboxDrinks.ResumeLayout(false);
            this.grpboxDrinks.PerformLayout();
            this.grpboxSidekicks.ResumeLayout(false);
            this.grpboxSidekicks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxLogin;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.GroupBox grpboxBurgers;
        private System.Windows.Forms.GroupBox grpboxDrinks;
        private System.Windows.Forms.GroupBox grpboxSidekicks;
        private System.Windows.Forms.CheckBox chkXtraLongChicken;
        private System.Windows.Forms.CheckBox chkMushroomSwissKing;
        private System.Windows.Forms.CheckBox chk4Cheese;
        private System.Windows.Forms.CheckBox chkWhopper;
        private System.Windows.Forms.CheckBox chkFlameGrilled;
        private System.Windows.Forms.ComboBox cmbboxFoodService;
        private System.Windows.Forms.CheckBox chkBKJoeCoffee;
        private System.Windows.Forms.CheckBox chkIcedTea;
        private System.Windows.Forms.CheckBox chkSoftDrink;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.CheckBox chkOnionRings;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ErrorProvider errCash;
        private System.Windows.Forms.RadioButton radbtnGcash;
        private System.Windows.Forms.RadioButton radbtnCash;
        private System.Windows.Forms.Label lblFoodService;
    }
}
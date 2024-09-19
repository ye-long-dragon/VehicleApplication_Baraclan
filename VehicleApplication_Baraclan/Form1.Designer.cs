namespace VehicleApplication_Baraclan
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
            this.lblPurchaseVehicle = new System.Windows.Forms.Label();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.btnCar = new System.Windows.Forms.RadioButton();
            this.btnMotorcycle = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTrunk = new System.Windows.Forms.TextBox();
            this.txtDoors = new System.Windows.Forms.TextBox();
            this.txtPowerSource = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtMotorType = new System.Windows.Forms.TextBox();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTrunkCapacity = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.lblPowerSource = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMotorcycleType = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNoTotal = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblNoChange = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPurchaseVehicle
            // 
            this.lblPurchaseVehicle.AutoSize = true;
            this.lblPurchaseVehicle.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseVehicle.Location = new System.Drawing.Point(262, 67);
            this.lblPurchaseVehicle.Name = "lblPurchaseVehicle";
            this.lblPurchaseVehicle.Size = new System.Drawing.Size(284, 40);
            this.lblPurchaseVehicle.TabIndex = 0;
            this.lblPurchaseVehicle.Text = "Purchase Vehicle";
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Location = new System.Drawing.Point(47, 151);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(162, 16);
            this.lblQuestion1.TabIndex = 3;
            this.lblQuestion1.Text = "What are you purchasing?";
            // 
            // btnCar
            // 
            this.btnCar.AutoSize = true;
            this.btnCar.Location = new System.Drawing.Point(50, 191);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(49, 20);
            this.btnCar.TabIndex = 4;
            this.btnCar.TabStop = true;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_CheckedChanged);
            // 
            // btnMotorcycle
            // 
            this.btnMotorcycle.AutoSize = true;
            this.btnMotorcycle.Location = new System.Drawing.Point(157, 191);
            this.btnMotorcycle.Name = "btnMotorcycle";
            this.btnMotorcycle.Size = new System.Drawing.Size(94, 20);
            this.btnMotorcycle.TabIndex = 5;
            this.btnMotorcycle.TabStop = true;
            this.btnMotorcycle.Text = "Motorcycle";
            this.btnMotorcycle.UseVisualStyleBackColor = true;
            this.btnMotorcycle.Click += new System.EventHandler(this.btnMotorcycle_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtEngine);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtTrunk);
            this.panel1.Controls.Add(this.txtDoors);
            this.panel1.Controls.Add(this.txtPowerSource);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.txtMotorType);
            this.panel1.Controls.Add(this.txtCarType);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.txtMake);
            this.panel1.Controls.Add(this.btnCompute);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblEngine);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblTrunkCapacity);
            this.panel1.Controls.Add(this.lblDoors);
            this.panel1.Controls.Add(this.lblPowerSource);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblMotorcycleType);
            this.panel1.Controls.Add(this.lblCarType);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.lblMake);
            this.panel1.Location = new System.Drawing.Point(27, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 366);
            this.panel1.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(419, 113);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(245, 22);
            this.txtPrice.TabIndex = 22;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(516, 71);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(210, 22);
            this.txtEngine.TabIndex = 21;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(417, 31);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(245, 22);
            this.txtYear.TabIndex = 20;
            // 
            // txtTrunk
            // 
            this.txtTrunk.Location = new System.Drawing.Point(160, 318);
            this.txtTrunk.Name = "txtTrunk";
            this.txtTrunk.Size = new System.Drawing.Size(245, 22);
            this.txtTrunk.TabIndex = 19;
            // 
            // txtDoors
            // 
            this.txtDoors.Location = new System.Drawing.Point(157, 269);
            this.txtDoors.Name = "txtDoors";
            this.txtDoors.Size = new System.Drawing.Size(245, 22);
            this.txtDoors.TabIndex = 18;
            // 
            // txtPowerSource
            // 
            this.txtPowerSource.Location = new System.Drawing.Point(139, 229);
            this.txtPowerSource.Name = "txtPowerSource";
            this.txtPowerSource.Size = new System.Drawing.Size(245, 22);
            this.txtPowerSource.TabIndex = 17;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(95, 193);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(245, 22);
            this.txtColor.TabIndex = 16;
            // 
            // txtMotorType
            // 
            this.txtMotorType.Location = new System.Drawing.Point(154, 152);
            this.txtMotorType.Name = "txtMotorType";
            this.txtMotorType.Size = new System.Drawing.Size(245, 22);
            this.txtMotorType.TabIndex = 15;
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(102, 113);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(245, 22);
            this.txtCarType.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(87, 71);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(245, 22);
            this.txtModel.TabIndex = 13;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(87, 31);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(245, 22);
            this.txtMake.TabIndex = 12;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(601, 300);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(90, 34);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(372, 116);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(372, 74);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(138, 16);
            this.lblEngine.TabIndex = 9;
            this.lblEngine.Text = "Engine Displacement:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(372, 34);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            // 
            // lblTrunkCapacity
            // 
            this.lblTrunkCapacity.AutoSize = true;
            this.lblTrunkCapacity.Location = new System.Drawing.Point(39, 318);
            this.lblTrunkCapacity.Name = "lblTrunkCapacity";
            this.lblTrunkCapacity.Size = new System.Drawing.Size(115, 16);
            this.lblTrunkCapacity.TabIndex = 7;
            this.lblTrunkCapacity.Text = "Trunk Capacity(L):";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(39, 275);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(112, 16);
            this.lblDoors.TabIndex = 6;
            this.lblDoors.Text = "Number of Doors:";
            // 
            // lblPowerSource
            // 
            this.lblPowerSource.AutoSize = true;
            this.lblPowerSource.Location = new System.Drawing.Point(39, 232);
            this.lblPowerSource.Name = "lblPowerSource";
            this.lblPowerSource.Size = new System.Drawing.Size(94, 16);
            this.lblPowerSource.TabIndex = 5;
            this.lblPowerSource.Text = "Power Source:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(37, 196);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 16);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // lblMotorcycleType
            // 
            this.lblMotorcycleType.AutoSize = true;
            this.lblMotorcycleType.Location = new System.Drawing.Point(37, 155);
            this.lblMotorcycleType.Name = "lblMotorcycleType";
            this.lblMotorcycleType.Size = new System.Drawing.Size(111, 16);
            this.lblMotorcycleType.TabIndex = 3;
            this.lblMotorcycleType.Text = "Motorcycle Type:";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(37, 116);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(66, 16);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Car Type:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(37, 74);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 16);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(37, 34);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(44, 16);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(64, 650);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // lblNoTotal
            // 
            this.lblNoTotal.AutoSize = true;
            this.lblNoTotal.Location = new System.Drawing.Point(119, 650);
            this.lblNoTotal.Name = "lblNoTotal";
            this.lblNoTotal.Size = new System.Drawing.Size(31, 16);
            this.lblNoTotal.TabIndex = 13;
            this.lblNoTotal.Text = "0.00";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(64, 690);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(125, 16);
            this.lblPayment.TabIndex = 14;
            this.lblPayment.Text = "Payment Received:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(64, 730);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(57, 16);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "Change:";
            // 
            // lblNoChange
            // 
            this.lblNoChange.AutoSize = true;
            this.lblNoChange.Location = new System.Drawing.Point(126, 730);
            this.lblNoChange.Name = "lblNoChange";
            this.lblNoChange.Size = new System.Drawing.Size(31, 16);
            this.lblNoChange.TabIndex = 16;
            this.lblNoChange.Text = "0.00";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(193, 687);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(245, 22);
            this.txtPayment.TabIndex = 23;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(456, 681);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(90, 34);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 924);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblNoChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblNoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMotorcycle);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.lblPurchaseVehicle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchaseVehicle;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.RadioButton btnCar;
        private System.Windows.Forms.RadioButton btnMotorcycle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPowerSource;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMotorcycleType;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTrunkCapacity;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNoTotal;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTrunk;
        private System.Windows.Forms.TextBox txtDoors;
        private System.Windows.Forms.TextBox txtPowerSource;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtMotorType;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblNoChange;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}


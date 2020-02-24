namespace BikeRentalSim
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.BikeTypeButton = new System.Windows.Forms.Button();
            this.HoursButton = new System.Windows.Forms.Button();
            this.BrandButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkoutControl2 = new BikeRentalSim.CheckoutControl();
            this.summaryControl1 = new BikeRentalSim.SummaryControl();
            this.hoursControl1 = new BikeRentalSim.HoursControl();
            this.bikeTypeCustomControl1 = new BikeRentalSim.BikeTypeControl();
            this.bikeBrandControl1 = new BikeRentalSim.BikeBrandControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.homeControl1 = new BikeRentalSim.HomeControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SummaryButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.CheckoutButton);
            this.panel1.Controls.Add(this.BikeTypeButton);
            this.panel1.Controls.Add(this.HoursButton);
            this.panel1.Controls.Add(this.BrandButton);
            this.panel1.Location = new System.Drawing.Point(108, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 49);
            this.panel1.TabIndex = 0;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckoutButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CheckoutButton.Location = new System.Drawing.Point(390, 0);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(86, 50);
            this.CheckoutButton.TabIndex = 4;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(82, 52);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click_1);
            // 
            // BikeTypeButton
            // 
            this.BikeTypeButton.BackColor = System.Drawing.Color.Transparent;
            this.BikeTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BikeTypeButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BikeTypeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BikeTypeButton.Location = new System.Drawing.Point(82, 0);
            this.BikeTypeButton.Name = "BikeTypeButton";
            this.BikeTypeButton.Size = new System.Drawing.Size(86, 52);
            this.BikeTypeButton.TabIndex = 1;
            this.BikeTypeButton.Text = "Bike Type";
            this.BikeTypeButton.UseVisualStyleBackColor = false;
            this.BikeTypeButton.Click += new System.EventHandler(this.BikeTypeButton_Click);
            // 
            // HoursButton
            // 
            this.HoursButton.BackColor = System.Drawing.Color.Transparent;
            this.HoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoursButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HoursButton.Location = new System.Drawing.Point(238, 0);
            this.HoursButton.Name = "HoursButton";
            this.HoursButton.Size = new System.Drawing.Size(68, 50);
            this.HoursButton.TabIndex = 3;
            this.HoursButton.Text = "Hours";
            this.HoursButton.UseVisualStyleBackColor = false;
            this.HoursButton.Click += new System.EventHandler(this.HourseButton_Click);
            // 
            // BrandButton
            // 
            this.BrandButton.BackColor = System.Drawing.Color.Transparent;
            this.BrandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrandButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BrandButton.Location = new System.Drawing.Point(168, 0);
            this.BrandButton.Name = "BrandButton";
            this.BrandButton.Size = new System.Drawing.Size(72, 50);
            this.BrandButton.TabIndex = 2;
            this.BrandButton.Text = "Brand";
            this.BrandButton.UseVisualStyleBackColor = false;
            this.BrandButton.Click += new System.EventHandler(this.BrandButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 361);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "1(800)-123-4567";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(24, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Midwest Bikes";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // checkoutControl2
            // 
            this.checkoutControl2.Location = new System.Drawing.Point(108, 48);
            this.checkoutControl2.Name = "checkoutControl2";
            this.checkoutControl2.Size = new System.Drawing.Size(476, 314);
            this.checkoutControl2.TabIndex = 8;
            // 
            // summaryControl1
            // 
            this.summaryControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.summaryControl1.Location = new System.Drawing.Point(108, 48);
            this.summaryControl1.Name = "summaryControl1";
            this.summaryControl1.Size = new System.Drawing.Size(476, 314);
            this.summaryControl1.TabIndex = 6;
            // 
            // hoursControl1
            // 
            this.hoursControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hoursControl1.Location = new System.Drawing.Point(108, 48);
            this.hoursControl1.Name = "hoursControl1";
            this.hoursControl1.Size = new System.Drawing.Size(476, 314);
            this.hoursControl1.TabIndex = 5;
            // 
            // bikeTypeCustomControl1
            // 
            this.bikeTypeCustomControl1.Location = new System.Drawing.Point(108, 48);
            this.bikeTypeCustomControl1.Name = "bikeTypeCustomControl1";
            this.bikeTypeCustomControl1.Size = new System.Drawing.Size(476, 314);
            this.bikeTypeCustomControl1.TabIndex = 3;
            this.bikeTypeCustomControl1.Load += new System.EventHandler(this.bikeTypeCustomControl1_Load);
            // 
            // bikeBrandControl1
            // 
            this.bikeBrandControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bikeBrandControl1.Location = new System.Drawing.Point(108, 48);
            this.bikeBrandControl1.Name = "bikeBrandControl1";
            this.bikeBrandControl1.Size = new System.Drawing.Size(476, 314);
            this.bikeBrandControl1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.homeControl1);
            this.panel3.Location = new System.Drawing.Point(108, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 316);
            this.panel3.TabIndex = 9;
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.Transparent;
            this.SummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SummaryButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SummaryButton.Location = new System.Drawing.Point(302, 0);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(90, 50);
            this.SummaryButton.TabIndex = 5;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homeControl1.Location = new System.Drawing.Point(0, 0);
            this.homeControl1.MaximumSize = new System.Drawing.Size(476, 314);
            this.homeControl1.MinimumSize = new System.Drawing.Size(476, 314);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(476, 314);
            this.homeControl1.TabIndex = 0;
            this.homeControl1.Load += new System.EventHandler(this.homeControl1_Load);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.checkoutControl2);
            this.Controls.Add(this.summaryControl1);
            this.Controls.Add(this.hoursControl1);
            this.Controls.Add(this.bikeTypeCustomControl1);
            this.Controls.Add(this.bikeBrandControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "WelcomeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BrandButton;
        private System.Windows.Forms.Button BikeTypeButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button HoursButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BikeTypeControl bikeTypeCustomControl1;
        private BikeBrandControl bikeBrandControl1;
        private HoursControl hoursControl1;
        private SummaryControl summaryControl1;
        private CheckoutControl checkoutControl2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SummaryButton;
        private HomeControl homeControl1;
    }
}


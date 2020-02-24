namespace BikeRentalSim
{
    partial class BikeTypeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BikeTypeControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SingeBikeButton = new System.Windows.Forms.Button();
            this.TandemBikeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // SingeBikeButton
            // 
            this.SingeBikeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SingeBikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingeBikeButton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.SingeBikeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SingeBikeButton.Location = new System.Drawing.Point(70, 178);
            this.SingeBikeButton.Name = "SingeBikeButton";
            this.SingeBikeButton.Size = new System.Drawing.Size(96, 36);
            this.SingeBikeButton.TabIndex = 2;
            this.SingeBikeButton.Text = "Single";
            this.SingeBikeButton.UseVisualStyleBackColor = false;
            this.SingeBikeButton.Click += new System.EventHandler(this.SingleBikeButton_Click);
            // 
            // TandemBikeButton
            // 
            this.TandemBikeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.TandemBikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TandemBikeButton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.TandemBikeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TandemBikeButton.Location = new System.Drawing.Point(290, 178);
            this.TandemBikeButton.Name = "TandemBikeButton";
            this.TandemBikeButton.Size = new System.Drawing.Size(96, 36);
            this.TandemBikeButton.TabIndex = 3;
            this.TandemBikeButton.Text = "Tandem";
            this.TandemBikeButton.UseVisualStyleBackColor = false;
            this.TandemBikeButton.Click += new System.EventHandler(this.TandemBikeButton_Click);
            // 
            // BikeTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.TandemBikeButton);
            this.Controls.Add(this.SingeBikeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BikeTypeControl";
            this.Size = new System.Drawing.Size(476, 314);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SingeBikeButton;
        private System.Windows.Forms.Button TandemBikeButton;
    }
}

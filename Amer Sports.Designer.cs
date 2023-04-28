
namespace MidtermProject
{
    partial class Amer_Sports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amer_Sports));
            this.picAmerSports = new System.Windows.Forms.PictureBox();
            this.lblAmer1 = new System.Windows.Forms.Label();
            this.lblAmeSport3 = new System.Windows.Forms.Label();
            this.lblAmer2 = new System.Windows.Forms.Label();
            this.grpBoxBrands = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAmerSports)).BeginInit();
            this.grpBoxBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picAmerSports
            // 
            this.picAmerSports.Image = ((System.Drawing.Image)(resources.GetObject("picAmerSports.Image")));
            this.picAmerSports.Location = new System.Drawing.Point(12, 12);
            this.picAmerSports.Name = "picAmerSports";
            this.picAmerSports.Size = new System.Drawing.Size(128, 87);
            this.picAmerSports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmerSports.TabIndex = 0;
            this.picAmerSports.TabStop = false;
            // 
            // lblAmer1
            // 
            this.lblAmer1.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmer1.Location = new System.Drawing.Point(327, 12);
            this.lblAmer1.Name = "lblAmer1";
            this.lblAmer1.Size = new System.Drawing.Size(217, 55);
            this.lblAmer1.TabIndex = 1;
            this.lblAmer1.Text = "Amer Sports";
            // 
            // lblAmeSport3
            // 
            this.lblAmeSport3.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmeSport3.Location = new System.Drawing.Point(6, 38);
            this.lblAmeSport3.Name = "lblAmeSport3";
            this.lblAmeSport3.Size = new System.Drawing.Size(256, 227);
            this.lblAmeSport3.TabIndex = 2;
            this.lblAmeSport3.Text = resources.GetString("lblAmeSport3.Text");
            // 
            // lblAmer2
            // 
            this.lblAmer2.Font = new System.Drawing.Font("Courier New", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmer2.Location = new System.Drawing.Point(158, 67);
            this.lblAmer2.Name = "lblAmer2";
            this.lblAmer2.Size = new System.Drawing.Size(615, 104);
            this.lblAmer2.TabIndex = 4;
            this.lblAmer2.Text = "Amer Sports is a global group of the world’s most recognized and respected sports" +
    " and outdoor brands. We share ambitions while celebrating the uniqueness of each" +
    " one.";
            // 
            // grpBoxBrands
            // 
            this.grpBoxBrands.Controls.Add(this.pictureBox1);
            this.grpBoxBrands.Controls.Add(this.lblAmeSport3);
            this.grpBoxBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxBrands.Location = new System.Drawing.Point(12, 158);
            this.grpBoxBrands.Name = "grpBoxBrands";
            this.grpBoxBrands.Size = new System.Drawing.Size(722, 289);
            this.grpBoxBrands.TabIndex = 5;
            this.grpBoxBrands.TabStop = false;
            this.grpBoxBrands.Text = "Our Brands";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(740, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Amer_Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBoxBrands);
            this.Controls.Add(this.lblAmer2);
            this.Controls.Add(this.lblAmer1);
            this.Controls.Add(this.picAmerSports);
            this.Name = "Amer_Sports";
            this.Text = "Amer_Sports";
            this.Load += new System.EventHandler(this.Amer_Sports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAmerSports)).EndInit();
            this.grpBoxBrands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAmerSports;
        private System.Windows.Forms.Label lblAmer1;
        private System.Windows.Forms.Label lblAmeSport3;
        private System.Windows.Forms.Label lblAmer2;
        private System.Windows.Forms.GroupBox grpBoxBrands;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}
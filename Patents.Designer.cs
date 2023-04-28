
namespace MidtermProject
{
    partial class Patents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patents));
            this.lblPaten1 = new System.Windows.Forms.Label();
            this.lblPatent2 = new System.Windows.Forms.Label();
            this.lblPatent3 = new System.Windows.Forms.Label();
            this.lblPatent4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPaten1
            // 
            this.lblPaten1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaten1.Location = new System.Drawing.Point(283, 38);
            this.lblPaten1.Name = "lblPaten1";
            this.lblPaten1.Size = new System.Drawing.Size(144, 37);
            this.lblPaten1.TabIndex = 1;
            this.lblPaten1.Text = "PATENTS";
            // 
            // lblPatent2
            // 
            this.lblPatent2.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatent2.Location = new System.Drawing.Point(12, 108);
            this.lblPatent2.Name = "lblPatent2";
            this.lblPatent2.Size = new System.Drawing.Size(776, 78);
            this.lblPatent2.TabIndex = 2;
            this.lblPatent2.Text = "In accordance with U.S Patent Statute 35 U.S.C. Section 287(a), Wilson Sporting G" +
    "oods Co. provides notice to the public that the products listed in the attached " +
    "spreadsheet are patented. ";
            // 
            // lblPatent3
            // 
            this.lblPatent3.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatent3.Location = new System.Drawing.Point(12, 186);
            this.lblPatent3.Name = "lblPatent3";
            this.lblPatent3.Size = new System.Drawing.Size(776, 106);
            this.lblPatent3.TabIndex = 3;
            this.lblPatent3.Text = resources.GetString("lblPatent3.Text");
            this.lblPatent3.Click += new System.EventHandler(this.lblPatent3_Click);
            // 
            // lblPatent4
            // 
            this.lblPatent4.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatent4.Location = new System.Drawing.Point(12, 292);
            this.lblPatent4.Name = "lblPatent4";
            this.lblPatent4.Size = new System.Drawing.Size(760, 99);
            this.lblPatent4.TabIndex = 4;
            this.lblPatent4.Text = resources.GetString("lblPatent4.Text");
            this.lblPatent4.Click += new System.EventHandler(this.lblPatent4_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(672, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 44);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Patents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPatent4);
            this.Controls.Add(this.lblPatent3);
            this.Controls.Add(this.lblPatent2);
            this.Controls.Add(this.lblPaten1);
            this.Name = "Patents";
            this.Text = "Patents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPaten1;
        private System.Windows.Forms.Label lblPatent2;
        private System.Windows.Forms.Label lblPatent3;
        private System.Windows.Forms.Label lblPatent4;
        private System.Windows.Forms.Button btnClose;
    }
}
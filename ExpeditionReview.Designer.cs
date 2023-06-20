
namespace MidtermProject
{
    partial class ExpeditionReview
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
            this.grpBoxOrderonShipping = new System.Windows.Forms.GroupBox();
            this.dataGridOrdersShipping = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxCompletedOrders = new System.Windows.Forms.GroupBox();
            this.dataGridCompletedOrders = new System.Windows.Forms.DataGridView();
            this.grpBoxOrderonShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdersShipping)).BeginInit();
            this.grpBoxCompletedOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompletedOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxOrderonShipping
            // 
            this.grpBoxOrderonShipping.Controls.Add(this.dataGridOrdersShipping);
            this.grpBoxOrderonShipping.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxOrderonShipping.Location = new System.Drawing.Point(12, 12);
            this.grpBoxOrderonShipping.Name = "grpBoxOrderonShipping";
            this.grpBoxOrderonShipping.Size = new System.Drawing.Size(926, 209);
            this.grpBoxOrderonShipping.TabIndex = 0;
            this.grpBoxOrderonShipping.TabStop = false;
            this.grpBoxOrderonShipping.Text = "Orders on Shipping";
            // 
            // dataGridOrdersShipping
            // 
            this.dataGridOrdersShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdersShipping.Location = new System.Drawing.Point(6, 21);
            this.dataGridOrdersShipping.Name = "dataGridOrdersShipping";
            this.dataGridOrdersShipping.RowHeadersWidth = 51;
            this.dataGridOrdersShipping.RowTemplate.Height = 24;
            this.dataGridOrdersShipping.Size = new System.Drawing.Size(914, 180);
            this.dataGridOrdersShipping.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(12, 472);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 41);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(815, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxCompletedOrders
            // 
            this.grpBoxCompletedOrders.Controls.Add(this.dataGridCompletedOrders);
            this.grpBoxCompletedOrders.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCompletedOrders.Location = new System.Drawing.Point(18, 228);
            this.grpBoxCompletedOrders.Name = "grpBoxCompletedOrders";
            this.grpBoxCompletedOrders.Size = new System.Drawing.Size(914, 219);
            this.grpBoxCompletedOrders.TabIndex = 6;
            this.grpBoxCompletedOrders.TabStop = false;
            this.grpBoxCompletedOrders.Text = "Completed Orders";
            // 
            // dataGridCompletedOrders
            // 
            this.dataGridCompletedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompletedOrders.Location = new System.Drawing.Point(6, 26);
            this.dataGridCompletedOrders.Name = "dataGridCompletedOrders";
            this.dataGridCompletedOrders.RowHeadersWidth = 51;
            this.dataGridCompletedOrders.RowTemplate.Height = 24;
            this.dataGridCompletedOrders.Size = new System.Drawing.Size(902, 187);
            this.dataGridCompletedOrders.TabIndex = 0;
            // 
            // ExpeditionReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 525);
            this.Controls.Add(this.grpBoxCompletedOrders);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpBoxOrderonShipping);
            this.Name = "ExpeditionReview";
            this.Text = "ExpeditionReview";
            this.Load += new System.EventHandler(this.ExpeditionReview_Load);
            this.grpBoxOrderonShipping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdersShipping)).EndInit();
            this.grpBoxCompletedOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompletedOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxOrderonShipping;
        private System.Windows.Forms.DataGridView dataGridOrdersShipping;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxCompletedOrders;
        private System.Windows.Forms.DataGridView dataGridCompletedOrders;
    }
}
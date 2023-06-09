
namespace MidtermProject
{
    partial class WarehouseCheckOrders
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
            this.grpBoxSeeOrders = new System.Windows.Forms.GroupBox();
            this.dataGridOrdersWarehouse = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackToWarehouseHomepage = new System.Windows.Forms.Button();
            this.btnGoToShipping = new System.Windows.Forms.Button();
            this.grpBoxSeeOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdersWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxSeeOrders
            // 
            this.grpBoxSeeOrders.Controls.Add(this.dataGridOrdersWarehouse);
            this.grpBoxSeeOrders.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxSeeOrders.Location = new System.Drawing.Point(6, 12);
            this.grpBoxSeeOrders.Name = "grpBoxSeeOrders";
            this.grpBoxSeeOrders.Size = new System.Drawing.Size(1071, 451);
            this.grpBoxSeeOrders.TabIndex = 0;
            this.grpBoxSeeOrders.TabStop = false;
            this.grpBoxSeeOrders.Text = "Orders";
            // 
            // dataGridOrdersWarehouse
            // 
            this.dataGridOrdersWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdersWarehouse.Location = new System.Drawing.Point(6, 21);
            this.dataGridOrdersWarehouse.Name = "dataGridOrdersWarehouse";
            this.dataGridOrdersWarehouse.RowHeadersWidth = 51;
            this.dataGridOrdersWarehouse.RowTemplate.Height = 24;
            this.dataGridOrdersWarehouse.Size = new System.Drawing.Size(1059, 424);
            this.dataGridOrdersWarehouse.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(972, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnBackToWarehouseHomepage
            // 
            this.btnBackToWarehouseHomepage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBackToWarehouseHomepage.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToWarehouseHomepage.ForeColor = System.Drawing.Color.Red;
            this.btnBackToWarehouseHomepage.Location = new System.Drawing.Point(12, 517);
            this.btnBackToWarehouseHomepage.Name = "btnBackToWarehouseHomepage";
            this.btnBackToWarehouseHomepage.Size = new System.Drawing.Size(105, 51);
            this.btnBackToWarehouseHomepage.TabIndex = 8;
            this.btnBackToWarehouseHomepage.Text = "&Back";
            this.btnBackToWarehouseHomepage.UseVisualStyleBackColor = false;
            this.btnBackToWarehouseHomepage.Click += new System.EventHandler(this.btnBackToWarehouseHomepage_Click_1);
            // 
            // btnGoToShipping
            // 
            this.btnGoToShipping.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGoToShipping.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToShipping.ForeColor = System.Drawing.Color.Red;
            this.btnGoToShipping.Location = new System.Drawing.Point(814, 517);
            this.btnGoToShipping.Name = "btnGoToShipping";
            this.btnGoToShipping.Size = new System.Drawing.Size(126, 51);
            this.btnGoToShipping.TabIndex = 9;
            this.btnGoToShipping.Text = "&Shipping";
            this.btnGoToShipping.UseVisualStyleBackColor = false;
            this.btnGoToShipping.Click += new System.EventHandler(this.btnGoToShipping_Click);
            // 
            // WarehouseCheckOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 580);
            this.Controls.Add(this.btnGoToShipping);
            this.Controls.Add(this.btnBackToWarehouseHomepage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxSeeOrders);
            this.Name = "WarehouseCheckOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Orders";
            this.Load += new System.EventHandler(this.WarehouseCheckOrders_Load);
            this.grpBoxSeeOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdersWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSeeOrders;
        private System.Windows.Forms.DataGridView dataGridOrdersWarehouse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackToWarehouseHomepage;
        private System.Windows.Forms.Button btnGoToShipping;
    }
}
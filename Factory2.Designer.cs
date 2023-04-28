
namespace MidtermProject
{
    partial class Factory2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factory2));
            this.picProductionManagementPage = new System.Windows.Forms.PictureBox();
            this.btnFactory2BacktoFactory = new System.Windows.Forms.Button();
            this.btnExitFactory2 = new System.Windows.Forms.Button();
            this.dataGridTransaction = new System.Windows.Forms.DataGridView();
            this.grpBoxTransaction = new System.Windows.Forms.GroupBox();
            this.lblWarehouse_ID = new System.Windows.Forms.Label();
            this.lblFactoryID = new System.Windows.Forms.Label();
            this.lblProduct_ID = new System.Windows.Forms.Label();
            this.lblTransactionQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxWarehouseID = new System.Windows.Forms.ComboBox();
            this.cmbBoxFactoryID = new System.Windows.Forms.ComboBox();
            this.cmbBoxProductID = new System.Windows.Forms.ComboBox();
            this.txtTransactionQuantity = new System.Windows.Forms.TextBox();
            this.mtxtTransactionDate = new System.Windows.Forms.MaskedTextBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnUpdateTransaction = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.cmbBoxTransactionID = new System.Windows.Forms.ComboBox();
            this.ttpFactoryTransaction = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picProductionManagementPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).BeginInit();
            this.grpBoxTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProductionManagementPage
            // 
            this.picProductionManagementPage.Image = ((System.Drawing.Image)(resources.GetObject("picProductionManagementPage.Image")));
            this.picProductionManagementPage.Location = new System.Drawing.Point(1247, 44);
            this.picProductionManagementPage.Name = "picProductionManagementPage";
            this.picProductionManagementPage.Size = new System.Drawing.Size(206, 178);
            this.picProductionManagementPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductionManagementPage.TabIndex = 0;
            this.picProductionManagementPage.TabStop = false;
            // 
            // btnFactory2BacktoFactory
            // 
            this.btnFactory2BacktoFactory.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFactory2BacktoFactory.ForeColor = System.Drawing.Color.Red;
            this.btnFactory2BacktoFactory.Location = new System.Drawing.Point(12, 638);
            this.btnFactory2BacktoFactory.Name = "btnFactory2BacktoFactory";
            this.btnFactory2BacktoFactory.Size = new System.Drawing.Size(105, 51);
            this.btnFactory2BacktoFactory.TabIndex = 10;
            this.btnFactory2BacktoFactory.Text = "&Back";
            this.btnFactory2BacktoFactory.UseVisualStyleBackColor = true;
            this.btnFactory2BacktoFactory.Click += new System.EventHandler(this.btnFactory2BacktoFactory_Click);
            // 
            // btnExitFactory2
            // 
            this.btnExitFactory2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExitFactory2.ForeColor = System.Drawing.Color.Red;
            this.btnExitFactory2.Location = new System.Drawing.Point(1348, 638);
            this.btnExitFactory2.Name = "btnExitFactory2";
            this.btnExitFactory2.Size = new System.Drawing.Size(105, 51);
            this.btnExitFactory2.TabIndex = 11;
            this.btnExitFactory2.Text = "&Exit";
            this.btnExitFactory2.UseVisualStyleBackColor = true;
            this.btnExitFactory2.Click += new System.EventHandler(this.btnExitFactory2_Click);
            // 
            // dataGridTransaction
            // 
            this.dataGridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaction.Location = new System.Drawing.Point(6, 21);
            this.dataGridTransaction.Name = "dataGridTransaction";
            this.dataGridTransaction.RowHeadersWidth = 51;
            this.dataGridTransaction.RowTemplate.Height = 24;
            this.dataGridTransaction.Size = new System.Drawing.Size(1217, 200);
            this.dataGridTransaction.TabIndex = 4;
            // 
            // grpBoxTransaction
            // 
            this.grpBoxTransaction.Controls.Add(this.dataGridTransaction);
            this.grpBoxTransaction.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxTransaction.Location = new System.Drawing.Point(12, 23);
            this.grpBoxTransaction.Name = "grpBoxTransaction";
            this.grpBoxTransaction.Size = new System.Drawing.Size(1229, 227);
            this.grpBoxTransaction.TabIndex = 12;
            this.grpBoxTransaction.TabStop = false;
            this.grpBoxTransaction.Text = "Transaction";
            // 
            // lblWarehouse_ID
            // 
            this.lblWarehouse_ID.BackColor = System.Drawing.Color.Brown;
            this.lblWarehouse_ID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarehouse_ID.Location = new System.Drawing.Point(14, 296);
            this.lblWarehouse_ID.Name = "lblWarehouse_ID";
            this.lblWarehouse_ID.Size = new System.Drawing.Size(225, 49);
            this.lblWarehouse_ID.TabIndex = 6;
            this.lblWarehouse_ID.Text = "Warehouse_ID:";
            this.lblWarehouse_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFactoryID
            // 
            this.lblFactoryID.BackColor = System.Drawing.Color.Brown;
            this.lblFactoryID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFactoryID.Location = new System.Drawing.Point(14, 386);
            this.lblFactoryID.Name = "lblFactoryID";
            this.lblFactoryID.Size = new System.Drawing.Size(225, 49);
            this.lblFactoryID.TabIndex = 7;
            this.lblFactoryID.Text = "Factory_ID:";
            this.lblFactoryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct_ID
            // 
            this.lblProduct_ID.BackColor = System.Drawing.Color.Brown;
            this.lblProduct_ID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct_ID.Location = new System.Drawing.Point(14, 487);
            this.lblProduct_ID.Name = "lblProduct_ID";
            this.lblProduct_ID.Size = new System.Drawing.Size(225, 49);
            this.lblProduct_ID.TabIndex = 8;
            this.lblProduct_ID.Text = "Product_ID:";
            this.lblProduct_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionQuantity
            // 
            this.lblTransactionQuantity.BackColor = System.Drawing.Color.Brown;
            this.lblTransactionQuantity.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransactionQuantity.Location = new System.Drawing.Point(531, 296);
            this.lblTransactionQuantity.Name = "lblTransactionQuantity";
            this.lblTransactionQuantity.Size = new System.Drawing.Size(221, 49);
            this.lblTransactionQuantity.TabIndex = 9;
            this.lblTransactionQuantity.Text = "Quantity:";
            this.lblTransactionQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Brown;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(527, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 49);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxWarehouseID
            // 
            this.cmbBoxWarehouseID.FormattingEnabled = true;
            this.cmbBoxWarehouseID.Location = new System.Drawing.Point(245, 309);
            this.cmbBoxWarehouseID.Name = "cmbBoxWarehouseID";
            this.cmbBoxWarehouseID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxWarehouseID.TabIndex = 1;
            this.ttpFactoryTransaction.SetToolTip(this.cmbBoxWarehouseID, "Select the warehouse which the products will be send ");
            // 
            // cmbBoxFactoryID
            // 
            this.cmbBoxFactoryID.FormattingEnabled = true;
            this.cmbBoxFactoryID.Location = new System.Drawing.Point(245, 399);
            this.cmbBoxFactoryID.Name = "cmbBoxFactoryID";
            this.cmbBoxFactoryID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxFactoryID.TabIndex = 2;
            this.ttpFactoryTransaction.SetToolTip(this.cmbBoxFactoryID, "Select the Factory ID which products is created");
            // 
            // cmbBoxProductID
            // 
            this.cmbBoxProductID.FormattingEnabled = true;
            this.cmbBoxProductID.Location = new System.Drawing.Point(245, 500);
            this.cmbBoxProductID.Name = "cmbBoxProductID";
            this.cmbBoxProductID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxProductID.TabIndex = 3;
            this.ttpFactoryTransaction.SetToolTip(this.cmbBoxProductID, "Select Product ID ");
            // 
            // txtTransactionQuantity
            // 
            this.txtTransactionQuantity.Location = new System.Drawing.Point(781, 310);
            this.txtTransactionQuantity.Name = "txtTransactionQuantity";
            this.txtTransactionQuantity.Size = new System.Drawing.Size(148, 22);
            this.txtTransactionQuantity.TabIndex = 4;
            this.ttpFactoryTransaction.SetToolTip(this.txtTransactionQuantity, "Enter the product Quantity that will send to Warehouse");
            // 
            // mtxtTransactionDate
            // 
            this.mtxtTransactionDate.Location = new System.Drawing.Point(781, 399);
            this.mtxtTransactionDate.Mask = "00/00/0000";
            this.mtxtTransactionDate.Name = "mtxtTransactionDate";
            this.mtxtTransactionDate.Size = new System.Drawing.Size(148, 22);
            this.mtxtTransactionDate.TabIndex = 5;
            this.ttpFactoryTransaction.SetToolTip(this.mtxtTransactionDate, "Transfer Date");
            this.mtxtTransactionDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTransaction.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.Red;
            this.btnAddTransaction.Location = new System.Drawing.Point(1116, 292);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(105, 51);
            this.btnAddTransaction.TabIndex = 7;
            this.btnAddTransaction.Text = "&Add";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnUpdateTransaction
            // 
            this.btnUpdateTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateTransaction.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateTransaction.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateTransaction.Location = new System.Drawing.Point(1116, 382);
            this.btnUpdateTransaction.Name = "btnUpdateTransaction";
            this.btnUpdateTransaction.Size = new System.Drawing.Size(105, 51);
            this.btnUpdateTransaction.TabIndex = 8;
            this.btnUpdateTransaction.Text = "&Update";
            this.btnUpdateTransaction.UseVisualStyleBackColor = false;
            this.btnUpdateTransaction.Click += new System.EventHandler(this.btnUpdateTransaction_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(1306, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 51);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.BackColor = System.Drawing.Color.Brown;
            this.lblTransactionID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransactionID.Location = new System.Drawing.Point(527, 487);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(225, 49);
            this.lblTransactionID.TabIndex = 19;
            this.lblTransactionID.Text = "Transaction_ID";
            this.lblTransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxTransactionID
            // 
            this.cmbBoxTransactionID.FormattingEnabled = true;
            this.cmbBoxTransactionID.Location = new System.Drawing.Point(781, 500);
            this.cmbBoxTransactionID.Name = "cmbBoxTransactionID";
            this.cmbBoxTransactionID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxTransactionID.TabIndex = 6;
            this.ttpFactoryTransaction.SetToolTip(this.cmbBoxTransactionID, "Select Transaction ID to update selected Transaction");
            // 
            // Factory2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 701);
            this.Controls.Add(this.cmbBoxTransactionID);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.mtxtTransactionDate);
            this.Controls.Add(this.txtTransactionQuantity);
            this.Controls.Add(this.cmbBoxProductID);
            this.Controls.Add(this.cmbBoxFactoryID);
            this.Controls.Add(this.cmbBoxWarehouseID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTransactionQuantity);
            this.Controls.Add(this.lblProduct_ID);
            this.Controls.Add(this.lblFactoryID);
            this.Controls.Add(this.lblWarehouse_ID);
            this.Controls.Add(this.grpBoxTransaction);
            this.Controls.Add(this.btnExitFactory2);
            this.Controls.Add(this.btnFactory2BacktoFactory);
            this.Controls.Add(this.picProductionManagementPage);
            this.Name = "Factory2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production Management";
            this.Load += new System.EventHandler(this.Factory2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProductionManagementPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).EndInit();
            this.grpBoxTransaction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProductionManagementPage;
        private System.Windows.Forms.Button btnFactory2BacktoFactory;
        private System.Windows.Forms.Button btnExitFactory2;
        private System.Windows.Forms.DataGridView dataGridTransaction;
        private System.Windows.Forms.GroupBox grpBoxTransaction;
        private System.Windows.Forms.Label lblWarehouse_ID;
        private System.Windows.Forms.Label lblFactoryID;
        private System.Windows.Forms.Label lblProduct_ID;
        private System.Windows.Forms.Label lblTransactionQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxWarehouseID;
        private System.Windows.Forms.ComboBox cmbBoxFactoryID;
        private System.Windows.Forms.ComboBox cmbBoxProductID;
        private System.Windows.Forms.TextBox txtTransactionQuantity;
        private System.Windows.Forms.MaskedTextBox mtxtTransactionDate;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnUpdateTransaction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.ComboBox cmbBoxTransactionID;
        private System.Windows.Forms.ToolTip ttpFactoryTransaction;
    }
}
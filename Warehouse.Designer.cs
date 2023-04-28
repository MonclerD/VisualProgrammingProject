
namespace MidtermProject
{
    partial class Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.picWarehousePage = new System.Windows.Forms.PictureBox();
            this.btnBackWarehouse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridWarehouseStock = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxTransaction2 = new System.Windows.Forms.GroupBox();
            this.dataGridTransactionAdd = new System.Windows.Forms.DataGridView();
            this.lblWarehouse_ID = new System.Windows.Forms.Label();
            this.cmbBoxWarehouseID = new System.Windows.Forms.ComboBox();
            this.lblFactoryID = new System.Windows.Forms.Label();
            this.lblProduct_ID = new System.Windows.Forms.Label();
            this.cmbBoxFactoryID = new System.Windows.Forms.ComboBox();
            this.cmbBoxProductID = new System.Windows.Forms.ComboBox();
            this.lblTransactionQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.txtTransactionQuantity = new System.Windows.Forms.TextBox();
            this.mtxtTransactionDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxTransactionID = new System.Windows.Forms.ComboBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnUpdateTransaction = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ttpWarehouse = new System.Windows.Forms.ToolTip(this.components);
            this.btnSeeOrdersPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWarehousePage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseStock)).BeginInit();
            this.grpBoxTransaction2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // picWarehousePage
            // 
            this.picWarehousePage.Image = ((System.Drawing.Image)(resources.GetObject("picWarehousePage.Image")));
            this.picWarehousePage.Location = new System.Drawing.Point(1270, 41);
            this.picWarehousePage.Name = "picWarehousePage";
            this.picWarehousePage.Size = new System.Drawing.Size(203, 189);
            this.picWarehousePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarehousePage.TabIndex = 0;
            this.picWarehousePage.TabStop = false;
            this.picWarehousePage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBackWarehouse
            // 
            this.btnBackWarehouse.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackWarehouse.ForeColor = System.Drawing.Color.Red;
            this.btnBackWarehouse.Location = new System.Drawing.Point(12, 677);
            this.btnBackWarehouse.Name = "btnBackWarehouse";
            this.btnBackWarehouse.Size = new System.Drawing.Size(108, 49);
            this.btnBackWarehouse.TabIndex = 9;
            this.btnBackWarehouse.Text = "&Back";
            this.btnBackWarehouse.UseVisualStyleBackColor = true;
            this.btnBackWarehouse.Click += new System.EventHandler(this.btnBackWarehouse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridWarehouseStock);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 224);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction";
            // 
            // dataGridWarehouseStock
            // 
            this.dataGridWarehouseStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouseStock.Location = new System.Drawing.Point(6, 31);
            this.dataGridWarehouseStock.Name = "dataGridWarehouseStock";
            this.dataGridWarehouseStock.RowHeadersWidth = 51;
            this.dataGridWarehouseStock.RowTemplate.Height = 24;
            this.dataGridWarehouseStock.Size = new System.Drawing.Size(1230, 187);
            this.dataGridWarehouseStock.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1355, 677);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 49);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxTransaction2
            // 
            this.grpBoxTransaction2.Controls.Add(this.dataGridTransactionAdd);
            this.grpBoxTransaction2.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxTransaction2.Location = new System.Drawing.Point(18, 242);
            this.grpBoxTransaction2.Name = "grpBoxTransaction2";
            this.grpBoxTransaction2.Size = new System.Drawing.Size(1242, 224);
            this.grpBoxTransaction2.TabIndex = 12;
            this.grpBoxTransaction2.TabStop = false;
            this.grpBoxTransaction2.Text = "Transaction Management";
            // 
            // dataGridTransactionAdd
            // 
            this.dataGridTransactionAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactionAdd.Location = new System.Drawing.Point(6, 26);
            this.dataGridTransactionAdd.Name = "dataGridTransactionAdd";
            this.dataGridTransactionAdd.RowHeadersWidth = 51;
            this.dataGridTransactionAdd.RowTemplate.Height = 24;
            this.dataGridTransactionAdd.Size = new System.Drawing.Size(1230, 187);
            this.dataGridTransactionAdd.TabIndex = 0;
            // 
            // lblWarehouse_ID
            // 
            this.lblWarehouse_ID.BackColor = System.Drawing.Color.Brown;
            this.lblWarehouse_ID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarehouse_ID.Location = new System.Drawing.Point(20, 469);
            this.lblWarehouse_ID.Name = "lblWarehouse_ID";
            this.lblWarehouse_ID.Size = new System.Drawing.Size(225, 49);
            this.lblWarehouse_ID.TabIndex = 7;
            this.lblWarehouse_ID.Text = "Warehouse_ID:";
            this.lblWarehouse_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxWarehouseID
            // 
            this.cmbBoxWarehouseID.FormattingEnabled = true;
            this.cmbBoxWarehouseID.Location = new System.Drawing.Point(251, 482);
            this.cmbBoxWarehouseID.Name = "cmbBoxWarehouseID";
            this.cmbBoxWarehouseID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxWarehouseID.TabIndex = 0;
            this.ttpWarehouse.SetToolTip(this.cmbBoxWarehouseID, "Warehouse ID not name!");
            // 
            // lblFactoryID
            // 
            this.lblFactoryID.BackColor = System.Drawing.Color.Brown;
            this.lblFactoryID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFactoryID.Location = new System.Drawing.Point(20, 542);
            this.lblFactoryID.Name = "lblFactoryID";
            this.lblFactoryID.Size = new System.Drawing.Size(225, 49);
            this.lblFactoryID.TabIndex = 13;
            this.lblFactoryID.Text = "Factory_ID:";
            this.lblFactoryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct_ID
            // 
            this.lblProduct_ID.BackColor = System.Drawing.Color.Brown;
            this.lblProduct_ID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct_ID.Location = new System.Drawing.Point(20, 615);
            this.lblProduct_ID.Name = "lblProduct_ID";
            this.lblProduct_ID.Size = new System.Drawing.Size(225, 49);
            this.lblProduct_ID.TabIndex = 14;
            this.lblProduct_ID.Text = "Product_ID:";
            this.lblProduct_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxFactoryID
            // 
            this.cmbBoxFactoryID.FormattingEnabled = true;
            this.cmbBoxFactoryID.Location = new System.Drawing.Point(251, 555);
            this.cmbBoxFactoryID.Name = "cmbBoxFactoryID";
            this.cmbBoxFactoryID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxFactoryID.TabIndex = 1;
            this.ttpWarehouse.SetToolTip(this.cmbBoxFactoryID, "Factory ID, not name!");
            // 
            // cmbBoxProductID
            // 
            this.cmbBoxProductID.FormattingEnabled = true;
            this.cmbBoxProductID.Location = new System.Drawing.Point(251, 628);
            this.cmbBoxProductID.Name = "cmbBoxProductID";
            this.cmbBoxProductID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxProductID.TabIndex = 2;
            this.ttpWarehouse.SetToolTip(this.cmbBoxProductID, "Product ID, not the name\'");
            // 
            // lblTransactionQuantity
            // 
            this.lblTransactionQuantity.BackColor = System.Drawing.Color.Brown;
            this.lblTransactionQuantity.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransactionQuantity.Location = new System.Drawing.Point(484, 469);
            this.lblTransactionQuantity.Name = "lblTransactionQuantity";
            this.lblTransactionQuantity.Size = new System.Drawing.Size(221, 49);
            this.lblTransactionQuantity.TabIndex = 17;
            this.lblTransactionQuantity.Text = "Quantity:";
            this.lblTransactionQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Brown;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(484, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 49);
            this.label5.TabIndex = 18;
            this.label5.Text = "Transaction Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.BackColor = System.Drawing.Color.Brown;
            this.lblTransactionID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransactionID.Location = new System.Drawing.Point(484, 615);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(225, 49);
            this.lblTransactionID.TabIndex = 20;
            this.lblTransactionID.Text = "Transaction_ID";
            this.lblTransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTransactionQuantity
            // 
            this.txtTransactionQuantity.Location = new System.Drawing.Point(711, 482);
            this.txtTransactionQuantity.Name = "txtTransactionQuantity";
            this.txtTransactionQuantity.Size = new System.Drawing.Size(148, 22);
            this.txtTransactionQuantity.TabIndex = 3;
            this.ttpWarehouse.SetToolTip(this.txtTransactionQuantity, "Quantity to transfer");
            // 
            // mtxtTransactionDate
            // 
            this.mtxtTransactionDate.Location = new System.Drawing.Point(715, 555);
            this.mtxtTransactionDate.Mask = "00/00/0000";
            this.mtxtTransactionDate.Name = "mtxtTransactionDate";
            this.mtxtTransactionDate.Size = new System.Drawing.Size(148, 22);
            this.mtxtTransactionDate.TabIndex = 4;
            this.ttpWarehouse.SetToolTip(this.mtxtTransactionDate, "Date of trans happened");
            this.mtxtTransactionDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbBoxTransactionID
            // 
            this.cmbBoxTransactionID.FormattingEnabled = true;
            this.cmbBoxTransactionID.Location = new System.Drawing.Point(715, 628);
            this.cmbBoxTransactionID.Name = "cmbBoxTransactionID";
            this.cmbBoxTransactionID.Size = new System.Drawing.Size(137, 24);
            this.cmbBoxTransactionID.TabIndex = 5;
            this.ttpWarehouse.SetToolTip(this.cmbBoxTransactionID, "Transaction ID");
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTransaction.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.Red;
            this.btnAddTransaction.Location = new System.Drawing.Point(1013, 498);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(105, 51);
            this.btnAddTransaction.TabIndex = 6;
            this.btnAddTransaction.Text = "&Add";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnUpdateTransaction
            // 
            this.btnUpdateTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateTransaction.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateTransaction.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateTransaction.Location = new System.Drawing.Point(1013, 578);
            this.btnUpdateTransaction.Name = "btnUpdateTransaction";
            this.btnUpdateTransaction.Size = new System.Drawing.Size(105, 51);
            this.btnUpdateTransaction.TabIndex = 7;
            this.btnUpdateTransaction.Text = "&Update";
            this.btnUpdateTransaction.UseVisualStyleBackColor = false;
            this.btnUpdateTransaction.Click += new System.EventHandler(this.btnUpdateTransaction_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(1230, 498);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 51);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSeeOrdersPage
            // 
            this.btnSeeOrdersPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeeOrdersPage.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeeOrdersPage.ForeColor = System.Drawing.Color.Red;
            this.btnSeeOrdersPage.Location = new System.Drawing.Point(1230, 578);
            this.btnSeeOrdersPage.Name = "btnSeeOrdersPage";
            this.btnSeeOrdersPage.Size = new System.Drawing.Size(112, 51);
            this.btnSeeOrdersPage.TabIndex = 21;
            this.btnSeeOrdersPage.Text = "&Orders";
            this.btnSeeOrdersPage.UseVisualStyleBackColor = false;
            this.btnSeeOrdersPage.Click += new System.EventHandler(this.btnSeeOrdersPage_Click);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 738);
            this.Controls.Add(this.btnSeeOrdersPage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.cmbBoxTransactionID);
            this.Controls.Add(this.mtxtTransactionDate);
            this.Controls.Add(this.txtTransactionQuantity);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTransactionQuantity);
            this.Controls.Add(this.cmbBoxProductID);
            this.Controls.Add(this.cmbBoxFactoryID);
            this.Controls.Add(this.lblProduct_ID);
            this.Controls.Add(this.lblFactoryID);
            this.Controls.Add(this.cmbBoxWarehouseID);
            this.Controls.Add(this.lblWarehouse_ID);
            this.Controls.Add(this.grpBoxTransaction2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackWarehouse);
            this.Controls.Add(this.picWarehousePage);
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.ttpWarehouse.SetToolTip(this, "Warehouse Stock Management");
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWarehousePage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouseStock)).EndInit();
            this.grpBoxTransaction2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWarehousePage;
        private System.Windows.Forms.Button btnBackWarehouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridWarehouseStock;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxTransaction2;
        private System.Windows.Forms.DataGridView dataGridTransactionAdd;
        private System.Windows.Forms.Label lblWarehouse_ID;
        private System.Windows.Forms.ComboBox cmbBoxWarehouseID;
        private System.Windows.Forms.Label lblFactoryID;
        private System.Windows.Forms.Label lblProduct_ID;
        private System.Windows.Forms.ComboBox cmbBoxFactoryID;
        private System.Windows.Forms.ComboBox cmbBoxProductID;
        private System.Windows.Forms.Label lblTransactionQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.TextBox txtTransactionQuantity;
        private System.Windows.Forms.MaskedTextBox mtxtTransactionDate;
        private System.Windows.Forms.ComboBox cmbBoxTransactionID;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnUpdateTransaction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip ttpWarehouse;
        private System.Windows.Forms.Button btnSeeOrdersPage;
    }
}

namespace MidtermProject
{
    partial class ExpeditionInformation
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
            this.dataGridShipping = new System.Windows.Forms.DataGridView();
            this.grpBoxShipping = new System.Windows.Forms.GroupBox();
            this.btnEXITfromShipping = new System.Windows.Forms.Button();
            this.btnCheckOrders = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.cmbBoxOrder_ID = new System.Windows.Forms.ComboBox();
            this.cmbBoxTransaction_ID = new System.Windows.Forms.ComboBox();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.mtextDepartureDate = new System.Windows.Forms.MaskedTextBox();
            this.mtextArrivalDate = new System.Windows.Forms.MaskedTextBox();
            this.btnAddShipping = new System.Windows.Forms.Button();
            this.lblColumn = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbBoxColumn = new System.Windows.Forms.ComboBox();
            this.btnSearchColumn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblShippingID = new System.Windows.Forms.Label();
            this.cmbBoxShippingID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShipping)).BeginInit();
            this.grpBoxShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridShipping
            // 
            this.dataGridShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShipping.Location = new System.Drawing.Point(6, 29);
            this.dataGridShipping.Name = "dataGridShipping";
            this.dataGridShipping.RowHeadersWidth = 51;
            this.dataGridShipping.RowTemplate.Height = 24;
            this.dataGridShipping.Size = new System.Drawing.Size(1044, 288);
            this.dataGridShipping.TabIndex = 0;
            // 
            // grpBoxShipping
            // 
            this.grpBoxShipping.Controls.Add(this.dataGridShipping);
            this.grpBoxShipping.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxShipping.Location = new System.Drawing.Point(12, 101);
            this.grpBoxShipping.Name = "grpBoxShipping";
            this.grpBoxShipping.Size = new System.Drawing.Size(1056, 323);
            this.grpBoxShipping.TabIndex = 1;
            this.grpBoxShipping.TabStop = false;
            this.grpBoxShipping.Text = "Shipping Information";
            this.grpBoxShipping.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEXITfromShipping
            // 
            this.btnEXITfromShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEXITfromShipping.ForeColor = System.Drawing.Color.Red;
            this.btnEXITfromShipping.Location = new System.Drawing.Point(955, 579);
            this.btnEXITfromShipping.Name = "btnEXITfromShipping";
            this.btnEXITfromShipping.Size = new System.Drawing.Size(107, 45);
            this.btnEXITfromShipping.TabIndex = 2;
            this.btnEXITfromShipping.Text = "&EXIT";
            this.btnEXITfromShipping.UseVisualStyleBackColor = true;
            this.btnEXITfromShipping.Click += new System.EventHandler(this.btnEXITfromShipping_Click);
            // 
            // btnCheckOrders
            // 
            this.btnCheckOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckOrders.ForeColor = System.Drawing.Color.Red;
            this.btnCheckOrders.Location = new System.Drawing.Point(12, 579);
            this.btnCheckOrders.Name = "btnCheckOrders";
            this.btnCheckOrders.Size = new System.Drawing.Size(123, 41);
            this.btnCheckOrders.TabIndex = 3;
            this.btnCheckOrders.Text = "&ORDERS";
            this.btnCheckOrders.UseVisualStyleBackColor = true;
            this.btnCheckOrders.Click += new System.EventHandler(this.btnCheckOrders_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.BackColor = System.Drawing.Color.Firebrick;
            this.lblOrderID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderID.ForeColor = System.Drawing.Color.Black;
            this.lblOrderID.Location = new System.Drawing.Point(12, 434);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(191, 45);
            this.lblOrderID.TabIndex = 6;
            this.lblOrderID.Text = "Order_ID:";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.BackColor = System.Drawing.Color.Firebrick;
            this.lblTransactionID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransactionID.ForeColor = System.Drawing.Color.Black;
            this.lblTransactionID.Location = new System.Drawing.Point(12, 500);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(191, 45);
            this.lblTransactionID.TabIndex = 7;
            this.lblTransactionID.Text = "Transaction_ID:";
            this.lblTransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxOrder_ID
            // 
            this.cmbBoxOrder_ID.FormattingEnabled = true;
            this.cmbBoxOrder_ID.Items.AddRange(new object[] {
            ""});
            this.cmbBoxOrder_ID.Location = new System.Drawing.Point(211, 445);
            this.cmbBoxOrder_ID.Name = "cmbBoxOrder_ID";
            this.cmbBoxOrder_ID.Size = new System.Drawing.Size(128, 24);
            this.cmbBoxOrder_ID.TabIndex = 8;
            // 
            // cmbBoxTransaction_ID
            // 
            this.cmbBoxTransaction_ID.FormattingEnabled = true;
            this.cmbBoxTransaction_ID.Items.AddRange(new object[] {
            ""});
            this.cmbBoxTransaction_ID.Location = new System.Drawing.Point(211, 511);
            this.cmbBoxTransaction_ID.Name = "cmbBoxTransaction_ID";
            this.cmbBoxTransaction_ID.Size = new System.Drawing.Size(128, 24);
            this.cmbBoxTransaction_ID.TabIndex = 9;
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.BackColor = System.Drawing.Color.Firebrick;
            this.lblArrivalDate.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArrivalDate.ForeColor = System.Drawing.Color.Black;
            this.lblArrivalDate.Location = new System.Drawing.Point(359, 500);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(203, 45);
            this.lblArrivalDate.TabIndex = 10;
            this.lblArrivalDate.Text = "Arrival Date:";
            this.lblArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.BackColor = System.Drawing.Color.Firebrick;
            this.lblDepartureDate.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartureDate.ForeColor = System.Drawing.Color.Black;
            this.lblDepartureDate.Location = new System.Drawing.Point(359, 434);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(203, 45);
            this.lblDepartureDate.TabIndex = 11;
            this.lblDepartureDate.Text = "Departure Date:";
            this.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtextDepartureDate
            // 
            this.mtextDepartureDate.Location = new System.Drawing.Point(568, 445);
            this.mtextDepartureDate.Mask = "00/00/0000";
            this.mtextDepartureDate.Name = "mtextDepartureDate";
            this.mtextDepartureDate.Size = new System.Drawing.Size(168, 22);
            this.mtextDepartureDate.TabIndex = 12;
            this.mtextDepartureDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtextArrivalDate
            // 
            this.mtextArrivalDate.Location = new System.Drawing.Point(568, 511);
            this.mtextArrivalDate.Mask = "00/00/0000";
            this.mtextArrivalDate.Name = "mtextArrivalDate";
            this.mtextArrivalDate.Size = new System.Drawing.Size(168, 22);
            this.mtextArrivalDate.TabIndex = 13;
            this.mtextArrivalDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddShipping
            // 
            this.btnAddShipping.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddShipping.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddShipping.ForeColor = System.Drawing.Color.Red;
            this.btnAddShipping.Location = new System.Drawing.Point(949, 430);
            this.btnAddShipping.Name = "btnAddShipping";
            this.btnAddShipping.Size = new System.Drawing.Size(108, 49);
            this.btnAddShipping.TabIndex = 14;
            this.btnAddShipping.Text = "&Add";
            this.btnAddShipping.UseVisualStyleBackColor = false;
            this.btnAddShipping.Click += new System.EventHandler(this.btnAddShipping_Click);
            // 
            // lblColumn
            // 
            this.lblColumn.BackColor = System.Drawing.Color.Firebrick;
            this.lblColumn.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColumn.ForeColor = System.Drawing.Color.Black;
            this.lblColumn.Location = new System.Drawing.Point(14, 27);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(191, 45);
            this.lblColumn.TabIndex = 15;
            this.lblColumn.Text = "Column:";
            this.lblColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(646, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 22);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Firebrick;
            this.lblSearch.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(449, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(191, 45);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxColumn
            // 
            this.cmbBoxColumn.FormattingEnabled = true;
            this.cmbBoxColumn.Location = new System.Drawing.Point(211, 36);
            this.cmbBoxColumn.Name = "cmbBoxColumn";
            this.cmbBoxColumn.Size = new System.Drawing.Size(220, 24);
            this.cmbBoxColumn.TabIndex = 18;
            this.cmbBoxColumn.SelectedIndexChanged += new System.EventHandler(this.cmbBoxColumn_SelectedIndexChanged);
            // 
            // btnSearchColumn
            // 
            this.btnSearchColumn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchColumn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchColumn.ForeColor = System.Drawing.Color.Red;
            this.btnSearchColumn.Location = new System.Drawing.Point(936, 27);
            this.btnSearchColumn.Name = "btnSearchColumn";
            this.btnSearchColumn.Size = new System.Drawing.Size(126, 49);
            this.btnSearchColumn.TabIndex = 19;
            this.btnSearchColumn.Text = "&Search";
            this.btnSearchColumn.UseVisualStyleBackColor = false;
            this.btnSearchColumn.Click += new System.EventHandler(this.btnSearchColumn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(949, 495);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 49);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblShippingID
            // 
            this.lblShippingID.BackColor = System.Drawing.Color.Firebrick;
            this.lblShippingID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShippingID.ForeColor = System.Drawing.Color.Black;
            this.lblShippingID.Location = new System.Drawing.Point(359, 565);
            this.lblShippingID.Name = "lblShippingID";
            this.lblShippingID.Size = new System.Drawing.Size(203, 45);
            this.lblShippingID.TabIndex = 21;
            this.lblShippingID.Text = "Shipping_ID:";
            this.lblShippingID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxShippingID
            // 
            this.cmbBoxShippingID.FormattingEnabled = true;
            this.cmbBoxShippingID.Items.AddRange(new object[] {
            ""});
            this.cmbBoxShippingID.Location = new System.Drawing.Point(568, 576);
            this.cmbBoxShippingID.Name = "cmbBoxShippingID";
            this.cmbBoxShippingID.Size = new System.Drawing.Size(168, 24);
            this.cmbBoxShippingID.TabIndex = 22;
            // 
            // ExpeditionInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 632);
            this.Controls.Add(this.cmbBoxShippingID);
            this.Controls.Add(this.lblShippingID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearchColumn);
            this.Controls.Add(this.cmbBoxColumn);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.btnAddShipping);
            this.Controls.Add(this.mtextArrivalDate);
            this.Controls.Add(this.mtextDepartureDate);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.cmbBoxTransaction_ID);
            this.Controls.Add(this.cmbBoxOrder_ID);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnCheckOrders);
            this.Controls.Add(this.btnEXITfromShipping);
            this.Controls.Add(this.grpBoxShipping);
            this.Name = "ExpeditionInformation";
            this.Text = "ExpeditionInformation";
            this.Load += new System.EventHandler(this.ExpeditionInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShipping)).EndInit();
            this.grpBoxShipping.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShipping;
        private System.Windows.Forms.GroupBox grpBoxShipping;
        private System.Windows.Forms.Button btnEXITfromShipping;
        private System.Windows.Forms.Button btnCheckOrders;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.ComboBox cmbBoxOrder_ID;
        private System.Windows.Forms.ComboBox cmbBoxTransaction_ID;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.MaskedTextBox mtextDepartureDate;
        private System.Windows.Forms.MaskedTextBox mtextArrivalDate;
        private System.Windows.Forms.Button btnAddShipping;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbBoxColumn;
        private System.Windows.Forms.Button btnSearchColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblShippingID;
        private System.Windows.Forms.ComboBox cmbBoxShippingID;
    }
}
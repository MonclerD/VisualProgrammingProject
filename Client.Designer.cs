
namespace MidtermProject
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.btnBackClient = new System.Windows.Forms.Button();
            this.grpBoxProducts = new System.Windows.Forms.GroupBox();
            this.dataGridStocks = new System.Windows.Forms.DataGridView();
            this.picClientPage = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTransactionIDClient = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbBoxTransactiontIDClient = new System.Windows.Forms.ComboBox();
            this.txtQuantityClient = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderLocation = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.rtxtOrderLocationClient = new System.Windows.Forms.RichTextBox();
            this.cmbBoxClientID = new System.Windows.Forms.ComboBox();
            this.btnOrderClient = new System.Windows.Forms.Button();
            this.mtextOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.ttpClient = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientPage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackClient
            // 
            this.btnBackClient.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackClient.ForeColor = System.Drawing.Color.Red;
            this.btnBackClient.Location = new System.Drawing.Point(12, 658);
            this.btnBackClient.Name = "btnBackClient";
            this.btnBackClient.Size = new System.Drawing.Size(109, 47);
            this.btnBackClient.TabIndex = 7;
            this.btnBackClient.Text = "Back";
            this.btnBackClient.UseVisualStyleBackColor = true;
            this.btnBackClient.Click += new System.EventHandler(this.btnBackClient_Click_1);
            // 
            // grpBoxProducts
            // 
            this.grpBoxProducts.Controls.Add(this.dataGridStocks);
            this.grpBoxProducts.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxProducts.Location = new System.Drawing.Point(327, 12);
            this.grpBoxProducts.Name = "grpBoxProducts";
            this.grpBoxProducts.Size = new System.Drawing.Size(1190, 250);
            this.grpBoxProducts.TabIndex = 10;
            this.grpBoxProducts.TabStop = false;
            this.grpBoxProducts.Text = "Products";
            // 
            // dataGridStocks
            // 
            this.dataGridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStocks.Location = new System.Drawing.Point(6, 21);
            this.dataGridStocks.Name = "dataGridStocks";
            this.dataGridStocks.RowHeadersWidth = 51;
            this.dataGridStocks.RowTemplate.Height = 24;
            this.dataGridStocks.Size = new System.Drawing.Size(1163, 223);
            this.dataGridStocks.TabIndex = 0;
            // 
            // picClientPage
            // 
            this.picClientPage.Image = ((System.Drawing.Image)(resources.GetObject("picClientPage.Image")));
            this.picClientPage.Location = new System.Drawing.Point(12, 33);
            this.picClientPage.Name = "picClientPage";
            this.picClientPage.Size = new System.Drawing.Size(309, 194);
            this.picClientPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClientPage.TabIndex = 3;
            this.picClientPage.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1409, 656);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTransactionIDClient
            // 
            this.lblTransactionIDClient.BackColor = System.Drawing.Color.Firebrick;
            this.lblTransactionIDClient.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransactionIDClient.Location = new System.Drawing.Point(45, 339);
            this.lblTransactionIDClient.Name = "lblTransactionIDClient";
            this.lblTransactionIDClient.Size = new System.Drawing.Size(178, 46);
            this.lblTransactionIDClient.TabIndex = 6;
            this.lblTransactionIDClient.Text = "Transaction_ID:";
            this.lblTransactionIDClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Firebrick;
            this.lblQuantity.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(650, 329);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(178, 46);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxTransactiontIDClient
            // 
            this.cmbBoxTransactiontIDClient.FormattingEnabled = true;
            this.cmbBoxTransactiontIDClient.Location = new System.Drawing.Point(243, 351);
            this.cmbBoxTransactiontIDClient.Name = "cmbBoxTransactiontIDClient";
            this.cmbBoxTransactiontIDClient.Size = new System.Drawing.Size(168, 24);
            this.cmbBoxTransactiontIDClient.TabIndex = 1;
            this.ttpClient.SetToolTip(this.cmbBoxTransactiontIDClient, "Stock ID in the Warehouse");
            this.cmbBoxTransactiontIDClient.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProductTypeClient_SelectedIndexChanged);
            // 
            // txtQuantityClient
            // 
            this.txtQuantityClient.Location = new System.Drawing.Point(834, 341);
            this.txtQuantityClient.Name = "txtQuantityClient";
            this.txtQuantityClient.Size = new System.Drawing.Size(181, 22);
            this.txtQuantityClient.TabIndex = 4;
            this.ttpClient.SetToolTip(this.txtQuantityClient, "Ordered Quantity");
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.BackColor = System.Drawing.Color.Firebrick;
            this.lblOrderDate.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderDate.Location = new System.Drawing.Point(45, 536);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(178, 46);
            this.lblOrderDate.TabIndex = 12;
            this.lblOrderDate.Text = "Order Date:";
            this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderLocation
            // 
            this.lblOrderLocation.BackColor = System.Drawing.Color.Firebrick;
            this.lblOrderLocation.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderLocation.Location = new System.Drawing.Point(650, 439);
            this.lblOrderLocation.Name = "lblOrderLocation";
            this.lblOrderLocation.Size = new System.Drawing.Size(178, 46);
            this.lblOrderLocation.TabIndex = 13;
            this.lblOrderLocation.Text = "Order Location:";
            this.lblOrderLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientID
            // 
            this.lblClientID.BackColor = System.Drawing.Color.Firebrick;
            this.lblClientID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClientID.Location = new System.Drawing.Point(45, 439);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(178, 46);
            this.lblClientID.TabIndex = 14;
            this.lblClientID.Text = "Client_ID:";
            this.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtOrderLocationClient
            // 
            this.rtxtOrderLocationClient.Location = new System.Drawing.Point(834, 439);
            this.rtxtOrderLocationClient.Name = "rtxtOrderLocationClient";
            this.rtxtOrderLocationClient.Size = new System.Drawing.Size(364, 144);
            this.rtxtOrderLocationClient.TabIndex = 5;
            this.rtxtOrderLocationClient.Text = "";
            this.ttpClient.SetToolTip(this.rtxtOrderLocationClient, "Location where to send the products");
            // 
            // cmbBoxClientID
            // 
            this.cmbBoxClientID.FormattingEnabled = true;
            this.cmbBoxClientID.Location = new System.Drawing.Point(243, 451);
            this.cmbBoxClientID.Name = "cmbBoxClientID";
            this.cmbBoxClientID.Size = new System.Drawing.Size(168, 24);
            this.cmbBoxClientID.TabIndex = 2;
            this.ttpClient.SetToolTip(this.cmbBoxClientID, "Client ID provided by Wilson Sporting Goods");
            // 
            // btnOrderClient
            // 
            this.btnOrderClient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrderClient.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderClient.ForeColor = System.Drawing.Color.Red;
            this.btnOrderClient.Location = new System.Drawing.Point(1345, 325);
            this.btnOrderClient.Name = "btnOrderClient";
            this.btnOrderClient.Size = new System.Drawing.Size(108, 49);
            this.btnOrderClient.TabIndex = 6;
            this.btnOrderClient.Text = "&Order";
            this.btnOrderClient.UseVisualStyleBackColor = false;
            this.btnOrderClient.Click += new System.EventHandler(this.btnOrderClient_Click);
            // 
            // mtextOrderDate
            // 
            this.mtextOrderDate.Location = new System.Drawing.Point(243, 548);
            this.mtextOrderDate.Mask = "00/00/0000";
            this.mtextOrderDate.Name = "mtextOrderDate";
            this.mtextOrderDate.Size = new System.Drawing.Size(168, 22);
            this.mtextOrderDate.TabIndex = 3;
            this.ttpClient.SetToolTip(this.mtextOrderDate, "Date that Client order products");
            this.mtextOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 717);
            this.Controls.Add(this.mtextOrderDate);
            this.Controls.Add(this.btnOrderClient);
            this.Controls.Add(this.cmbBoxClientID);
            this.Controls.Add(this.rtxtOrderLocationClient);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblOrderLocation);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtQuantityClient);
            this.Controls.Add(this.cmbBoxTransactiontIDClient);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTransactionIDClient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picClientPage);
            this.Controls.Add(this.grpBoxProducts);
            this.Controls.Add(this.btnBackClient);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ttpClient.SetToolTip(this, "Client Order Page");
            this.Load += new System.EventHandler(this.Client_Load);
            this.grpBoxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBackClient;
        private System.Windows.Forms.GroupBox grpBoxProducts;
        private System.Windows.Forms.DataGridView dataGridStocks;
        private System.Windows.Forms.PictureBox picClientPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTransactionIDClient;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbBoxTransactiontIDClient;
        private System.Windows.Forms.TextBox txtQuantityClient;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderLocation;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.RichTextBox rtxtOrderLocationClient;
        private System.Windows.Forms.ComboBox cmbBoxClientID;
        private System.Windows.Forms.Button btnOrderClient;
        private System.Windows.Forms.MaskedTextBox mtextOrderDate;
        private System.Windows.Forms.ToolTip ttpClient;
    }
}
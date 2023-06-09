
namespace MidtermProject
{
    partial class ClientReport
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
            this.dataGridClientReport = new System.Windows.Forms.DataGridView();
            this.grpBoxOrderInformation = new System.Windows.Forms.GroupBox();
            this.lblOrderIDClient = new System.Windows.Forms.Label();
            this.cmbBoxOrder_ID_Client = new System.Windows.Forms.ComboBox();
            this.btnConfirmShipping = new System.Windows.Forms.Button();
            this.lblArrivalDate_Client = new System.Windows.Forms.Label();
            this.mtextArrivalDateClient = new System.Windows.Forms.MaskedTextBox();
            this.btnEXITfromReport = new System.Windows.Forms.Button();
            this.lblShippingID = new System.Windows.Forms.Label();
            this.cmbBoxShipping_ID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientReport)).BeginInit();
            this.grpBoxOrderInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridClientReport
            // 
            this.dataGridClientReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientReport.Location = new System.Drawing.Point(6, 29);
            this.dataGridClientReport.Name = "dataGridClientReport";
            this.dataGridClientReport.RowHeadersWidth = 51;
            this.dataGridClientReport.RowTemplate.Height = 24;
            this.dataGridClientReport.Size = new System.Drawing.Size(1099, 254);
            this.dataGridClientReport.TabIndex = 0;
            // 
            // grpBoxOrderInformation
            // 
            this.grpBoxOrderInformation.Controls.Add(this.dataGridClientReport);
            this.grpBoxOrderInformation.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxOrderInformation.Location = new System.Drawing.Point(12, 41);
            this.grpBoxOrderInformation.Name = "grpBoxOrderInformation";
            this.grpBoxOrderInformation.Size = new System.Drawing.Size(1112, 289);
            this.grpBoxOrderInformation.TabIndex = 1;
            this.grpBoxOrderInformation.TabStop = false;
            this.grpBoxOrderInformation.Text = "Order Information";
            // 
            // lblOrderIDClient
            // 
            this.lblOrderIDClient.BackColor = System.Drawing.Color.Firebrick;
            this.lblOrderIDClient.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderIDClient.ForeColor = System.Drawing.Color.Black;
            this.lblOrderIDClient.Location = new System.Drawing.Point(23, 363);
            this.lblOrderIDClient.Name = "lblOrderIDClient";
            this.lblOrderIDClient.Size = new System.Drawing.Size(191, 45);
            this.lblOrderIDClient.TabIndex = 7;
            this.lblOrderIDClient.Text = "Order_ID:";
            this.lblOrderIDClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxOrder_ID_Client
            // 
            this.cmbBoxOrder_ID_Client.FormattingEnabled = true;
            this.cmbBoxOrder_ID_Client.Items.AddRange(new object[] {
            ""});
            this.cmbBoxOrder_ID_Client.Location = new System.Drawing.Point(220, 374);
            this.cmbBoxOrder_ID_Client.Name = "cmbBoxOrder_ID_Client";
            this.cmbBoxOrder_ID_Client.Size = new System.Drawing.Size(128, 24);
            this.cmbBoxOrder_ID_Client.TabIndex = 9;
            // 
            // btnConfirmShipping
            // 
            this.btnConfirmShipping.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmShipping.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmShipping.ForeColor = System.Drawing.Color.Red;
            this.btnConfirmShipping.Location = new System.Drawing.Point(951, 363);
            this.btnConfirmShipping.Name = "btnConfirmShipping";
            this.btnConfirmShipping.Size = new System.Drawing.Size(122, 49);
            this.btnConfirmShipping.TabIndex = 15;
            this.btnConfirmShipping.Text = "&Confirm";
            this.btnConfirmShipping.UseVisualStyleBackColor = false;
            this.btnConfirmShipping.Click += new System.EventHandler(this.btnConfirmShipping_Click);
            // 
            // lblArrivalDate_Client
            // 
            this.lblArrivalDate_Client.BackColor = System.Drawing.Color.Firebrick;
            this.lblArrivalDate_Client.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArrivalDate_Client.ForeColor = System.Drawing.Color.Black;
            this.lblArrivalDate_Client.Location = new System.Drawing.Point(383, 363);
            this.lblArrivalDate_Client.Name = "lblArrivalDate_Client";
            this.lblArrivalDate_Client.Size = new System.Drawing.Size(203, 45);
            this.lblArrivalDate_Client.TabIndex = 16;
            this.lblArrivalDate_Client.Text = "Arrival Date:";
            this.lblArrivalDate_Client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtextArrivalDateClient
            // 
            this.mtextArrivalDateClient.Location = new System.Drawing.Point(592, 376);
            this.mtextArrivalDateClient.Mask = "00/00/0000";
            this.mtextArrivalDateClient.Name = "mtextArrivalDateClient";
            this.mtextArrivalDateClient.Size = new System.Drawing.Size(168, 22);
            this.mtextArrivalDateClient.TabIndex = 17;
            this.mtextArrivalDateClient.ValidatingType = typeof(System.DateTime);
            // 
            // btnEXITfromReport
            // 
            this.btnEXITfromReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEXITfromReport.ForeColor = System.Drawing.Color.Red;
            this.btnEXITfromReport.Location = new System.Drawing.Point(1010, 542);
            this.btnEXITfromReport.Name = "btnEXITfromReport";
            this.btnEXITfromReport.Size = new System.Drawing.Size(107, 45);
            this.btnEXITfromReport.TabIndex = 18;
            this.btnEXITfromReport.Text = "&EXIT";
            this.btnEXITfromReport.UseVisualStyleBackColor = true;
            this.btnEXITfromReport.Click += new System.EventHandler(this.btnEXITfromReport_Click);
            // 
            // lblShippingID
            // 
            this.lblShippingID.BackColor = System.Drawing.Color.Firebrick;
            this.lblShippingID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShippingID.ForeColor = System.Drawing.Color.Black;
            this.lblShippingID.Location = new System.Drawing.Point(23, 456);
            this.lblShippingID.Name = "lblShippingID";
            this.lblShippingID.Size = new System.Drawing.Size(191, 45);
            this.lblShippingID.TabIndex = 19;
            this.lblShippingID.Text = "Shipping_ID:";
            this.lblShippingID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxShipping_ID
            // 
            this.cmbBoxShipping_ID.FormattingEnabled = true;
            this.cmbBoxShipping_ID.Items.AddRange(new object[] {
            ""});
            this.cmbBoxShipping_ID.Location = new System.Drawing.Point(220, 467);
            this.cmbBoxShipping_ID.Name = "cmbBoxShipping_ID";
            this.cmbBoxShipping_ID.Size = new System.Drawing.Size(128, 24);
            this.cmbBoxShipping_ID.TabIndex = 20;
            // 
            // ClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 599);
            this.Controls.Add(this.cmbBoxShipping_ID);
            this.Controls.Add(this.lblShippingID);
            this.Controls.Add(this.btnEXITfromReport);
            this.Controls.Add(this.mtextArrivalDateClient);
            this.Controls.Add(this.lblArrivalDate_Client);
            this.Controls.Add(this.btnConfirmShipping);
            this.Controls.Add(this.cmbBoxOrder_ID_Client);
            this.Controls.Add(this.lblOrderIDClient);
            this.Controls.Add(this.grpBoxOrderInformation);
            this.Name = "ClientReport";
            this.Text = "ClientReport";
            this.Load += new System.EventHandler(this.ClientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientReport)).EndInit();
            this.grpBoxOrderInformation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientReport;
        private System.Windows.Forms.GroupBox grpBoxOrderInformation;
        private System.Windows.Forms.Label lblOrderIDClient;
        private System.Windows.Forms.ComboBox cmbBoxOrder_ID_Client;
        private System.Windows.Forms.Button btnConfirmShipping;
        private System.Windows.Forms.Label lblArrivalDate_Client;
        private System.Windows.Forms.MaskedTextBox mtextArrivalDateClient;
        private System.Windows.Forms.Button btnEXITfromReport;
        private System.Windows.Forms.Label lblShippingID;
        private System.Windows.Forms.ComboBox cmbBoxShipping_ID;
    }
}
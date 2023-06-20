
namespace MidtermProject
{
    partial class ViewStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStocks));
            this.picHeadquarterStockViewPage = new System.Windows.Forms.PictureBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wilsonSportingGoodsDataSet3 = new MidtermProject.WilsonSportingGoodsDataSet3();
            this.stockTableAdapter = new MidtermProject.WilsonSportingGoodsDataSet3TableAdapters.StockTableAdapter();
            this.racketGripProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wilsonSportingGoodsDataSet4 = new MidtermProject.WilsonSportingGoodsDataSet4();
            this.stringProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wilsonSportingGoodsDataSet5 = new MidtermProject.WilsonSportingGoodsDataSet5();
            this.racketProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wilsonSportingGoodsDataSet6 = new MidtermProject.WilsonSportingGoodsDataSet6();
            this.racketGripProductionTableAdapter = new MidtermProject.WilsonSportingGoodsDataSet4TableAdapters.RacketGripProductionTableAdapter();
            this.stringProductionTableAdapter = new MidtermProject.WilsonSportingGoodsDataSet5TableAdapters.StringProductionTableAdapter();
            this.racketProductionTableAdapter = new MidtermProject.WilsonSportingGoodsDataSet6TableAdapters.RacketProductionTableAdapter();
            this.btnExitFromHeadquarterStockView = new System.Windows.Forms.Button();
            this.btnBackToHeadquarterPage = new System.Windows.Forms.Button();
            this.dataGridHeadquarterStock = new System.Windows.Forms.DataGridView();
            this.grpBoxTransaction = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.grpBoxOrders23 = new System.Windows.Forms.GroupBox();
            this.dataGridOrderHeadquarter = new System.Windows.Forms.DataGridView();
            this.btnShipping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadquarterStockViewPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketGripProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHeadquarterStock)).BeginInit();
            this.grpBoxTransaction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.grpBoxOrders23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderHeadquarter)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeadquarterStockViewPage
            // 
            this.picHeadquarterStockViewPage.Image = ((System.Drawing.Image)(resources.GetObject("picHeadquarterStockViewPage.Image")));
            this.picHeadquarterStockViewPage.Location = new System.Drawing.Point(12, 33);
            this.picHeadquarterStockViewPage.Name = "picHeadquarterStockViewPage";
            this.picHeadquarterStockViewPage.Size = new System.Drawing.Size(231, 198);
            this.picHeadquarterStockViewPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeadquarterStockViewPage.TabIndex = 0;
            this.picHeadquarterStockViewPage.TabStop = false;
            this.picHeadquarterStockViewPage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wilsonSportingGoodsDataSet3;
            // 
            // wilsonSportingGoodsDataSet3
            // 
            this.wilsonSportingGoodsDataSet3.DataSetName = "WilsonSportingGoodsDataSet3";
            this.wilsonSportingGoodsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // racketGripProductionBindingSource
            // 
            this.racketGripProductionBindingSource.DataMember = "RacketGripProduction";
            this.racketGripProductionBindingSource.DataSource = this.wilsonSportingGoodsDataSet4;
            // 
            // wilsonSportingGoodsDataSet4
            // 
            this.wilsonSportingGoodsDataSet4.DataSetName = "WilsonSportingGoodsDataSet4";
            this.wilsonSportingGoodsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stringProductionBindingSource
            // 
            this.stringProductionBindingSource.DataMember = "StringProduction";
            this.stringProductionBindingSource.DataSource = this.wilsonSportingGoodsDataSet5;
            // 
            // wilsonSportingGoodsDataSet5
            // 
            this.wilsonSportingGoodsDataSet5.DataSetName = "WilsonSportingGoodsDataSet5";
            this.wilsonSportingGoodsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racketProductionBindingSource
            // 
            this.racketProductionBindingSource.DataMember = "RacketProduction";
            this.racketProductionBindingSource.DataSource = this.wilsonSportingGoodsDataSet6;
            // 
            // wilsonSportingGoodsDataSet6
            // 
            this.wilsonSportingGoodsDataSet6.DataSetName = "WilsonSportingGoodsDataSet6";
            this.wilsonSportingGoodsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racketGripProductionTableAdapter
            // 
            this.racketGripProductionTableAdapter.ClearBeforeFill = true;
            // 
            // stringProductionTableAdapter
            // 
            this.stringProductionTableAdapter.ClearBeforeFill = true;
            // 
            // racketProductionTableAdapter
            // 
            this.racketProductionTableAdapter.ClearBeforeFill = true;
            // 
            // btnExitFromHeadquarterStockView
            // 
            this.btnExitFromHeadquarterStockView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExitFromHeadquarterStockView.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExitFromHeadquarterStockView.ForeColor = System.Drawing.Color.Red;
            this.btnExitFromHeadquarterStockView.Location = new System.Drawing.Point(1225, 592);
            this.btnExitFromHeadquarterStockView.Name = "btnExitFromHeadquarterStockView";
            this.btnExitFromHeadquarterStockView.Size = new System.Drawing.Size(115, 52);
            this.btnExitFromHeadquarterStockView.TabIndex = 4;
            this.btnExitFromHeadquarterStockView.Text = "&Exit";
            this.btnExitFromHeadquarterStockView.UseVisualStyleBackColor = false;
            this.btnExitFromHeadquarterStockView.Click += new System.EventHandler(this.btnExitFromHeadquarterStockView_Click);
            // 
            // btnBackToHeadquarterPage
            // 
            this.btnBackToHeadquarterPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBackToHeadquarterPage.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToHeadquarterPage.ForeColor = System.Drawing.Color.Red;
            this.btnBackToHeadquarterPage.Location = new System.Drawing.Point(12, 592);
            this.btnBackToHeadquarterPage.Name = "btnBackToHeadquarterPage";
            this.btnBackToHeadquarterPage.Size = new System.Drawing.Size(115, 52);
            this.btnBackToHeadquarterPage.TabIndex = 3;
            this.btnBackToHeadquarterPage.Text = "&Back";
            this.btnBackToHeadquarterPage.UseVisualStyleBackColor = false;
            this.btnBackToHeadquarterPage.Click += new System.EventHandler(this.btnBackToHeadquarterPage_Click);
            // 
            // dataGridHeadquarterStock
            // 
            this.dataGridHeadquarterStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHeadquarterStock.Location = new System.Drawing.Point(6, 18);
            this.dataGridHeadquarterStock.Name = "dataGridHeadquarterStock";
            this.dataGridHeadquarterStock.RowHeadersWidth = 51;
            this.dataGridHeadquarterStock.RowTemplate.Height = 24;
            this.dataGridHeadquarterStock.Size = new System.Drawing.Size(1079, 201);
            this.dataGridHeadquarterStock.TabIndex = 0;
            // 
            // grpBoxTransaction
            // 
            this.grpBoxTransaction.Controls.Add(this.dataGridHeadquarterStock);
            this.grpBoxTransaction.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxTransaction.Location = new System.Drawing.Point(249, 12);
            this.grpBoxTransaction.Name = "grpBoxTransaction";
            this.grpBoxTransaction.Size = new System.Drawing.Size(1091, 230);
            this.grpBoxTransaction.TabIndex = 0;
            this.grpBoxTransaction.TabStop = false;
            this.grpBoxTransaction.Text = "Transaction";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridProduct);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Stock";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Location = new System.Drawing.Point(6, 18);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.RowTemplate.Height = 24;
            this.dataGridProduct.Size = new System.Drawing.Size(635, 275);
            this.dataGridProduct.TabIndex = 0;
            // 
            // grpBoxOrders23
            // 
            this.grpBoxOrders23.Controls.Add(this.dataGridOrderHeadquarter);
            this.grpBoxOrders23.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxOrders23.Location = new System.Drawing.Point(665, 248);
            this.grpBoxOrders23.Name = "grpBoxOrders23";
            this.grpBoxOrders23.Size = new System.Drawing.Size(675, 299);
            this.grpBoxOrders23.TabIndex = 2;
            this.grpBoxOrders23.TabStop = false;
            this.grpBoxOrders23.Text = "Orders";
            this.grpBoxOrders23.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridOrderHeadquarter
            // 
            this.dataGridOrderHeadquarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderHeadquarter.Location = new System.Drawing.Point(0, 18);
            this.dataGridOrderHeadquarter.Name = "dataGridOrderHeadquarter";
            this.dataGridOrderHeadquarter.RowHeadersWidth = 51;
            this.dataGridOrderHeadquarter.RowTemplate.Height = 24;
            this.dataGridOrderHeadquarter.Size = new System.Drawing.Size(669, 275);
            this.dataGridOrderHeadquarter.TabIndex = 0;
            // 
            // btnShipping
            // 
            this.btnShipping.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShipping.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShipping.ForeColor = System.Drawing.Color.Red;
            this.btnShipping.Location = new System.Drawing.Point(1044, 592);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(133, 52);
            this.btnShipping.TabIndex = 5;
            this.btnShipping.Text = "&Shipping";
            this.btnShipping.UseVisualStyleBackColor = false;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // ViewStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1352, 656);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.grpBoxOrders23);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxTransaction);
            this.Controls.Add(this.picHeadquarterStockViewPage);
            this.Controls.Add(this.btnBackToHeadquarterPage);
            this.Controls.Add(this.btnExitFromHeadquarterStockView);
            this.Name = "ViewStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Headquarter Stock View";
            this.Load += new System.EventHandler(this.ViewStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadquarterStockViewPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketGripProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHeadquarterStock)).EndInit();
            this.grpBoxTransaction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.grpBoxOrders23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderHeadquarter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeadquarterStockViewPage;
        private WilsonSportingGoodsDataSet3 wilsonSportingGoodsDataSet3;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private WilsonSportingGoodsDataSet3TableAdapters.StockTableAdapter stockTableAdapter;
        private WilsonSportingGoodsDataSet4 wilsonSportingGoodsDataSet4;
        private System.Windows.Forms.BindingSource racketGripProductionBindingSource;
        private WilsonSportingGoodsDataSet4TableAdapters.RacketGripProductionTableAdapter racketGripProductionTableAdapter;
        private WilsonSportingGoodsDataSet5 wilsonSportingGoodsDataSet5;
        private System.Windows.Forms.BindingSource stringProductionBindingSource;
        private WilsonSportingGoodsDataSet5TableAdapters.StringProductionTableAdapter stringProductionTableAdapter;
        private WilsonSportingGoodsDataSet6 wilsonSportingGoodsDataSet6;
        private System.Windows.Forms.BindingSource racketProductionBindingSource;
        private WilsonSportingGoodsDataSet6TableAdapters.RacketProductionTableAdapter racketProductionTableAdapter;
        private System.Windows.Forms.Button btnExitFromHeadquarterStockView;
        private System.Windows.Forms.Button btnBackToHeadquarterPage;
        private System.Windows.Forms.DataGridView dataGridHeadquarterStock;
        private System.Windows.Forms.GroupBox grpBoxTransaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.GroupBox grpBoxOrders23;
        private System.Windows.Forms.DataGridView dataGridOrderHeadquarter;
        private System.Windows.Forms.Button btnShipping;
    }
}
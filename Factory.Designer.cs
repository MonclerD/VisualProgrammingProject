
namespace MidtermProject
{
    partial class Factory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factory));
            this.picFactoryPage = new System.Windows.Forms.PictureBox();
            this.btnFactoryBack = new System.Windows.Forms.Button();
            this.dataGridFactoryProducts = new System.Windows.Forms.DataGridView();
            this.grpBoxProductsFactory = new System.Windows.Forms.GroupBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnNextFactory2Page = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.cmbBoxProductType = new System.Windows.Forms.ComboBox();
            this.cmbBoxProductName = new System.Windows.Forms.ComboBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbBoxProductID = new System.Windows.Forms.ComboBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.ttpFactoryProducts = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFactoryPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactoryProducts)).BeginInit();
            this.grpBoxProductsFactory.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFactoryPage
            // 
            this.picFactoryPage.Image = ((System.Drawing.Image)(resources.GetObject("picFactoryPage.Image")));
            this.picFactoryPage.Location = new System.Drawing.Point(1217, 59);
            this.picFactoryPage.Name = "picFactoryPage";
            this.picFactoryPage.Size = new System.Drawing.Size(201, 173);
            this.picFactoryPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFactoryPage.TabIndex = 0;
            this.picFactoryPage.TabStop = false;
            // 
            // btnFactoryBack
            // 
            this.btnFactoryBack.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFactoryBack.ForeColor = System.Drawing.Color.Red;
            this.btnFactoryBack.Location = new System.Drawing.Point(12, 630);
            this.btnFactoryBack.Name = "btnFactoryBack";
            this.btnFactoryBack.Size = new System.Drawing.Size(105, 51);
            this.btnFactoryBack.TabIndex = 9;
            this.btnFactoryBack.Text = "&Back";
            this.btnFactoryBack.UseVisualStyleBackColor = true;
            this.btnFactoryBack.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // dataGridFactoryProducts
            // 
            this.dataGridFactoryProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFactoryProducts.Location = new System.Drawing.Point(6, 21);
            this.dataGridFactoryProducts.Name = "dataGridFactoryProducts";
            this.dataGridFactoryProducts.RowHeadersWidth = 51;
            this.dataGridFactoryProducts.RowTemplate.Height = 24;
            this.dataGridFactoryProducts.Size = new System.Drawing.Size(1103, 264);
            this.dataGridFactoryProducts.TabIndex = 3;
            this.dataGridFactoryProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFactoryProducts_CellContentClick);
            // 
            // grpBoxProductsFactory
            // 
            this.grpBoxProductsFactory.Controls.Add(this.dataGridFactoryProducts);
            this.grpBoxProductsFactory.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxProductsFactory.Location = new System.Drawing.Point(12, 12);
            this.grpBoxProductsFactory.Name = "grpBoxProductsFactory";
            this.grpBoxProductsFactory.Size = new System.Drawing.Size(1115, 291);
            this.grpBoxProductsFactory.TabIndex = 11;
            this.grpBoxProductsFactory.TabStop = false;
            this.grpBoxProductsFactory.Text = "Products";
            // 
            // lblProductType
            // 
            this.lblProductType.BackColor = System.Drawing.Color.Firebrick;
            this.lblProductType.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductType.ForeColor = System.Drawing.Color.Black;
            this.lblProductType.Location = new System.Drawing.Point(14, 341);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(165, 45);
            this.lblProductType.TabIndex = 5;
            this.lblProductType.Text = "Product Type:";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Firebrick;
            this.lblProductName.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(14, 483);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(165, 45);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.BackColor = System.Drawing.Color.Firebrick;
            this.lblProductPrice.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductPrice.Location = new System.Drawing.Point(675, 341);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(165, 45);
            this.lblProductPrice.TabIndex = 7;
            this.lblProductPrice.Text = "Product Price:";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Firebrick;
            this.lblQuantity.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(675, 483);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(165, 45);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextFactory2Page
            // 
            this.btnNextFactory2Page.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextFactory2Page.ForeColor = System.Drawing.Color.Red;
            this.btnNextFactory2Page.Location = new System.Drawing.Point(1354, 630);
            this.btnNextFactory2Page.Name = "btnNextFactory2Page";
            this.btnNextFactory2Page.Size = new System.Drawing.Size(105, 51);
            this.btnNextFactory2Page.TabIndex = 10;
            this.btnNextFactory2Page.Text = "&Next";
            this.btnNextFactory2Page.UseVisualStyleBackColor = true;
            this.btnNextFactory2Page.Click += new System.EventHandler(this.btnNextFactory2Page_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Red;
            this.btnAddProduct.Location = new System.Drawing.Point(1184, 335);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 51);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "&Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateProduct.Location = new System.Drawing.Point(1184, 477);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(105, 51);
            this.btnUpdateProduct.TabIndex = 7;
            this.btnUpdateProduct.Text = "&Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // cmbBoxProductType
            // 
            this.cmbBoxProductType.FormattingEnabled = true;
            this.cmbBoxProductType.Items.AddRange(new object[] {
            ""});
            this.cmbBoxProductType.Location = new System.Drawing.Point(194, 352);
            this.cmbBoxProductType.Name = "cmbBoxProductType";
            this.cmbBoxProductType.Size = new System.Drawing.Size(190, 24);
            this.cmbBoxProductType.TabIndex = 1;
            this.ttpFactoryProducts.SetToolTip(this.cmbBoxProductType, "Select a product type that produced by factory");
            this.cmbBoxProductType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProductType_SelectedIndexChanged);
            // 
            // cmbBoxProductName
            // 
            this.cmbBoxProductName.FormattingEnabled = true;
            this.cmbBoxProductName.Location = new System.Drawing.Point(194, 494);
            this.cmbBoxProductName.Name = "cmbBoxProductName";
            this.cmbBoxProductName.Size = new System.Drawing.Size(442, 24);
            this.cmbBoxProductName.TabIndex = 2;
            this.ttpFactoryProducts.SetToolTip(this.cmbBoxProductName, "Select product model");
            this.cmbBoxProductName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProductName_SelectedIndexChanged);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(846, 352);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(196, 24);
            this.txtProductPrice.TabIndex = 3;
            this.ttpFactoryProducts.SetToolTip(this.txtProductPrice, "Enter the product price which provided by Wilson Sporting Goods");
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(846, 494);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(196, 24);
            this.txtQuantity.TabIndex = 4;
            this.ttpFactoryProducts.SetToolTip(this.txtQuantity, "Enter a produced quantity of Product");
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(1354, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 51);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbBoxProductID
            // 
            this.cmbBoxProductID.FormattingEnabled = true;
            this.cmbBoxProductID.Location = new System.Drawing.Point(612, 612);
            this.cmbBoxProductID.Name = "cmbBoxProductID";
            this.cmbBoxProductID.Size = new System.Drawing.Size(134, 24);
            this.cmbBoxProductID.TabIndex = 6;
            this.ttpFactoryProducts.SetToolTip(this.cmbBoxProductID, "Select a Product ID to update ");
            this.cmbBoxProductID.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProductID_SelectedIndexChanged);
            // 
            // lblProductID
            // 
            this.lblProductID.BackColor = System.Drawing.Color.Firebrick;
            this.lblProductID.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductID.ForeColor = System.Drawing.Color.Black;
            this.lblProductID.Location = new System.Drawing.Point(441, 601);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(165, 45);
            this.lblProductID.TabIndex = 18;
            this.lblProductID.Text = "Product_ID:";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Factory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 693);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.cmbBoxProductID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.cmbBoxProductName);
            this.Controls.Add(this.cmbBoxProductType);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnNextFactory2Page);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.grpBoxProductsFactory);
            this.Controls.Add(this.btnFactoryBack);
            this.Controls.Add(this.picFactoryPage);
            this.Name = "Factory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factory";
            this.ttpFactoryProducts.SetToolTip(this, "Production Adding");
            this.Load += new System.EventHandler(this.Factory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFactoryPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactoryProducts)).EndInit();
            this.grpBoxProductsFactory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFactoryPage;
        private System.Windows.Forms.Button btnFactoryBack;
        private System.Windows.Forms.DataGridView dataGridFactoryProducts;
        private System.Windows.Forms.GroupBox grpBoxProductsFactory;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnNextFactory2Page;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.ComboBox cmbBoxProductType;
        private System.Windows.Forms.ComboBox cmbBoxProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbBoxProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ToolTip ttpFactoryProducts;
    }
}
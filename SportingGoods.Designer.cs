
namespace MidtermProject
{
    partial class SportingGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportingGoods));
            this.picRacket = new System.Windows.Forms.PictureBox();
            this.picGrips = new System.Windows.Forms.PictureBox();
            this.picString = new System.Windows.Forms.PictureBox();
            this.grpBoxTennisRackets = new System.Windows.Forms.GroupBox();
            this.dataGridRacket = new System.Windows.Forms.DataGridView();
            this.racketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wilsonSportingGoodsDataSet7 = new MidtermProject.WilsonSportingGoodsDataSet7();
            this.grpBoxStrings = new System.Windows.Forms.GroupBox();
            this.dataGridString = new System.Windows.Forms.DataGridView();
            this.stringsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wilsonSportingGoodsDataSet8 = new MidtermProject.WilsonSportingGoodsDataSet8();
            this.grpBoxRacketStrings = new System.Windows.Forms.GroupBox();
            this.dataGridRacketGrip = new System.Windows.Forms.DataGridView();
            this.racketGripsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wilsonSportingGoodsDataSet9 = new MidtermProject.WilsonSportingGoodsDataSet9();
            this.btnBackToHeadquarterPage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.racketsTableAdapter = new MidtermProject.WilsonSportingGoodsDataSet7TableAdapters.RacketsTableAdapter();
            this.stringsTableAdapter = new MidtermProject.WilsonSportingGoodsDataSet8TableAdapters.StringsTableAdapter();
            this.racketGripsTableAdapter = new MidtermProject.WilsonSportingGoodsDataSet9TableAdapters.RacketGripsTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ttpProduct = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picString)).BeginInit();
            this.grpBoxTennisRackets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet7)).BeginInit();
            this.grpBoxStrings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet8)).BeginInit();
            this.grpBoxRacketStrings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacketGrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketGripsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // picRacket
            // 
            this.picRacket.Image = ((System.Drawing.Image)(resources.GetObject("picRacket.Image")));
            this.picRacket.Location = new System.Drawing.Point(6, 21);
            this.picRacket.Name = "picRacket";
            this.picRacket.Size = new System.Drawing.Size(227, 169);
            this.picRacket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRacket.TabIndex = 0;
            this.picRacket.TabStop = false;
            // 
            // picGrips
            // 
            this.picGrips.Image = ((System.Drawing.Image)(resources.GetObject("picGrips.Image")));
            this.picGrips.Location = new System.Drawing.Point(6, 21);
            this.picGrips.Name = "picGrips";
            this.picGrips.Size = new System.Drawing.Size(227, 166);
            this.picGrips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrips.TabIndex = 1;
            this.picGrips.TabStop = false;
            // 
            // picString
            // 
            this.picString.Image = ((System.Drawing.Image)(resources.GetObject("picString.Image")));
            this.picString.Location = new System.Drawing.Point(6, 31);
            this.picString.Name = "picString";
            this.picString.Size = new System.Drawing.Size(227, 166);
            this.picString.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picString.TabIndex = 2;
            this.picString.TabStop = false;
            // 
            // grpBoxTennisRackets
            // 
            this.grpBoxTennisRackets.Controls.Add(this.dataGridRacket);
            this.grpBoxTennisRackets.Controls.Add(this.picRacket);
            this.grpBoxTennisRackets.Font = new System.Drawing.Font("Courier New", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxTennisRackets.ForeColor = System.Drawing.Color.Red;
            this.grpBoxTennisRackets.Location = new System.Drawing.Point(18, 12);
            this.grpBoxTennisRackets.Name = "grpBoxTennisRackets";
            this.grpBoxTennisRackets.Size = new System.Drawing.Size(1404, 221);
            this.grpBoxTennisRackets.TabIndex = 0;
            this.grpBoxTennisRackets.TabStop = false;
            this.grpBoxTennisRackets.Text = "Tennis Rackets";
            // 
            // dataGridRacket
            // 
            this.dataGridRacket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRacket.Location = new System.Drawing.Point(237, 21);
            this.dataGridRacket.Name = "dataGridRacket";
            this.dataGridRacket.RowHeadersWidth = 51;
            this.dataGridRacket.RowTemplate.Height = 24;
            this.dataGridRacket.Size = new System.Drawing.Size(1158, 187);
            this.dataGridRacket.TabIndex = 0;
            // 
            // racketsBindingSource
            // 
            this.racketsBindingSource.DataMember = "Rackets";
            this.racketsBindingSource.DataSource = this.wilsonSportingGoodsDataSet7;
            // 
            // wilsonSportingGoodsDataSet7
            // 
            this.wilsonSportingGoodsDataSet7.DataSetName = "WilsonSportingGoodsDataSet7";
            this.wilsonSportingGoodsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpBoxStrings
            // 
            this.grpBoxStrings.Controls.Add(this.dataGridString);
            this.grpBoxStrings.Controls.Add(this.picString);
            this.grpBoxStrings.Font = new System.Drawing.Font("Courier New", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxStrings.ForeColor = System.Drawing.Color.Red;
            this.grpBoxStrings.Location = new System.Drawing.Point(18, 239);
            this.grpBoxStrings.Name = "grpBoxStrings";
            this.grpBoxStrings.Size = new System.Drawing.Size(1395, 223);
            this.grpBoxStrings.TabIndex = 1;
            this.grpBoxStrings.TabStop = false;
            this.grpBoxStrings.Text = "Strings";
            // 
            // dataGridString
            // 
            this.dataGridString.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridString.Location = new System.Drawing.Point(255, 31);
            this.dataGridString.Name = "dataGridString";
            this.dataGridString.RowHeadersWidth = 51;
            this.dataGridString.RowTemplate.Height = 24;
            this.dataGridString.Size = new System.Drawing.Size(1134, 186);
            this.dataGridString.TabIndex = 0;
            // 
            // stringsBindingSource
            // 
            this.stringsBindingSource.DataMember = "Strings";
            this.stringsBindingSource.DataSource = this.wilsonSportingGoodsDataSet8;
            // 
            // wilsonSportingGoodsDataSet8
            // 
            this.wilsonSportingGoodsDataSet8.DataSetName = "WilsonSportingGoodsDataSet8";
            this.wilsonSportingGoodsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpBoxRacketStrings
            // 
            this.grpBoxRacketStrings.Controls.Add(this.dataGridRacketGrip);
            this.grpBoxRacketStrings.Controls.Add(this.picGrips);
            this.grpBoxRacketStrings.Font = new System.Drawing.Font("Courier New", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxRacketStrings.ForeColor = System.Drawing.Color.Red;
            this.grpBoxRacketStrings.Location = new System.Drawing.Point(18, 468);
            this.grpBoxRacketStrings.Name = "grpBoxRacketStrings";
            this.grpBoxRacketStrings.Size = new System.Drawing.Size(1395, 193);
            this.grpBoxRacketStrings.TabIndex = 2;
            this.grpBoxRacketStrings.TabStop = false;
            this.grpBoxRacketStrings.Text = "Racket Grips";
            // 
            // dataGridRacketGrip
            // 
            this.dataGridRacketGrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRacketGrip.Location = new System.Drawing.Point(255, 21);
            this.dataGridRacketGrip.Name = "dataGridRacketGrip";
            this.dataGridRacketGrip.RowHeadersWidth = 51;
            this.dataGridRacketGrip.RowTemplate.Height = 24;
            this.dataGridRacketGrip.Size = new System.Drawing.Size(1134, 166);
            this.dataGridRacketGrip.TabIndex = 0;
            // 
            // racketGripsBindingSource
            // 
            this.racketGripsBindingSource.DataMember = "RacketGrips";
            this.racketGripsBindingSource.DataSource = this.wilsonSportingGoodsDataSet9;
            // 
            // wilsonSportingGoodsDataSet9
            // 
            this.wilsonSportingGoodsDataSet9.DataSetName = "WilsonSportingGoodsDataSet9";
            this.wilsonSportingGoodsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBackToHeadquarterPage
            // 
            this.btnBackToHeadquarterPage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToHeadquarterPage.ForeColor = System.Drawing.Color.Red;
            this.btnBackToHeadquarterPage.Location = new System.Drawing.Point(12, 705);
            this.btnBackToHeadquarterPage.Name = "btnBackToHeadquarterPage";
            this.btnBackToHeadquarterPage.Size = new System.Drawing.Size(126, 56);
            this.btnBackToHeadquarterPage.TabIndex = 3;
            this.btnBackToHeadquarterPage.Text = "&Back";
            this.btnBackToHeadquarterPage.UseVisualStyleBackColor = true;
            this.btnBackToHeadquarterPage.Click += new System.EventHandler(this.btnBackToHeadquarterPage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1287, 705);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 56);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // racketsTableAdapter
            // 
            this.racketsTableAdapter.ClearBeforeFill = true;
            // 
            // stringsTableAdapter
            // 
            this.stringsTableAdapter.ClearBeforeFill = true;
            // 
            // racketGripsTableAdapter
            // 
            this.racketGripsTableAdapter.ClearBeforeFill = true;
            // 
            // SportingGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 773);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackToHeadquarterPage);
            this.Controls.Add(this.grpBoxRacketStrings);
            this.Controls.Add(this.grpBoxStrings);
            this.Controls.Add(this.grpBoxTennisRackets);
            this.Name = "SportingGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sporting Goods";
            this.ttpProduct.SetToolTip(this, "Products can be produced by Wilson Sporting Goods");
            this.Load += new System.EventHandler(this.SportingGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picString)).EndInit();
            this.grpBoxTennisRackets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet7)).EndInit();
            this.grpBoxStrings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet8)).EndInit();
            this.grpBoxRacketStrings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacketGrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racketGripsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilsonSportingGoodsDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRacket;
        private System.Windows.Forms.PictureBox picGrips;
        private System.Windows.Forms.PictureBox picString;
        private System.Windows.Forms.GroupBox grpBoxTennisRackets;
        private System.Windows.Forms.GroupBox grpBoxStrings;
        private System.Windows.Forms.GroupBox grpBoxRacketStrings;
        private System.Windows.Forms.Button btnBackToHeadquarterPage;
        private System.Windows.Forms.Button btnExit;
        private WilsonSportingGoodsDataSet7 wilsonSportingGoodsDataSet7;
        private System.Windows.Forms.BindingSource racketsBindingSource;
        private WilsonSportingGoodsDataSet7TableAdapters.RacketsTableAdapter racketsTableAdapter;
        private WilsonSportingGoodsDataSet8 wilsonSportingGoodsDataSet8;
        private System.Windows.Forms.BindingSource stringsBindingSource;
        private WilsonSportingGoodsDataSet8TableAdapters.StringsTableAdapter stringsTableAdapter;
        private WilsonSportingGoodsDataSet9 wilsonSportingGoodsDataSet9;
        private System.Windows.Forms.BindingSource racketGripsBindingSource;
        private WilsonSportingGoodsDataSet9TableAdapters.RacketGripsTableAdapter racketGripsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridRacket;
        private System.Windows.Forms.DataGridView dataGridString;
        private System.Windows.Forms.DataGridView dataGridRacketGrip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip ttpProduct;
    }
}
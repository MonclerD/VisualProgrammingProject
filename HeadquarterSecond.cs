using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MidtermProject
{
    public partial class ViewStocks : Form
    {
        public ViewStocks()
        {
            InitializeComponent();
        }

        private void ViewStocks_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT Transaction_ID, WarehouseName, FactoryName, ProductType, ProductName, QuantityTransaction, TransactionDate, ClientName " +
              "FROM WarehouseTransaction " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Factory ON WarehouseTransaction.Factory_ID = Factory.Factory_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID " +
              "INNER JOIN Client ON WarehouseTransaction.Client_ID = Client.Client_ID";


            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridHeadquarterStock.DataSource = table;

            dataGridHeadquarterStock.Columns[0].Width = 170;
            dataGridHeadquarterStock.Columns[1].Width = 250;
            dataGridHeadquarterStock.Columns[2].Width = 250;
            dataGridHeadquarterStock.Columns[3].Width = 200;
            dataGridHeadquarterStock.Columns[4].Width = 400;
            dataGridHeadquarterStock.Columns[5].Width = 200;
            dataGridHeadquarterStock.Columns[6].Width = 200;
            dataGridHeadquarterStock.Columns[7].Width = 350;

            try
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn1.Open();
                string load1 = "SELECT [Order].Order_ID, ClientName, [Order].OrderQuantity, [Order].OrderDate, [Order].OrderLocation, [Order].Transaction_ID " +
                  "FROM [Order] " +
                  "INNER JOIN WarehouseTransaction ON [Order].Transaction_ID = WarehouseTransaction.Transaction_ID " +
                  "INNER JOIN Client ON [Order].Client_ID = Client.Client_ID"; 

                SqlDataAdapter sda1 = new SqlDataAdapter(load1, conn1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                dataGridOrderHeadquarter.DataSource = dt1;
                dataGridOrderHeadquarter.Columns[0].Width = 100;
                dataGridOrderHeadquarter.Columns[1].Width = 300;
                dataGridOrderHeadquarter.Columns[2].Width = 200;
                dataGridOrderHeadquarter.Columns[3].Width = 250;
                dataGridOrderHeadquarter.Columns[4].Width = 400;
                dataGridOrderHeadquarter.Columns[5].Width = 100;
                conn1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                //conn.Close();
            }

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string load = "SELECT * FROM Product ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridProduct.DataSource = dt;
                dataGridProduct.Columns[0].Width = 100;
                dataGridProduct.Columns[1].Width = 150;
                dataGridProduct.Columns[2].Width = 400;
                dataGridProduct.Columns[3].Width = 175;
                dataGridProduct.Columns[4].Width = 200;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                //conn.Close();
            }






        }

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void btnBackToHeadquarterPage_Click(object sender, EventArgs e)
        {
            this.Close();
            HeadquarterPage hqp2 = new HeadquarterPage();
            hqp2.Show();

        }

        private void btnExitFromHeadquarterStockView_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void btnBackWarehouse_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp3 = new HomePage();
            hp3.Show();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT Transaction_ID, WarehouseName, FactoryName, ProductType, ProductName, QuantityTransaction, TransactionDate " +
              "FROM WarehouseTransaction " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Factory ON WarehouseTransaction.Factory_ID = Factory.Factory_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID";


            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridWarehouseStock.DataSource = table;

            dataGridWarehouseStock.Columns[0].Width = 170;
            dataGridWarehouseStock.Columns[1].Width = 250;
            dataGridWarehouseStock.Columns[2].Width = 250;
            dataGridWarehouseStock.Columns[3].Width = 200;
            dataGridWarehouseStock.Columns[4].Width = 400;
            dataGridWarehouseStock.Columns[5].Width = 200;
            dataGridWarehouseStock.Columns[6].Width = 200;

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string load = "SELECT * FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridTransactionAdd.DataSource = dt;
                dataGridTransactionAdd.Columns[0].Width = 100;
                dataGridTransactionAdd.Columns[1].Width = 150;
                dataGridTransactionAdd.Columns[2].Width = 100;
                dataGridTransactionAdd.Columns[3].Width = 100;
                dataGridTransactionAdd.Columns[4].Width = 250;
                dataGridTransactionAdd.Columns[5].Width = 250;
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


            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                string warehouse_id = "SELECT Warehouse_ID FROM Warehouse ";
                SqlDataAdapter sda = new SqlDataAdapter(warehouse_id, conn);
                sda.Fill(ds);
                cmbBoxWarehouseID.DataSource = ds.Tables[0];
                cmbBoxWarehouseID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Warehouse_ID" + ex);
            }
            finally
            {
                //conn.Close();
            }

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                string factory_id = "SELECT Factory_ID FROM Factory ";
                SqlDataAdapter sda = new SqlDataAdapter(factory_id, conn);
                sda.Fill(ds);
                cmbBoxFactoryID.DataSource = ds.Tables[0];
                cmbBoxFactoryID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Factory_ID" + ex);
            }
            finally
            {
                //conn.Close();
            }

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                string product_id = "SELECT Product_ID FROM Product ";
                SqlDataAdapter sda = new SqlDataAdapter(product_id, conn);
                sda.Fill(ds);
                cmbBoxProductID.DataSource = ds.Tables[0];
                cmbBoxProductID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Product_ID" + ex);
            }
            finally
            {
               // conn.Close();
            }

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                string transaction_id = "SELECT Transaction_ID FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(transaction_id, conn);
                sda.Fill(ds);
                cmbBoxTransactionID.DataSource = ds.Tables[0];
                cmbBoxTransactionID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Product_ID" + ex);
            }
            finally
            {
                //conn.Close();
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string query1 = "INSERT INTO WarehouseTransaction (Warehouse_ID, Factory_ID, Product_ID, QuantityTransaction, TransactionDate) VALUES ('" + cmbBoxWarehouseID.Text + "', '" + cmbBoxFactoryID.Text + "', '" + cmbBoxProductID.Text + "', '" + txtTransactionQuantity.Text + "', '" + Convert.ToDateTime(mtxtTransactionDate.Text).ToString("yyyy-MM-dd") + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Succesfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in inserting into  Transaction datatable" + ex);
            }
            finally
            {
                //conn.Close();
            }

            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT Transaction_ID, WarehouseName, FactoryName, ProductType, ProductName, QuantityTransaction, TransactionDate " +
              "FROM WarehouseTransaction " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Factory ON WarehouseTransaction.Factory_ID = Factory.Factory_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID";


            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridWarehouseStock.DataSource = table;

            dataGridWarehouseStock.Columns[0].Width = 170;
            dataGridWarehouseStock.Columns[1].Width = 250;
            dataGridWarehouseStock.Columns[2].Width = 250;
            dataGridWarehouseStock.Columns[3].Width = 200;
            dataGridWarehouseStock.Columns[4].Width = 400;
            dataGridWarehouseStock.Columns[5].Width = 200;
            dataGridWarehouseStock.Columns[6].Width = 200;

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string load = "SELECT * FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridTransactionAdd.DataSource = dt;
                dataGridTransactionAdd.Columns[0].Width = 100;
                dataGridTransactionAdd.Columns[1].Width = 150;
                dataGridTransactionAdd.Columns[2].Width = 100;
                dataGridTransactionAdd.Columns[3].Width = 100;
                dataGridTransactionAdd.Columns[4].Width = 250;
                dataGridTransactionAdd.Columns[5].Width = 250;
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

        private void btnUpdateTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string query2 = "UPDATE WarehouseTransaction SET Warehouse_ID = '" + cmbBoxWarehouseID.Text + "', Factory_ID = '" + cmbBoxFactoryID.Text + "', Product_ID = '" + cmbBoxProductID.Text + "', QuantityTransaction = '" + txtTransactionQuantity.Text + "', TransactionDate = '" + Convert.ToDateTime(mtxtTransactionDate.Text).ToString("yyyy-MM-dd") + "' WHERE Transaction_ID = '" + cmbBoxTransactionID.Text + "'";
                SqlCommand cmd = new SqlCommand(query2, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Update Button: " + ex.Message);
            }
            finally
            {
                //conn.Close();
            }

            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT Transaction_ID, WarehouseName, FactoryName, ProductType, ProductName, QuantityTransaction, TransactionDate " +
              "FROM WarehouseTransaction " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Factory ON WarehouseTransaction.Factory_ID = Factory.Factory_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID";


            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridWarehouseStock.DataSource = table;

            dataGridWarehouseStock.Columns[0].Width = 170;
            dataGridWarehouseStock.Columns[1].Width = 250;
            dataGridWarehouseStock.Columns[2].Width = 250;
            dataGridWarehouseStock.Columns[3].Width = 200;
            dataGridWarehouseStock.Columns[4].Width = 400;
            dataGridWarehouseStock.Columns[5].Width = 200;
            dataGridWarehouseStock.Columns[6].Width = 200;

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string load = "SELECT * FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridTransactionAdd.DataSource = dt;
                dataGridTransactionAdd.Columns[0].Width = 100;
                dataGridTransactionAdd.Columns[1].Width = 150;
                dataGridTransactionAdd.Columns[2].Width = 100;
                dataGridTransactionAdd.Columns[3].Width = 100;
                dataGridTransactionAdd.Columns[4].Width = 250;
                dataGridTransactionAdd.Columns[5].Width = 250;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTransactionQuantity.Clear();
            mtxtTransactionDate.Clear();
        }

        private void btnSeeOrdersPage_Click(object sender, EventArgs e)
        {
            this.Close();
            WarehouseCheckOrders whc1 = new WarehouseCheckOrders();
            whc1.Show();
        }

        private void dataGridWarehouseStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

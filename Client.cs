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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        


        private void btnBackClient_Click_1(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp4 = new HomePage();
            hp4.Show();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT Transaction_ID, WarehouseName, FactoryName, ProductType, ProductName, QuantityTransaction, TransactionDate, WarehouseTransaction.Product_ID " +
              "FROM WarehouseTransaction " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Factory ON WarehouseTransaction.Factory_ID = Factory.Factory_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID ";
              


            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridStocks.DataSource = table;

            dataGridStocks.Columns[0].Width = 170;
            dataGridStocks.Columns[1].Width = 250;
            dataGridStocks.Columns[2].Width = 250;
            dataGridStocks.Columns[3].Width = 200;
            dataGridStocks.Columns[4].Width = 400;
            dataGridStocks.Columns[5].Width = 200;
            dataGridStocks.Columns[6].Width = 200;
            dataGridStocks.Columns[7].Width = 150;
           //dataGridStocks.Columns[8].Width = 170;

            /*try
            {
                cmbBoxTransactiontIDClient.Items.Add("Racket");
                cmbBoxTransactiontIDClient.Items.Add("String");
                cmbBoxTransactiontIDClient.Items.Add("Racket Grip");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Combobox" + ex);
            }
            finally
            {
                //conn.Close();
            }*/
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                string client_id = "SELECT Client_ID FROM Client ";
                SqlDataAdapter sda = new SqlDataAdapter(client_id, conn);
                sda.Fill(ds);
                cmbBoxClientID.DataSource = ds.Tables[0];
                cmbBoxClientID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Client_ID" + ex);
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
                string product_id = "SELECT Transaction_ID FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(product_id, conn);
                sda.Fill(ds);
                cmbBoxTransactiontIDClient.DataSource = ds.Tables[0];
                cmbBoxTransactiontIDClient.DisplayMember = ds.Tables[0].Columns[0].ToString();
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

        private void cmbBoxProductTypeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
            if (cmbBoxProductIDClient.Text == "Racket")
            {
                cmbBoxProductModelClient.Items.Clear();
                conn.Open();
                string racket_u = "SELECT RacketModel FROM Racket ";
                SqlCommand cmd = new SqlCommand(racket_u, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxProductModelClient.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
            else if (cmbBoxProductIDClient.Text == "String")
            {
                cmbBoxProductModelClient.Items.Clear();
                conn.Open();
                string string_u = "SELECT StringModel FROM String ";
                SqlCommand cmd = new SqlCommand(string_u, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxProductModelClient.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
            else if (cmbBoxProductIDClient.Text == "Racket Grip")
            {
                cmbBoxProductModelClient.Items.Clear();
                conn.Open();
                string grip_u = "SELECT RacketGripModel FROM RacketGrip ";
                SqlCommand cmd = new SqlCommand(grip_u, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxProductModelClient.Items.Add(dr[0].ToString());
                }
                conn.Close();
            } */
        }

        private void btnOrderClient_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();

                // Insert the order into the database
                string query1 = "INSERT INTO [Order] (Transaction_ID, Client_ID, OrderQuantity, OrderLocation, OrderDate) VALUES ('" + cmbBoxTransactiontIDClient.Text + "', '" + cmbBoxClientID.Text + "', '" + txtQuantityClient.Text + "', '" + rtxtOrderLocationClient.Text + "', '" + Convert.ToDateTime(mtextOrderDate.Text).ToString("yyyy-MM-dd") + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
                sda.SelectCommand.ExecuteNonQuery();

                // Check if there is enough product in the warehouse for the order
                int transactionId = int.Parse(cmbBoxTransactiontIDClient.Text);
                int orderQuantity = int.Parse(txtQuantityClient.Text);
                string query2 = "SELECT QuantityTransaction AS Quantity FROM WarehouseTransaction WHERE Transaction_ID = " + transactionId;
                SqlCommand cmd = new SqlCommand(query2, conn);
                int availableQuantity = (int)cmd.ExecuteScalar();
                if (availableQuantity >= orderQuantity)
                {
                    try
                    {
                        SqlConnection conn2 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                        conn2.Open();
                        int OrderQuantity = int.Parse(txtQuantityClient.Text);
                        string query3 = "UPDATE WarehouseTransaction SET QuantityTransaction = (QuantityTransaction - " +OrderQuantity+ ") WHERE Transaction_ID = " + cmbBoxTransactiontIDClient.Text;

                        SqlCommand cmda = new SqlCommand(query3, conn2);
                        cmda.ExecuteNonQuery();
                        MessageBox.Show("Update Successful");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in Update Button: " + ex.Message);
                    }
                    finally
                    {
                        //conn.Close();
                    }

                    
                }
                else
                {
                    MessageBox.Show("Not enough product in the warehouse for the order");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in inserting into Order to database: " + ex.Message);
            }
            finally
            {
                
                //conn.Close();
            }

            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT Transaction_ID, WarehouseName, FactoryName, ProductType, ProductName, QuantityTransaction, TransactionDate, WarehouseTransaction.Product_ID " +
              "FROM WarehouseTransaction " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Factory ON WarehouseTransaction.Factory_ID = Factory.Factory_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID ";



            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridStocks.DataSource = table;

            dataGridStocks.Columns[0].Width = 170;
            dataGridStocks.Columns[1].Width = 250;
            dataGridStocks.Columns[2].Width = 250;
            dataGridStocks.Columns[3].Width = 200;
            dataGridStocks.Columns[4].Width = 400;
            dataGridStocks.Columns[5].Width = 200;
            dataGridStocks.Columns[6].Width = 200;
            dataGridStocks.Columns[7].Width = 150;
            //dataGridStocks.Columns[8].Width = 170;







        }

        private void cmbBoxClientID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmedOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientReport CR = new ClientReport();
            CR.Show();
        }
    }
    
}

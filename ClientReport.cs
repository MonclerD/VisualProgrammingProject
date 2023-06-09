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
    public partial class ClientReport : Form
    {
        public ClientReport()
        {
            InitializeComponent();
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT ConfirmedShipping_ID, OrderDate, OrderQuantity, OrderLocation, ClientName, ClientPhoneNumber, WarehouseName, WarehouseLocation, WarehousePhoneNumber, ProductName, ProductType, Departure_date, Arrival_date, ConfirmedArrival_date " +
              "FROM ConfirmedShipping " +
              "INNER JOIN ConfirmedOrder ON ConfirmedShipping.ConfirmedOrder_ID = ConfirmedOrder.ConfirmedOrder_ID " +
              "INNER JOIN WarehouseTransaction ON ConfirmedShipping.Transaction_ID = WarehouseTransaction.Transaction_ID " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID " +
              "INNER JOIN Shipping ON ConfirmedShipping.Shipping_ID = Shipping.Shipping_ID " + 
              "INNER JOIN Client ON WarehouseTransaction.Client_ID = Client.Client_ID";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridClientReport.DataSource = table;

            dataGridClientReport.Columns[0].Width = 170;
            dataGridClientReport.Columns[1].Width = 250;
            dataGridClientReport.Columns[2].Width = 250;
            dataGridClientReport.Columns[3].Width = 200;
            dataGridClientReport.Columns[4].Width = 400;
            dataGridClientReport.Columns[5].Width = 200;
            dataGridClientReport.Columns[6].Width = 200;
            dataGridClientReport.Columns[7].Width = 200;
            dataGridClientReport.Columns[8].Width = 200;
            dataGridClientReport.Columns[9].Width = 200;
            dataGridClientReport.Columns[10].Width = 200;
            dataGridClientReport.Columns[11].Width = 200;
            dataGridClientReport.Columns[12].Width = 200;
            dataGridClientReport.Columns[13].Width = 200;



            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                string client_id = "SELECT Order_ID FROM [Order] ";
                SqlDataAdapter sda = new SqlDataAdapter(client_id, conn);
                sda.Fill(ds);
                cmbBoxOrder_ID_Client.DataSource = ds.Tables[0];
                cmbBoxOrder_ID_Client.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Order_ID combo box" + ex);
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
                string shipping_id = "SELECT Shipping_ID FROM Shipping ";
                SqlDataAdapter sda = new SqlDataAdapter(shipping_id, conn);
                sda.Fill(ds);
                cmbBoxShipping_ID.DataSource = ds.Tables[0];
                cmbBoxShipping_ID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Shipping_ID combo box" + ex);
            }
            finally
            {
                //conn.Close();
            }



        }

        private void btnEXITfromReport_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmShipping_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True"))
                {
                    connection.Open();

                    // Insert into ConfirmedOrder
                    string insertQuery1 = "INSERT INTO ConfirmedOrder (ConfirmedOrder_ID, Client_ID, OrderQuantity, OrderDate, OrderLocation, Transaction_ID) " +
                                          "SELECT Order_ID, Client_ID, OrderQuantity, OrderDate, OrderLocation, Transaction_ID " +
                                          "FROM [Order] WHERE Order_ID = @OrderID";

                    SqlCommand command1 = new SqlCommand(insertQuery1, connection);
                    command1.Parameters.AddWithValue("@OrderID", cmbBoxOrder_ID_Client.Text);
                    command1.ExecuteNonQuery();

                    // Insert into ConfirmedShipping
                    string insertQuery2 = "INSERT INTO ConfirmedShipping (ConfirmedShipping_ID, ConfirmedArrival_date, ConfirmedOrder_ID, Transaction_ID, Shipping_ID) " +
                                          "SELECT Shipping_ID, @ConfirmedArrivalDate, @ConfirmedOrder_ID, Transaction_ID, @ShippingID " +
                                          "FROM Shipping";

                    SqlCommand command2 = new SqlCommand(insertQuery2, connection);
                    command2.Parameters.AddWithValue("@ConfirmedArrivalDate", Convert.ToDateTime(mtextArrivalDateClient.Text).ToString("yyyy-MM-dd"));
                    command2.Parameters.AddWithValue("@ConfirmedOrder_ID", cmbBoxOrder_ID_Client.Text);
                    command2.Parameters.AddWithValue("@ShippingID", cmbBoxShipping_ID.Text);
                    command2.ExecuteNonQuery();

                    /*string insertQuery3 = "INSERT INTO ConfirmedShipping (ConfirmedShipping_ID, Client_ID, OrderQuantity, OrderDate, OrderLocation, Transaction_ID) " +
                                          "SELECT Order_ID, Client_ID, OrderQuantity, OrderDate, OrderLocation, Transaction_ID " +
                                          "FROM [Order] WHERE Shipping_ID = @ShippingID";

                    SqlCommand command3 = new SqlCommand(insertQuery3, connection);
                    command3.Parameters.AddWithValue("@ShippingID", cmbBoxShipping_ID.Text);
                    command3.ExecuteNonQuery(); */



                    MessageBox.Show("Success");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            try
            {
                SqlConnection conn3 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn3.Open();
                string load = "SELECT ConfirmedShipping_ID, OrderDate, OrderQuantity, OrderLocation, ClientName, ClientPhoneNumber, WarehouseName, WarehouseLocation, WarehousePhoneNumber, ProductName, ProductType, Departure_date, Arrival_date, ConfirmedArrival_date " +
                              "FROM ConfirmedShipping " +
                              "INNER JOIN ConfirmedOrder ON ConfirmedShipping.ConfirmedOrder_ID = ConfirmedOrder.ConfirmedOrder_ID " +
                              "INNER JOIN WarehouseTransaction ON ConfirmedShipping.Transaction_ID = WarehouseTransaction.Transaction_ID " +
                              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
                              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID " +
                              "INNER JOIN Shipping ON ConfirmedShipping.Shipping_ID = Shipping.Shipping_ID " +
                              "INNER JOIN Client ON WarehouseTransaction.Client_ID = Client.Client_ID";

                SqlDataAdapter sda2 = new SqlDataAdapter(load, conn3);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridClientReport.DataSource = dt;

                dataGridClientReport.Columns[0].Width = 170;
                dataGridClientReport.Columns[1].Width = 250;
                dataGridClientReport.Columns[2].Width = 250;
                dataGridClientReport.Columns[3].Width = 200;
                dataGridClientReport.Columns[4].Width = 400;
                dataGridClientReport.Columns[5].Width = 200;
                dataGridClientReport.Columns[6].Width = 200;
                dataGridClientReport.Columns[7].Width = 200;
                dataGridClientReport.Columns[8].Width = 200;
                dataGridClientReport.Columns[9].Width = 200;
                dataGridClientReport.Columns[10].Width = 200;
                dataGridClientReport.Columns[11].Width = 200;
                dataGridClientReport.Columns[12].Width = 200;
                dataGridClientReport.Columns[13].Width = 200;
                conn3.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                //conn.Close();
            }





            /*try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string query = "INSERT INTO ConfirmedOrder (Order_ID, Client_ID, OrderQuantity, OrderDate, OrderLocation, Transaction_ID) SELECT (Order_ID, Client_ID, OrderQuantity, OrderDate, OrderLocation, Transaction_ID) FROM [Order] WHERE Order_ID = ('" + cmbBoxOrder_ID_Client.Text + "')"; 
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.ExecuteNonQuery();

                string query3 = "INSERT INTO ConfirmedShipping (Order_ID, Shipping_ID, Transaction_ID, ConfirmedArrival_date) VALUES ('" + Convert.ToDateTime(mtextArrivalDateClient.Text).ToString("yyyy-MM-dd") + "') SELECT (Order_ID, Shipping_ID, Transaction_ID) FROM Shipping";
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, conn);
                sda3.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Succesfull");
                conn.Close();

                // string query2 = "INSERT INTO ConfirmedShipping (ConfirmedArrival_date) VALUES ('" + Convert.ToDateTime(mtextArrivalDateClient.Text).ToString("yyyy-MM-dd") + "')"; 
                // SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                // sda2.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in inserting into Order table" + ex);
            }
            finally
            {
                //conn.Close();
            } */
        }
    }
}

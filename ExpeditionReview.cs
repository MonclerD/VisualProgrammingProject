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
    public partial class ExpeditionReview : Form
    {
        public ExpeditionReview()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExpeditionReview_Load(object sender, EventArgs e)
        {
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
                dataGridCompletedOrders.DataSource = dt;

                dataGridCompletedOrders.Columns[0].Width = 170;
                dataGridCompletedOrders.Columns[1].Width = 250;
                dataGridCompletedOrders.Columns[2].Width = 250;
                dataGridCompletedOrders.Columns[3].Width = 200;
                dataGridCompletedOrders.Columns[4].Width = 400;
                dataGridCompletedOrders.Columns[5].Width = 200;
                dataGridCompletedOrders.Columns[6].Width = 200;
                dataGridCompletedOrders.Columns[7].Width = 200;
                dataGridCompletedOrders.Columns[8].Width = 200;
                dataGridCompletedOrders.Columns[9].Width = 200;
                dataGridCompletedOrders.Columns[10].Width = 200;
                dataGridCompletedOrders.Columns[11].Width = 200;
                dataGridCompletedOrders.Columns[12].Width = 200;
                dataGridCompletedOrders.Columns[13].Width = 200;
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


            try
            {
                SqlConnection conn4 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn4.Open();
                string load = "SELECT Shipping_ID, OrderDate, OrderQuantity, OrderLocation, ClientName, ClientPhoneNumber, WarehouseName, WarehouseLocation, WarehousePhoneNumber, ProductName, ProductType, Departure_date, Arrival_date " +
              "FROM Shipping " +
              "INNER JOIN [Order] ON Shipping.Order_ID = [Order].Order_ID " +
              "INNER JOIN WarehouseTransaction ON Shipping.Transaction_ID = WarehouseTransaction.Transaction_ID " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID " +
              "INNER JOIN Client ON WarehouseTransaction.Client_ID = Client.Client_ID";
                SqlDataAdapter sda2 = new SqlDataAdapter(load, conn4);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridOrdersShipping.DataSource = dt;
                dataGridOrdersShipping.Columns[0].Width = 170;
                dataGridOrdersShipping.Columns[1].Width = 250;
                dataGridOrdersShipping.Columns[2].Width = 250;
                dataGridOrdersShipping.Columns[3].Width = 200;
                dataGridOrdersShipping.Columns[4].Width = 400;
                dataGridOrdersShipping.Columns[5].Width = 200;
                dataGridOrdersShipping.Columns[6].Width = 200;
                dataGridOrdersShipping.Columns[7].Width = 200;
                dataGridOrdersShipping.Columns[8].Width = 200;
                dataGridOrdersShipping.Columns[9].Width = 200;
                dataGridOrdersShipping.Columns[10].Width = 200;
                dataGridOrdersShipping.Columns[11].Width = 200;
                dataGridOrdersShipping.Columns[12].Width = 200;
                conn4.Close();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewStocks VS = new ViewStocks();
            VS.Show();
        }
    }
}

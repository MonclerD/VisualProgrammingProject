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
    public partial class ExpeditionInformation : Form
    {
        public ExpeditionInformation()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private int selectedColumnIndex = -1;
        private void ExpeditionInformation_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";
            string query = "SELECT Shipping_ID, OrderDate, OrderQuantity, OrderLocation, ClientName, ClientPhoneNumber, WarehouseName, WarehouseLocation, WarehousePhoneNumber, ProductName, ProductType, Departure_date, Arrival_date " +
              "FROM Shipping " +
              "INNER JOIN [Order] ON Shipping.Order_ID = [Order].Order_ID " +
              "INNER JOIN WarehouseTransaction ON Shipping.Transaction_ID = WarehouseTransaction.Transaction_ID " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID " +
              "INNER JOIN Client ON WarehouseTransaction.Client_ID = Client.Client_ID";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridShipping.DataSource = table;

            dataGridShipping.Columns[0].Width = 170;
            dataGridShipping.Columns[1].Width = 250;
            dataGridShipping.Columns[2].Width = 250;
            dataGridShipping.Columns[3].Width = 200;
            dataGridShipping.Columns[4].Width = 400;
            dataGridShipping.Columns[5].Width = 200;
            dataGridShipping.Columns[6].Width = 200;
            dataGridShipping.Columns[7].Width = 200;
            dataGridShipping.Columns[8].Width = 200;
            dataGridShipping.Columns[9].Width = 200;
            dataGridShipping.Columns[10].Width = 200;
            dataGridShipping.Columns[11].Width = 200;
            dataGridShipping.Columns[12].Width = 200;
            /*
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string load = "SELECT * FROM Shipping ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridShipping.DataSource = dt;
                dataGridShipping.Columns[0].Width = 170;
                dataGridShipping.Columns[1].Width = 250;
                dataGridShipping.Columns[2].Width = 250;
                dataGridShipping.Columns[3].Width = 200;
                dataGridShipping.Columns[4].Width = 400;
                dataGridShipping.Columns[5].Width = 200;
                dataGridShipping.Columns[6].Width = 200;
                dataGridShipping.Columns[7].Width = 200;
                dataGridShipping.Columns[8].Width = 200;
                dataGridShipping.Columns[9].Width = 200;
                dataGridShipping.Columns[10].Width = 200;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                //conn.Close();
            } */

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                string client_id = "SELECT Order_ID FROM [Order] ";
                SqlDataAdapter sda = new SqlDataAdapter(client_id, conn);
                sda.Fill(ds);
                cmbBoxOrder_ID.DataSource = ds.Tables[0];
                cmbBoxOrder_ID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Order_ID" + ex);
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
                cmbBoxTransaction_ID.DataSource = ds.Tables[0];
                cmbBoxTransaction_ID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Transaction_ID" + ex);
            }
            finally
            {
                //conn.Close();
            }

            for (int i = 0; i < dataGridShipping.Columns.Count; i++)
            {
                cmbBoxColumn.Items.Add(dataGridShipping.Columns[i].HeaderText);
            }

            try
            {
                SqlConnection conn4 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn4.Open();
                DataSet ds = new DataSet();
                string transaction_id = "SELECT Shipping_ID FROM Shipping ";
                SqlDataAdapter sda = new SqlDataAdapter(transaction_id, conn4);
                sda.Fill(ds);
                cmbBoxShippingID.DataSource = ds.Tables[0];
                cmbBoxShippingID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn4.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Shipping_ID" + ex);
            }
            finally
            {
                //conn.Close();
            }

        }

        private void btnEXITfromShipping_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddShipping_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string query = "INSERT INTO Shipping (Order_ID, Departure_date, Arrival_date, Transaction_ID) VALUES ('" + cmbBoxOrder_ID.Text + "', '" + Convert.ToDateTime(mtextDepartureDate.Text).ToString("yyyy-MM-dd") + "', '" + Convert.ToDateTime(mtextArrivalDate.Text).ToString("yyyy-MM-dd") + "', '" + cmbBoxTransaction_ID.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Succesfull");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in inserting into Shipping table" + ex);
            }
            finally
            {
                //conn.Close();
            }


            //cmbBoxOrder_ID.Items.Remove(cmbBoxOrder_ID.SelectedItem);



            try
            {
                SqlConnection conn3 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn3.Open();
                string load = "SELECT Shipping_ID, OrderDate, OrderQuantity, OrderLocation, ClientName, ClientPhoneNumber, WarehouseName, WarehouseLocation, WarehousePhoneNumber, ProductName, ProductType, Departure_date, Arrival_date " +
              "FROM Shipping " +
              "INNER JOIN [Order] ON Shipping.Order_ID = [Order].Order_ID " +
              "INNER JOIN WarehouseTransaction ON Shipping.Transaction_ID = WarehouseTransaction.Transaction_ID " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID " +
              "INNER JOIN Client ON WarehouseTransaction.Client_ID = Client.Client_ID";
                SqlDataAdapter sda2 = new SqlDataAdapter(load, conn3);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridShipping.DataSource = dt;
                dataGridShipping.Columns[0].Width = 170;
                dataGridShipping.Columns[1].Width = 250;
                dataGridShipping.Columns[2].Width = 250;
                dataGridShipping.Columns[3].Width = 200;
                dataGridShipping.Columns[4].Width = 400;
                dataGridShipping.Columns[5].Width = 200;
                dataGridShipping.Columns[6].Width = 200;
                dataGridShipping.Columns[7].Width = 200;
                dataGridShipping.Columns[8].Width = 200;
                dataGridShipping.Columns[9].Width = 200;
                dataGridShipping.Columns[10].Width = 200;
                dataGridShipping.Columns[11].Width = 200;
                dataGridShipping.Columns[12].Width = 200;
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
        }

        private void btnCheckOrders_Click(object sender, EventArgs e)
        {
            this.Close();
            WarehouseCheckOrders cho = new WarehouseCheckOrders();
            cho.Show();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            /*if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    da.Filter = string.Empty;
                }
            }*/
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            string searchValue = txtSearch.Text.Trim();
            dataGridShipping.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (selectedColumnIndex == -1 || string.IsNullOrEmpty(searchValue))
            {
                // Clear the filter and display all rows
                dataGridShipping.ClearSelection();
            }
            else
            {
                // Loop through each row in the DataGridView
                foreach (DataGridViewRow row in dataGridShipping.Rows)
                {
                    // Get the value of the selected column for the current row
                    string cellValue = row.Cells[selectedColumnIndex].Value?.ToString();

                    if (cellValue != null && cellValue.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // If the search value is found in the cell, select the entire row
                        row.Selected = true;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }



        }

        private void btnSearchColumn_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColumnIndex = cmbBoxColumn.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn.Open();
                string query2 = "UPDATE Shipping SET Transaction_ID = '" + cmbBoxTransaction_ID.Text + "', Order_ID = '" + cmbBoxOrder_ID.Text + "', Departure_date = '" + Convert.ToDateTime(mtextDepartureDate.Text).ToString("yyyy-MM-dd") + "', Arrival_date = '" + Convert.ToDateTime(mtextArrivalDate.Text).ToString("yyyy-MM-dd") + "' WHERE Shipping_ID = '" + cmbBoxShippingID.Text + "'";
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

            try
            {
                SqlConnection conn3 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
                conn3.Open();
                string load = "SELECT Shipping_ID, OrderDate, OrderQuantity, OrderLocation, ClientName, ClientPhoneNumber, WarehouseName, WarehouseLocation, WarehousePhoneNumber, ProductName, ProductType, Departure_date, Arrival_date " +
              "FROM Shipping " +
              "INNER JOIN [Order] ON Shipping.Order_ID = [Order].Order_ID " +
              "INNER JOIN WarehouseTransaction ON Shipping.Transaction_ID = WarehouseTransaction.Transaction_ID " +
              "INNER JOIN Warehouse ON WarehouseTransaction.Warehouse_ID = Warehouse.Warehouse_ID " +
              "INNER JOIN Product ON WarehouseTransaction.Product_ID = Product.Product_ID " +
              "INNER JOIN Client ON WarehouseTransaction.Client_ID = Client.Client_ID";
                SqlDataAdapter sda2 = new SqlDataAdapter(load, conn3);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridShipping.DataSource = dt;
                dataGridShipping.Columns[0].Width = 170;
                dataGridShipping.Columns[1].Width = 250;
                dataGridShipping.Columns[2].Width = 250;
                dataGridShipping.Columns[3].Width = 200;
                dataGridShipping.Columns[4].Width = 400;
                dataGridShipping.Columns[5].Width = 200;
                dataGridShipping.Columns[6].Width = 200;
                dataGridShipping.Columns[7].Width = 200;
                dataGridShipping.Columns[8].Width = 200;
                dataGridShipping.Columns[9].Width = 200;
                dataGridShipping.Columns[10].Width = 200;
                dataGridShipping.Columns[11].Width = 200;
                dataGridShipping.Columns[12].Width = 200;
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
        }
    }
}

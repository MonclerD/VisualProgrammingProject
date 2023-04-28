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
    public partial class Factory2 : Form
    {
        public Factory2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
        private void Factory2_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string load = "SELECT * FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridTransaction.DataSource = dt;
                dataGridTransaction.Columns[0].Width = 100;
                dataGridTransaction.Columns[1].Width = 150;
                dataGridTransaction.Columns[2].Width = 100;
                dataGridTransaction.Columns[3].Width = 100;
                dataGridTransaction.Columns[4].Width = 250;
                dataGridTransaction.Columns[5].Width = 250;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                conn.Close();
            }

            try
            {
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
                conn.Close();
            }

            try
            {
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
                conn.Close();
            }

            try
            {
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
                conn.Close();
            }

            try
            {
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
                conn.Close();
            }


        }

        private void btnExitFactory2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFactory2BacktoFactory_Click(object sender, EventArgs e)
        {
            this.Close();
            Factory fc = new Factory();
            fc.Show();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO WarehouseTransaction (Warehouse_ID, Factory_ID, Product_ID, QuantityTransaction, TransactionDate) VALUES ('" + cmbBoxWarehouseID.Text + "', '" + cmbBoxFactoryID.Text + "', '" + cmbBoxProductID.Text + "', '" + txtTransactionQuantity.Text + "', '"+Convert.ToDateTime(mtxtTransactionDate.Text).ToString("yyyy-MM-dd")+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Succesfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in inserting into  Transaction datatable" + ex);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                string load = "SELECT * FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridTransaction.DataSource = dt;
                dataGridTransaction.Columns[0].Width = 100;
                dataGridTransaction.Columns[1].Width = 150;
                dataGridTransaction.Columns[2].Width = 100;
                dataGridTransaction.Columns[3].Width = 100;
                dataGridTransaction.Columns[4].Width = 250;
                dataGridTransaction.Columns[5].Width = 250;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                conn.Close();
            }



        }

        private void btnUpdateTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE WarehouseTransaction SET Warehouse_ID = '" + cmbBoxWarehouseID.Text + "', Factory_ID = '" + cmbBoxFactoryID.Text + "', Product_ID = '" + cmbBoxProductID.Text + "', QuantityTransaction = '" + txtTransactionQuantity.Text + "', TransactionDate = '" + Convert.ToDateTime(mtxtTransactionDate.Text).ToString("yyyy-MM-dd") + "' WHERE Transaction_ID = '" + cmbBoxTransactionID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Update Button: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                string load = "SELECT * FROM WarehouseTransaction ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridTransaction.DataSource = dt;
                dataGridTransaction.Columns[0].Width = 100;
                dataGridTransaction.Columns[1].Width = 150;
                dataGridTransaction.Columns[2].Width = 100;
                dataGridTransaction.Columns[3].Width = 100;
                dataGridTransaction.Columns[4].Width = 250;
                dataGridTransaction.Columns[5].Width = 250;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading the data table" + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTransactionQuantity.Clear();
            mtxtTransactionDate.Clear();
        }
    }
}

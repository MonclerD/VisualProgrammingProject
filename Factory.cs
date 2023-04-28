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
    public partial class Factory : Form
    {
        public Factory()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
        private void btnFactory_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp2 = new HomePage();
            hp2.Show();
        }

        private void Factory_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string load = "SELECT * FROM Product ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridFactoryProducts.DataSource = dt;
                dataGridFactoryProducts.Columns[0].Width = 100;
                dataGridFactoryProducts.Columns[1].Width = 150;
                dataGridFactoryProducts.Columns[2].Width = 400;
                dataGridFactoryProducts.Columns[3].Width = 175;
                dataGridFactoryProducts.Columns[4].Width = 200;
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
                cmbBoxProductType.Items.Add("Racket");
                cmbBoxProductType.Items.Add("String");
                cmbBoxProductType.Items.Add("Racket Grip");
            }
            catch  (Exception ex)
            {
                MessageBox.Show("Error in Combobox" + ex);
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
        }

        private void dataGridFactoryProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxProductType.Text == "Racket")
            {
                cmbBoxProductName.Items.Clear();
                conn.Open();
                string racket_u = "SELECT RacketModel FROM Racket ";
                SqlCommand cmd = new SqlCommand(racket_u, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxProductName.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
            else if (cmbBoxProductType.Text == "String")
            {
                cmbBoxProductName.Items.Clear();
                conn.Open();
                string string_u = "SELECT StringModel FROM String ";
                SqlCommand cmd = new SqlCommand(string_u, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxProductName.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
            else if (cmbBoxProductType.Text == "Racket Grip")
            {
                cmbBoxProductName.Items.Clear();
                conn.Open();
                string grip_u = "SELECT RacketGripModel FROM RacketGrip ";
                SqlCommand cmd = new SqlCommand(grip_u, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxProductName.Items.Add(dr[0].ToString());
                }
                conn.Close();
            }
        }

            private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Product (ProductType, ProductName, ProductPriceDollar, Quantity) VALUES ('"+cmbBoxProductType.Text+"', '"+cmbBoxProductName.Text+"', '"+txtProductPrice.Text+"', '"+txtQuantity.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Succesfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in inserting into data table" + ex);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                string load = "SELECT * FROM Product ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridFactoryProducts.DataSource = dt;
                dataGridFactoryProducts.Columns[0].Width = 100;
                dataGridFactoryProducts.Columns[1].Width = 150;
                dataGridFactoryProducts.Columns[2].Width = 400;
                dataGridFactoryProducts.Columns[3].Width = 175;
                dataGridFactoryProducts.Columns[4].Width = 200;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {


            txtProductPrice.Clear();
            txtQuantity.Clear();
            
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Product SET ProductType = '" + cmbBoxProductType.Text + "', ProductName = '" + cmbBoxProductName.Text + "', ProductPriceDollar = '" + txtProductPrice.Text + "', Quantity = '" + txtQuantity.Text + "' WHERE Product_ID = '" + cmbBoxProductID.Text + "'";
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
                string load = "SELECT * FROM Product ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridFactoryProducts.DataSource = dt;
                dataGridFactoryProducts.Columns[0].Width = 100;
                dataGridFactoryProducts.Columns[1].Width = 150;
                dataGridFactoryProducts.Columns[2].Width = 400;
                dataGridFactoryProducts.Columns[3].Width = 175;
                dataGridFactoryProducts.Columns[4].Width = 200;
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

        private void btnNextFactory2Page_Click(object sender, EventArgs e)
        {
            this.Close();
            Factory2 Fc2 = new Factory2();
            Fc2.Show();
            

        }

        private void cmbBoxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

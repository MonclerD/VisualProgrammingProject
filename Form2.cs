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
    public partial class HeadquarterPage : Form
    {
        public HeadquarterPage()
        {
            InitializeComponent();
        }
        SqlConnection conn2 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
        private void btnBackHeadquarter_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp1 = new HomePage();
            hp1.Show();


        }

        private void HeadquarterPage_Load(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string load = "SELECT * FROM LoginToSystem ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 350;
                dataGridView1.Columns[3].Width = 350;
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.Columns[5].Width = 200;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 250;
                dataGridView1.Columns[8].Width = 150;
                dataGridView1.Columns[9].Width = 500;
                conn2.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the data table" + ex);
            }
            finally
            {
                conn2.Close();
            }

            try
            {
                conn2.Open();
                DataSet ds = new DataSet();
                string product_id = "SELECT User_ID FROM LoginToSystem ";
                SqlDataAdapter sda = new SqlDataAdapter(product_id, conn2);
                sda.Fill(ds);
                cmbBoxUserDataID.DataSource = ds.Tables[0];
                cmbBoxUserDataID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in User_Data_ID" + ex);
            }
            finally
            {
                conn2.Close();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                String quarry = "INSERT INTO LoginToSystem (UserID, UserPassword, UserName, UserSurname, UserAddress, UserPhoneNumber, UserDateOfBirth, UserGender, UserEmail, UserType) VALUES ('"+txtCreateUserID.Text+"', '"+txtCreatePassword.Text+"', '"+txtCreateName.Text+"', '"+txtCreateSurname.Text+"', '"+rchtxtCreateAddress.Text+"', '"+txtCreatePhoneNumber.Text+ "', '"+Convert.ToDateTime(mtxtCreateDateOfBirth.Text).ToString("yyyy-MM-dd")+"', '" + (radiobtnCreateMale.Checked ? radiobtnCreateMale.Text : radiobtnCreateFemale.Text)+"', '"+txtCreateEmail.Text+"', '"+cmbBoxCreateType.SelectedItem.ToString()+"')";
                SqlDataAdapter SDA = new SqlDataAdapter(quarry, conn2);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Succesfull.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn2.Close();
            }

            try
            {
                conn2.Open();
                string load = "SELECT * FROM LoginToSystem ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 350;
                dataGridView1.Columns[3].Width = 350;
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.Columns[5].Width = 200;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 250;
                dataGridView1.Columns[8].Width = 150;
                dataGridView1.Columns[9].Width = 500;
                conn2.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the data table" + ex);
            }
            finally
            {
                conn2.Close();
            }
        }

        private void cmbBoxCreateType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateShow_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string load = "SELECT * FROM LoginToSystem ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 350;
                dataGridView1.Columns[3].Width = 350;
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.Columns[5].Width = 200;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 250;
                dataGridView1.Columns[8].Width = 150;
                dataGridView1.Columns[9].Width = 500;
                conn2.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the data table" + ex);
            }
            finally
            {
                conn2.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateStocks_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewStocks vsks = new ViewStocks();
            vsks.Show();
        }

        private void btnSportingGoodsPage_Click(object sender, EventArgs e)
        {
            this.Close();
            SportingGoods sgg = new SportingGoods();
            sgg.Show();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string query1 = "UPDATE LoginToSystem SET UserID = '" +txtCreateUserID.Text +  "', UserPassword = '" + txtCreatePassword.Text + "', UserName = '" + txtCreateName.Text + "', UserSurname = '" + txtCreateSurname.Text + "', UserAddress = '" + rchtxtCreateAddress.Text + "', UserPhoneNumber = '" + txtCreatePhoneNumber.Text + "', UserDateOfBirth = '" + Convert.ToDateTime(mtxtCreateDateOfBirth.Text).ToString("yyyy-MM-dd") + "', UserGender = '" + (radiobtnCreateMale.Checked ? radiobtnCreateMale.Text : radiobtnCreateFemale.Text) + "', UserEmail = '" + txtCreateEmail.Text + "', UserType = '" + cmbBoxCreateType.SelectedItem.ToString() + "' WHERE User_ID = '" + cmbBoxUserDataID.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, conn2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Update Button: " + ex.Message);
            }
            finally
            {
                conn2.Close();
            }

            try
            {
                conn2.Open();
                string load = "SELECT * FROM LoginToSystem ";
                SqlDataAdapter sda = new SqlDataAdapter(load, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 350;
                dataGridView1.Columns[3].Width = 350;
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.Columns[5].Width = 200;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 250;
                dataGridView1.Columns[8].Width = 150;
                dataGridView1.Columns[9].Width = 500;
                conn2.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the data table" + ex);
            }
            finally
            {
                conn2.Close();
            }
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewStocks vsks = new ViewStocks();
            vsks.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SportingGoods sgg = new SportingGoods();
            sgg.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void checkOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            WarehouseCheckOrders whc1 = new WarehouseCheckOrders();
            whc1.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse whs = new Warehouse();
            whs.Show();
            this.Hide();
        }
    }
}

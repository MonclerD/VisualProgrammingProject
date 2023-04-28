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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnBackFromHomepage_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginToSystem lts = new LoginToSystem();
            lts.Show();


        }

        private void btnEnterHeadquarter_Click(object sender, EventArgs e)
        {
           
            String headquarteruser;

            headquarteruser = txtHeadquarter.Text;

            try
            {
                String querry1 = "SELECT * FROM HeadquarterUser WHERE HeadquarterUserId = '"+txtHeadquarter.Text+"'";
                SqlDataAdapter sda1 = new SqlDataAdapter(querry1, conn1);

                DataTable dtable1 = new DataTable();
                sda1.Fill(dtable1);

                if (dtable1.Rows.Count > 0)
                {
                    headquarteruser = txtHeadquarter.Text;


                    //page that need to be load next
                    HeadquarterPage hqp = new HeadquarterPage();
                    hqp.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid UserID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeadquarter.Clear();

                    //to focus userid
                    txtHeadquarter.Focus();
                }



            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn1.Close();
            }
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEnterFactory_Click(object sender, EventArgs e)
        {
            String factoryuser;

            factoryuser = txtFactory.Text;

            try
            {
                String querry1 = "SELECT * FROM FactoryUser WHERE FactoryUserId = '" + txtFactory.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(querry1, conn1);

                DataTable dtable1 = new DataTable();
                sda1.Fill(dtable1);

                if (dtable1.Rows.Count > 0)
                {
                    factoryuser = txtFactory.Text;


                    //page that need to be load next
                    Factory fty = new Factory();
                    fty.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid UserID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFactory.Clear();

                    //to focus userid
                    txtFactory.Focus();
                }



            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn1.Close();
            }
        }

        private void btnEnterWarehouse_Click(object sender, EventArgs e)
        {
            String warehouseuser;

            warehouseuser = txtWarehouse.Text;

            try
            {
                String querry1 = "SELECT * FROM WarehouseUser WHERE WarehouseUserId = '" + txtWarehouse.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(querry1, conn1);

                DataTable dtable1 = new DataTable();
                sda1.Fill(dtable1);

                if (dtable1.Rows.Count > 0)
                {
                    warehouseuser = txtWarehouse.Text;


                    //page that need to be load next
                    Warehouse whs = new Warehouse();
                    whs.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid UserID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWarehouse.Clear();

                    //to focus userid
                    txtWarehouse.Focus();
                }



            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn1.Close();
            }
        }

        private void btnEnterClient_Click(object sender, EventArgs e)
        {
            String clientuser;

            clientuser = txtClient.Text;

            try
            {
                String querry1 = "SELECT * FROM ClientUser WHERE ClientUserId = '" + txtClient.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(querry1, conn1);

                DataTable dtable1 = new DataTable();
                sda1.Fill(dtable1);

                if (dtable1.Rows.Count > 0)
                {
                    clientuser = txtClient.Text;


                    //page that need to be load next
                    Client clnt = new Client();
                    clnt.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid UserID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClient.Clear();

                    //to focus userid
                    txtClient.Focus();
                }



            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn1.Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are experiencing problems with entering your department, \n please contact Wilson Sporting Goods IT team.");
        }

        private void contactInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContectUsWilson cnt = new ContectUsWilson();
            cnt.Show();
        }

        private void wilsonSportingGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeAreWilson waw = new WeAreWilson();
            waw.Show();
        }

        private void patentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patents ptn = new Patents();
            ptn.Show();
        }

        private void amerSportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Amer_Sports ass = new Amer_Sports();
            ass.Show();

            

        }
    }
}

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
    public partial class WarehouseCheckOrders : Form
    {
        public WarehouseCheckOrders()
        {
            InitializeComponent();
        }

        

        private void btnBackToWarehouseHomepage_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Warehouse wh1 = new Warehouse();
            wh1.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WarehouseCheckOrders_Load(object sender, EventArgs e)
        {
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
                dataGridOrdersWarehouse.DataSource = dt1;
                dataGridOrdersWarehouse.Columns[0].Width = 100;
                dataGridOrdersWarehouse.Columns[1].Width = 300;
                dataGridOrdersWarehouse.Columns[2].Width = 200;
                dataGridOrdersWarehouse.Columns[3].Width = 250;
                dataGridOrdersWarehouse.Columns[4].Width = 400;
                dataGridOrdersWarehouse.Columns[5].Width = 100;
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
        }

        private void btnGoToShipping_Click(object sender, EventArgs e)
        {
            this.Close();
            ExpeditionInformation Ei1 = new ExpeditionInformation();
            Ei1.Show();
        }
    }
}

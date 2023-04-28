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
    public partial class SportingGoods : Form
    {
        public SportingGoods()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToHeadquarterPage_Click(object sender, EventArgs e)
        {
            this.Close();
            HeadquarterPage hqp2 = new HeadquarterPage();
            hqp2.Show();
        }

        private void SportingGoods_Load(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True";

            DataTable dt1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT RacketSerialNumber, RacketModel, RacketPriceDolar, RacketQuantity FROM Racket", @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
            adapter1.Fill(dt1);
            dataGridRacket.DataSource = dt1;

            dataGridRacket.Columns[0].Width = 125;
            dataGridRacket.Columns[1].Width = 525;
            dataGridRacket.Columns[2].Width = 200;
            dataGridRacket.Columns[3].Width = 200;



            DataTable dt2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT StringSerialNumber, StringModel, StringPriceDolar, StringQuantity FROM String", @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
            adapter1.Fill(dt2);
            dataGridString.DataSource = dt2;

            dataGridString.Columns[0].Width = 125;
            dataGridString.Columns[1].Width = 525;
            dataGridString.Columns[2].Width = 200;
            dataGridString.Columns[3].Width = 200;

            DataTable dt3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT RacketGripSerialNumber, RacketGripModel, RacketGripPriceDolar, RacketGripQuantity FROM RacketGrip", @"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");
            adapter1.Fill(dt3);
            dataGridRacketGrip.DataSource = dt3;

            dataGridRacketGrip.Columns[0].Width = 125;
            dataGridRacketGrip.Columns[1].Width = 425;
            dataGridRacketGrip.Columns[2].Width = 200;
            dataGridRacketGrip.Columns[3].Width = 200;




        }
    }
}

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
    public partial class LoginToSystem : Form
    {
        public LoginToSystem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QNGM232\SQLEXPRESS;Initial Catalog=WilsonSportingGoods;Integrated Security=True");

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String userid, userpassword;

            userid = txtUserID.Text;
            userpassword = txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM LoginToSystem WHERE UserId = '"+txtUserID.Text+"' AND UserPassword = '"+txtPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    userid = txtUserID.Text;
                    userpassword = txtPassword.Text;

                    //page that need to be load next
                    HomePage hp = new HomePage();
                    hp.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid UserID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Clear();
                    txtPassword.Clear();

                    //to focus userid
                    txtUserID.Focus();
                }
                  


            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

            
        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblUserId_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPassword.Clear();

            txtUserID.Focus();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUserID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

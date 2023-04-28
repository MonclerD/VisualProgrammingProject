using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermProject
{
    public partial class ContectUsWilson : Form
    {
        public ContectUsWilson()
        {
            InitializeComponent();
        }

        private void lblEmailInfo_Click(object sender, EventArgs e)
        {
            lblEmailInfo.Text = "supportWilson@wilson.com";
        }

        private void lblPhoneInfo_Click(object sender, EventArgs e)
        {
            lblPhoneInfo.Text = "To reach out to us, please call Tel:+1-800-401-7967. \n Our hours are 8:00 AM – 5:00 PM CST, Monday – Friday.";
        }

        private void linklblWilsonWebPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wilson.com/en-us");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

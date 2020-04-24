using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Log_o_Base
{
    public partial class LoginScreen : UserControl
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        string conString = @"Data Source=ANTHONY\SHARPSQL;Initial Catalog=test;Integrated Security=True";
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }
        }

        private void txtPasswordEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPasswordLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void loginBttn_Click(object sender, EventArgs e)
        {
            con.Open();
            //com = new SqlCommand("")
        }
    }
}

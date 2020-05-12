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
        
        public LoginScreen()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=ANTHONY\SHARPSQL;Initial Catalog=LogBase;Integrated Security=True";
            loginBttn.Show();
            txtUsername.Show();
            txtPassword.Show();
            pictureBox1.Show();
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
            if (txtPassword.Text.Equals(@"Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPasswordLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = @"Password";
            }
        }

        private void loginBttn_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from [tbUser]";
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                if (txtUsername.Text.Equals(dr["Username"].ToString()) && txtPassword.Text.Equals(dr["Password"].ToString()))
                {
                    MessageBox.Show("Login Successfully", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
                    // Does not Work with "User Control" need to create new window
                    AddReceipt recRec = new AddReceipt();
                    recRec.Show();
                    recRec.BringToFront();
                    
                }
                else
                {
                    MessageBox.Show("Either your username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
            Clear();
            
        }
        //Clear the Register
        void Clear()
        {
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
        }
    }
}

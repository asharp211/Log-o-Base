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
    public partial class registerScreen : UserControl
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        string connString = @"Data Source=ANTHONY\SHARPSQL;Initial Catalog=LogBase;Integrated Security=True";
        
        public registerScreen()
        {
            InitializeComponent();
        }       

        private void txtFirstName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void mName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtStreet_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void charZipCode_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAccount_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAccount.Text=="" || txtNewPassword.Text=="" )
            {
                MessageBox.Show("Please fill out the mandatory box");
            }
            else
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    com = new SqlCommand("UserAdd", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    com.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    com.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    com.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                    com.Parameters.AddWithValue("@ZipCode", charZipCode.Text.Trim());
                    com.Parameters.AddWithValue("@PhoneNumber", charPhoneNumber.Text.Trim());
                    com.Parameters.AddWithValue("@Username", txtAccount.Text.Trim());
                    com.Parameters.AddWithValue("@Password", txtNewPassword.Text.Trim());
                    MessageBox.Show("Registration is successfull");
                    com.ExecuteNonQuery();
              
                    Clear();
                }
            }
        }

        //Clear the Register
        void Clear()
        {
            txtFirstName.Text = "First Name";
            txtLastName.Text = "Last Name";
            txtAddress.Text = "Address";
            txtCity.Text = "City";
            charZipCode.Text = "Zip Code";
            charPhoneNumber.Text = "Phone #";
            txtAccount.Text = "Account ID / Email";
            txtNewPassword.Text = "Password";
        }

        public static void main(string[] args)
        {
            Application.Run(new Main());
        }


        private void CloseBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFirstNameEnter(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(@"First Name"))
            {
                txtFirstName.Text = "";
            }
        }

        private void txtFirstNameLeave(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(""))
            {
                txtFirstName.Text = @"First Name";
            }
        }
        

        private void txtLstNameEnter(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals(@"Last Name"))
            {
                txtLastName.Text = "";
            }
        }

        private void txtLstNameLeave(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals(""))
            {
                txtLastName.Text = @"Last Name";
            }
        }

        private void txtAddressEnter(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals(@"Address"))
            {
                txtAddress.Text = "";
            }
        }

        private void txtAddressLeave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals(""))
            {
                txtAddress.Text = @"Address";
            }
        }

        private void txtCityEnter(object sender, EventArgs e)
        {
            if (txtCity.Text.Equals(@"City"))
            {
                txtCity.Text = "";
            }
        }

        private void txtCityLeave(object sender, EventArgs e)
        {
            if (txtCity.Text.Equals(""))
            {
                txtCity.Text = @"City";
            }
        }

        private void txtZipEnter(object sender, EventArgs e)
        {
            if (charZipCode.Text.Equals(@"Zip Code"))
            {
                charZipCode.Text = "";
            }
        }

        private void txtZipLeave(object sender, EventArgs e)
        {
            if (charZipCode.Text.Equals(""))
            {
                charZipCode.Text = @"Zip Code";
            }
        }

        private void txtPhoneEnter(object sender, EventArgs e)
        {
            if (charPhoneNumber.Text.Equals(@"Phone #"))
            {
                charPhoneNumber.Text = "";
            }
        }

        private void txtPhoneLeave(object sender, EventArgs e)
        {
            if (charPhoneNumber.Text.Equals(""))
            {
                charPhoneNumber.Text = @"Phone #";
            }
        }

        private void txtAccIDEnter(object sender, EventArgs e)
        {
            if (txtAccount.Text.Equals(@"Account ID / Email"))
            {
                txtAccount.Text = "";
            }
        }

        private void txtAccIDLeave(object sender, EventArgs e)
        {
            if (txtAccount.Text.Equals(""))
            {
                txtAccount.Text = @"Account ID / Email";
            }
        }

        private void txtPassword1Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Equals(@"Password"))
            {
                txtNewPassword.Text = "";
            }
        }

        private void txtPassword1Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Equals(""))
            {
                txtNewPassword.Text = @"Password";
            }
        }
    }
}

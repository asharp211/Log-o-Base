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

namespace Log_o_Base
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            loginScreen1.Hide();
            registerScreen1.Hide();
            aboutScreen1.Hide();
        }

        //  Home Screen
        private void HomeButton_Click(object sender, EventArgs e)
        {
            //homeScreen1.BringToFront();
            button1.Show();
            button2.Show();
            ActiveUser.Show();
            label2.Show();
            label3.Show();
            loginScreen1.Hide();
            registerScreen1.Hide();
            aboutScreen1.Hide();


        }
        private void homeScreen1_Load(object sender, EventArgs e)
        {
            
            //registerScreen1.BringToFront();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
           aboutScreen1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginScreen1.Show();
            button1.Hide();
            button2.Hide();
            ActiveUser.Hide();
            label2.Hide();
            label3.Hide();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerScreen1.Show();
            loginScreen1.Hide();
            button1.Hide();
            button2.Hide();
            ActiveUser.Hide();
            label2.Hide();
            label3.Hide();
        }

        private void ActiveUser_Click(object sender, EventArgs e)
        {
            //
        }

        private void loginScreen1_Load(object sender, EventArgs e)
        {

        }
        
        private void registerScreen1_Load_2(object sender, EventArgs e)
        {
            //registerScreen1.Show();
            //loginScreen1.Hide();
            //button1.Hide();
            //button2.Hide();
            //ActiveUser.Hide();
            //label2.Hide();
            //label3.Hide();
        }
        
    }
}

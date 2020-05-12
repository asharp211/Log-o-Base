using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //  This is what connects to the database

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
            viewData1.Hide();
            activerUser1.Hide();

        }

        //  Home Screen 
        //  Display the home menu
        private void HomeButton_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            label2.Show();
            label3.Show();
            loginScreen1.Hide();
            registerScreen1.Hide();
            aboutScreen1.Hide();
            viewData1.Hide();
            activerUser1.Hide();


        }

        //  About Button    -> Send to the About User control page
        //  Discribe what the project is about
        private void AboutButton_Click(object sender, EventArgs e)
        {
            aboutScreen1.Show();
            aboutScreen1.BringToFront();
            loginScreen1.Hide();
            button1.Hide();
            button2.Hide();            
            label2.Hide();
            label3.Hide();
            viewData1.Hide();
            activerUser1.Hide();
        }

        //  Login Button    ->  Send to the Login User Control page
        //  Login to the database to edit, insert, and delete
        private void button1_Click(object sender, EventArgs e)
        {            
            loginScreen1.Show();
            loginScreen1.BringToFront();
            button1.Hide();
            button2.Hide();
            label2.Hide();
            label3.Hide();
            viewData1.Hide();
            activerUser1.Hide();

        }

        //  SignUp a new User   -> Connect to the Register User
        //  SignUp create new user and have them say what they want
        private void button2_Click(object sender, EventArgs e)
        {
            registerScreen1.Show();
            loginScreen1.Hide();
            button1.Hide();
            button2.Hide();
            label2.Hide();
            label3.Hide();
            viewData1.Hide();
            activerUser1.Hide();
        }
        //  Accedent click 
        private void registerScreen1_Load_2(object sender, EventArgs e)
        {

        }

        //  Record the transaction  -> Connect to the Database to login all the transaction of an item we collected
        //  
        private void Record_Click(object sender, EventArgs e)
        {
            viewData1.Show();
            viewData1.BringToFront();
            aboutScreen1.Hide();
            loginScreen1.Hide();
            button1.Hide();
            button2.Hide();
            label2.Hide();
            label3.Hide();
            activerUser1.Hide();
        }
        
    }
}

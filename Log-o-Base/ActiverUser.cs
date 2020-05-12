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
    public partial class ActiverUser : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ANTHONY\SHARPSQL;Initial Catalog=LogBase;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        public ActiverUser()
        {
            InitializeComponent();
        }
        void FillDataGridView()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("UserVieworSearch", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@Username");
            DataTable dtdl = new DataTable();
            sda.Fill(dtdl);
            dataGridView1.DataSource = dtdl;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDataGridView();
        }
    }
}

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
    public partial class ViewData : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ANTHONY\SHARPSQL;Initial Catalog=LogBase;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        public ViewData()
        {
            InitializeComponent();
            this.Refresh();
        }
        
        void FillDataGridView()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("ReceiptVieworSearch", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Transaction_ID", txtSearch.Text.Trim());
            DataTable dtdl = new DataTable();
            sda.Fill(dtdl);
            dataGridView1.DataSource = dtdl;
            con.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

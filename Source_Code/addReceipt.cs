using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Log_o_Base
{
    public partial class AddReceipt : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ANTHONY\SHARPSQL;Initial Catalog=LogBase;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        public AddReceipt()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                com = new SqlCommand(@"INSERT INTO dbReceipt (Transaction_ID,Date,ItenNumber, ItemName, Price, Quantity, MethodOfPay, Total) VALUES ('"
                                    + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','"
                                    + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','"
                                    + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            dataGridView1.Rows.Clear();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}

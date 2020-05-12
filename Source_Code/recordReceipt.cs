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
using System.Configuration;

namespace Log_o_Base
{
    public partial class recordReceipt : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ANTHONY\SHARPSQL;Initial Catalog=LogBase;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        DataTable dt = new DataTable();
        DataRow dr;

        int order = 1;
        double total = 0.0;


        public recordReceipt()
        {
            InitializeComponent();
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                Receipt obj = new Receipt()
                {
                    Item_Id = order++,
                    ProductName = txtProductName.Text,
                    Price = Convert.ToDouble(txtPrice.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text)
                };
                total += obj.Price * obj.Quantity;
                receiptBindingSource.Add(obj);
                receiptBindingSource.MoveLast();
                //txtProductName.Text = string.Empty;
               // txtPrice.Text = string.Empty;
               // txtTotal.Text = string.Format("${0}", total);

            }
        }

        private void recordReceipt_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new List<Receipt>();  // Init emtpy list
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Receipt obj = receiptBindingSource.Current as Receipt;
            if(obj != null)
            {
                total -= obj.Price * obj.Quantity;
                txtTotal.Text = string.Format("${0}", total);
            }
            receiptBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                com = new SqlCommand(@"INSERT INTO tbReceipt ([Transaction],Date,ItemNumber, Item_Name, Price, Quantity, MethodOfPay, Total) VALUES ('"
                                    + dataGridView.Rows[i].Cells[0].Value + "','" + dataGridView.Rows[i].Cells[1].Value + "','" + dataGridView.Rows[i].Cells[3].Value
                                    + "','" + dataGridView.Rows[i].Cells[4].Value + "','" + dataGridView.Rows[i].Cells[5].Value + "','"
                                    + dataGridView.Rows[i].Cells[6].Value + dataGridView.Rows[i].Cells[7].Value + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            dataGridView.Rows.Clear();


                //double total = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                //txtTotal.Text = string.Format("${0}", total);
                //try
                //{
                //    if(con.State == ConnectionState.Closed)
                //    {
                //        con.Open();
                //        com = new SqlCommand("ReceiptAddOrEdit", con);
                //        com.CommandType = CommandType.StoredProcedure;
                //        com.Parameters.AddWithValue("@mode", "Add");
                //        com.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                //        com.Parameters.AddWithValue("@Price", Convert.ToDouble(txtPrice.Text));
                //        com.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                //        com.Parameters.AddWithValue("@Total", txtTotal.Text.Trim());
                //        com.ExecuteNonQuery();
                //    }
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Error Message");
                //}
                //*************************************************************************
                //con.Open();
                //com = new SqlCommand("Receipt", con);
                //com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                //com.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                //com.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim());
                //com.Parameters.AddWithValue("@Total", txtTotal.Text.Trim());
                //com.ExecuteNonQuery();

            }
    }
}

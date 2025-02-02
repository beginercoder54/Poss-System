﻿using hu;
using spoil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poss_System
{
    public partial class FrmStatistics : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        int index=-1;
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
           loadData();
        }

        public void loadData()
        {
            connect.Open();
            DateTime ngay = dtpDate.Value;
            DateTime thang = dtpDate.Value;
            DateTime nam = dtpDate.Value;
            SqlCommand cmd = new SqlCommand("select BillID,username,CheckOut,TotalPrice from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null group by BillID,username,CheckOut,TotalPrice order by 1 ", connect);
            cmd.Parameters.AddWithValue("@CheckOutday",ngay.Day);
            cmd.Parameters.AddWithValue("@CheckOutmonth", thang.Month);
            cmd.Parameters.AddWithValue("@CheckOutyear", nam.Year);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

           
            dataGridView1.DataSource = dt;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                SqlCommand sql = new SqlCommand("select Status from Orders where BillID = @BillID",connect);
                sql.Parameters.AddWithValue("@BillID", Convert.ToInt32(item.Cells[0].Value.ToString()));
                int color = (int)sql.ExecuteScalar();
                if(color == 2)
                {
                    item.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            connect.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBill.Text = txtAccount.Text = "";
            loadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBill.Text=="" && txtAccount.Text=="")
            {
                MessageBox.Show("Input value to search","Notiffication",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (txtAccount.Text!=""&&txtBill.Text=="")
                {
                    DateTime ngay = dtpDate.Value;
                    DateTime thang = dtpDate.Value;
                    DateTime nam = dtpDate.Value;
                    SqlCommand cmd = new SqlCommand("select BillID,username,CheckOut,TotalPrice from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and username='"+txtAccount.Text+"' group by BillID,username,CheckOut,TotalPrice order by 1 ", connect);
                    cmd.Parameters.AddWithValue("@CheckOutday", ngay.Day);
                    cmd.Parameters.AddWithValue("@CheckOutmonth", thang.Month);
                    cmd.Parameters.AddWithValue("@CheckOutyear", nam.Year);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (txtAccount.Text == "" && txtBill.Text != "")
                {
                    DateTime ngay = dtpDate.Value;
                    DateTime thang = dtpDate.Value;
                    DateTime nam = dtpDate.Value;
                    SqlCommand cmd = new SqlCommand("select BillID,username,CheckOut,TotalPrice from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and BillID='" + txtBill.Text+"' group by BillID,username,CheckOut,TotalPrice order by 1 ", connect);
                    cmd.Parameters.AddWithValue("@CheckOutday", ngay.Day);
                    cmd.Parameters.AddWithValue("@CheckOutmonth", thang.Month);
                    cmd.Parameters.AddWithValue("@CheckOutyear", nam.Year);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (txtAccount.Text != "" && txtBill.Text != "")
                {
                    DateTime ngay = dtpDate.Value;
                    DateTime thang = dtpDate.Value;
                    DateTime nam = dtpDate.Value;
                    SqlCommand cmd = new SqlCommand("select BillID,username,CheckOut,TotalPrice from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and username='" + txtAccount.Text+ "' and BillID='" + txtBill.Text+"' group by BillID,username,CheckOut,TotalPrice order by 1 ", connect);
                    cmd.Parameters.AddWithValue("@CheckOutday", ngay.Day);
                    cmd.Parameters.AddWithValue("@CheckOutmonth", thang.Month);
                    cmd.Parameters.AddWithValue("@CheckOutyear", nam.Year);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (index>=0)
            {
                FrmDel frmDel = new FrmDel();
                frmDel.getidtable(Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString()));
                frmDel.getngaythang(Convert.ToDateTime(dataGridView1.Rows[index].Cells[2].Value.ToString()));
                frmDel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select bill for delete", "Notiffication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index= e.RowIndex;
        }

        private void btnReveunue_Click(object sender, EventArgs e)
        {
          
                FrmSales frmSales = new FrmSales((DateTime)dtpDate.Value);
                frmSales.Show();
           
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                DateTime dgvdate = (DateTime)dataGridView1.Rows[index].Cells[2].Value;
                connect.Open();
                SqlCommand cmd2 = new SqlCommand("select BillID,username,CheckOut,ISNULL(tableID, 0) as tableID from Orders where BillID=@BIllID and  day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null  group by BillID,username,CheckOut,ISNULL(tableID, 0) ", connect);
                cmd2.Parameters.AddWithValue("@BillID", Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString()));
                cmd2.Parameters.AddWithValue("@CheckOutday", dgvdate.Day);
                cmd2.Parameters.AddWithValue("@CheckOutmonth", dgvdate.Month);
                cmd2.Parameters.AddWithValue("@CheckOutyear", dgvdate.Year);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(dt2);
                FrmReceipt frmReceipt = new FrmReceipt(dt2.Rows[0]["BillID"].ToString(), dt2.Rows[0]["username"].ToString(), dgvdate, dt2.Rows[0]["tableID"].ToString());
                frmReceipt.Show();
                connect.Close();

            }
            else
            {
                MessageBox.Show("Select order to see details","Notiffication",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FrmExport frmExport = new FrmExport();
            frmExport.ShowDialog();
        }
    }
}

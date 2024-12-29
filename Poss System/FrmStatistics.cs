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
    }
}

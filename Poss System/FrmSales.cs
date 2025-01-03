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
    public partial class FrmSales : Form
    {
        private bool isMouseDown = false;
        private Point lastLocation;
        DateTime date;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmSales()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select fID ,fName,SUM(Quantity) AS Quantity from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and Status =1 group by fID,fName", connect);
            cmd.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd.Parameters.AddWithValue("@CheckOutyear", date.Year);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("select ISNULL(COUNT(distinct BillID),0) from Orders  where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and Status in (1,null) ", connect);
            cmd2.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd2.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd2.Parameters.AddWithValue("@CheckOutyear", date.Year);
            int numorders = (int)cmd2.ExecuteScalar();
            lblTotalOrders.Text = numorders.ToString();

            SqlCommand cmd3 = new SqlCommand("select ISNULL(sum(distinct TotalPrice),0) from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and Status =1", connect);
            cmd3.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd3.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd3.Parameters.AddWithValue("@CheckOutyear", date.Year);
            decimal totalrevenue = (decimal)cmd3.ExecuteScalar();
            lblTotalRevenue.Text = totalrevenue.ToString();


            SqlCommand cmd4 = new SqlCommand("select BillID,CheckOut,TotalPrice from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and Status=2 group by BillID,CheckOut,TotalPrice", connect);
            cmd4.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd4.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd4.Parameters.AddWithValue("@CheckOutyear", date.Year);
            DataTable dt2 = new DataTable();
            SqlDataAdapter sqldataadapter1 = new SqlDataAdapter(cmd4);
            sqldataadapter1.Fill(dt2);
            dataGridView2.DataSource = dt2;
           


            SqlCommand cmd5 = new SqlCommand("select ISNULL(COUNT(distinct BillID),0) from Orders  where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and Status = 2 ", connect);
            cmd5.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd5.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd5.Parameters.AddWithValue("@CheckOutyear", date.Year);
            int canceledorders = (int)cmd5.ExecuteScalar(); 
            lblNcancel.Text= canceledorders.ToString();


            SqlCommand cmd6 = new SqlCommand("select ISNULL(sum(distinct TotalPrice),0) from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null and Status = 2", connect);
            cmd6.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd6.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd6.Parameters.AddWithValue("@CheckOutyear", date.Year);
            decimal totalcancel = (decimal)cmd6.ExecuteScalar();
           lblTCancel.Text = totalcancel.ToString();
            connect.Close();

            SqlCommand cmd7 = new SqlCommand("select o.Quantity*p.purchasePrice  from Orders o ,Product p where o.fID = p.productID and (Status in (1,null)) and day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null group by o.fID,o.fName,o.Quantity*p.purchasePrice ", connect);
            cmd7.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd7.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd7.Parameters.AddWithValue("@CheckOutyear", date.Year);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd7);
            da4.Fill(dt3);
            decimal profit = 0;
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                profit += Convert.ToDecimal(dt3.Rows[i][0]);
            }
            decimal a = totalrevenue - profit;
            lblTakeProgit.Text = a.ToString();

        }

        public FrmSales(DateTime datetime)
        {
            InitializeComponent();
            date = datetime;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                lastLocation = e.Location; // Lưu vị trí chuột
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                // Tính toán sự dịch chuyển của form
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;
                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false; // Kết thúc kéo chuột
        }
    }
}

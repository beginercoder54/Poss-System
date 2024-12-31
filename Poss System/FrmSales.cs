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
            SqlCommand cmd = new SqlCommand("select fID ,fName,SUM(Quantity) AS Quantity from Orders where day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null group by fID,fName", connect);
            cmd.Parameters.AddWithValue("@CheckOutday", date.Day);
            cmd.Parameters.AddWithValue("@CheckOutmonth", date.Month);
            cmd.Parameters.AddWithValue("@CheckOutyear", date.Year);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

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

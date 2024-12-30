using Poss_System;
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

namespace hu
{
    public partial class FrmDel : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        FrmStatistics statistics = new FrmStatistics();
        int ID;
        DateTime ngaythang;
        public FrmDel()
        {
            InitializeComponent();
        }

  

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from Account WHERE upass= '" +txtPass.Text + "'", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            if (dt.Rows.Count >= 0)
            {
                SqlCommand sqlcmd = new SqlCommand("update Orders set Status = 2 where BillID = @BillID and day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null", connect);
                sqlcmd.Parameters.AddWithValue("@BillID", ID);
                sqlcmd.Parameters.AddWithValue("@CheckOutday", ngaythang.Day);
                sqlcmd.Parameters.AddWithValue("@CheckOutmonth", ngaythang.Month);
                sqlcmd.Parameters.AddWithValue("@CheckOutyear", ngaythang.Year);
                sqlcmd.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                {
                    MessageBox.Show("Password is wrong", "Notiffication", MessageBoxButtons.OK);
                }
            }
            connect.Close();
        }
        public void getidtable(int id)
        {
            ID = id;
        }
        public void getngaythang(DateTime dt) {
            ngaythang = dt;
        }
    }
}

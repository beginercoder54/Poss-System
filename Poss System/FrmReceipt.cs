using Poss_System.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poss_System
{
    public partial class FrmReceipt : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        string BillID;
        string username;
        DateTime Checkout;
        string tableID;
        public FrmReceipt()
        {
            InitializeComponent();
        }

        public FrmReceipt(string BillID , string username,DateTime Checkout,string TableID )
        {

            InitializeComponent();
            this.BillID = BillID;
            this.username = username;
            this.Checkout = Checkout;
            this.tableID = TableID;
        }
        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            lblBillID.Text = BillID;
            lblDate.Text = Checkout.ToString();
            if(tableID == "0") { lblTable.Text = "Take away"; } else lblTable.Text= tableID;
            lblUserName.Text = username;

            SqlCommand cmd = new SqlCommand("select Quantity,fName,FoodPrice,TotalPrice from Orders where  BillID=@BIllID and  day(CheckOut)=@CheckOutday and month(CheckOut)=@CheckOutmonth and year(CheckOut)=@CheckOutyear and CheckOut is not null", connect);
            cmd.Parameters.AddWithValue("@BillID", BillID);
            cmd.Parameters.AddWithValue("@CheckOutday", Checkout.Day);
            cmd.Parameters.AddWithValue("@CheckOutmonth", Checkout.Month);
            cmd.Parameters.AddWithValue("@CheckOutyear", Checkout.Year);
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AddItem(dt.Rows[i]["Quantity"].ToString(), dt.Rows[i]["fName"].ToString(), dt.Rows[i]["FoodPrice"].ToString());
            }
            
            lblTotalPrice.Text = dt.Rows[0]["TotalPrice"].ToString();
        }

        public void AddItem(string quantity,string name , string price)
        {
            flowLayoutPanel1.Controls.Add(new InfoReceipt()
            {
                Quantity = quantity,
                NameF = name,
                Price = price
            });

        }
    }
}

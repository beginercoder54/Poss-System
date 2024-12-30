using hu;
using Poss_System.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Poss_System
{
    public partial class FrmMain : Form
    {
        int tableID;
        string username;
        int id;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmMain()
        {
            InitializeComponent();
        }
      

        private void pictureIconMenu_Click(object sender, EventArgs e)
        {
          
            if(pnlMenu.Visible == false)
            {
                pnlMenu.Visible = true;
            }
            else
            {
                pnlMenu.Visible = false;
            }
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.BackColor == Color.Green)
            {
                connect.Open();
                FrmOder frmOder = new FrmOder();
                tableID = Convert.ToInt32(clickedButton.Text);
                frmOder.getidtable(tableID);
                SqlCommand cmd = new SqlCommand("select BillID from Orders where tableID=@tableID",connect);
                cmd.Parameters.AddWithValue("@tableID", tableID);
                id = (int)cmd.ExecuteScalar();
                frmOder.getbillID(id);
                this.Close();
                frmOder.Show();
                frmOder.getName(username);
                connect.Close();
            }
            else
            {
                connect.Open();
                FrmOder frmOder = new FrmOder();
                tableID = Convert.ToInt32(clickedButton.Text);
                frmOder.getidtable(tableID);
                SqlCommand cmd = new SqlCommand("select ISNULL(MAX(BillID), 0) from Orders where YEAR(InsertBill) = YEAR(@InsertBill) and MONTH(InsertBill)=MONTH(@InsertBill) and DAY(InsertBill)=DAY(@InsertBill)", connect);
                cmd.Parameters.AddWithValue("@InsertBill", DateTime.Now);
                id = (int)cmd.ExecuteScalar();
                id += 1;
                frmOder.getbillID(id);
                this.Close();
                frmOder.Show();
                frmOder.getName(username);
                connect.Close();
            }
           
            
        }

        private void pnlTableMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmMain"] == Application.OpenForms[Application.OpenForms.Count - 1])
            {
                pnlMenu.Visible = false;
            }else
            {
                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.ShowDialog();
            }
        }

        private void pnlOrdersMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTW"] == Application.OpenForms[Application.OpenForms.Count - 1])
            {
                pnlMenu.Visible = false;
            }
            else
            {
                connect.Open();
                FrmTW frmTW = new FrmTW();
                SqlCommand cmd = new SqlCommand("select ISNULL(MAX(BillID), 0) from Orders where YEAR(InsertBill) = YEAR(@InsertBill) and MONTH(InsertBill)=MONTH(@InsertBill) and DAY(InsertBill)=DAY(@InsertBill)", connect);
                cmd.Parameters.AddWithValue("@InsertBill", DateTime.Now);
                id = (int)cmd.ExecuteScalar();
                id += 1;
                frmTW.getbillID(id);
                frmTW.getName(username);
                this.Hide();
                frmTW.Show();
                connect.Close();
            }
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }
        private void pnlSettingMenu_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            if (Application.OpenForms["FrmSetting"] == Application.OpenForms[Application.OpenForms.Count - 1])
            {
                pnlMenu.Visible = false;
            }
            else
            {
                if (frm.txtUsername.Text=="admin")
                {
                    FrmSetting frmSetting = new FrmSetting();
                    frmSetting.Show();
                }
                else
                {
                    FrmRQSetting frmRQSetting = new FrmRQSetting();
                    frmRQSetting.Show();
                }
               
            }
        }
        public void getName(string name)
        {
            username = name;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from MyTable",connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (Button btn in fpnlTable.Controls)
            {
                if (btn.Text == dt.Rows[Convert.ToInt32(btn.Text)-1]["tableID"].ToString()) 
                {
                    if (dt.Rows[Convert.ToInt32(btn.Text) - 1]["Status"].ToString()=="1")
                    {
                        btn.BackColor = Color.Green;
                    }
                }
            }
        }
    }
}

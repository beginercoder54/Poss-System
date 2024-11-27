using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Poss_System
{
    public partial class FrmLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-GI961I9;Initial Catalog=""POS System"";Integrated Security=True");
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (connect.State!= ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string ck_Username = "SELECT * FROM Account WHERE uname= '" + txtUsername.Text + "' and upass= '"+txtPassword.Text+"'";
                    SqlCommand cmd = new SqlCommand(ck_Username,connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        FrmMain frmMain = new FrmMain();
                        this.Hide();
                        frmMain.ShowDialog();
                    }
                    else
                    {
                        {
                            lblAlert.Text = "Username or Password is wrong";
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Loi ket noi database!!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text!="" )
            {
                lblAlert.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lblAlert.Text = "";
            }
           
        }
    }
}

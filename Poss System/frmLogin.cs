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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
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
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {



                    string ck_Username = "SELECT * FROM Account WHERE uname= '" + txtUsername.Text + "' and upass= '" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(ck_Username, connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        FrmMain frmMain = new FrmMain();
                        this.Hide();
                        frmMain.Show();
                        frmMain.getName(txtUsername.Text);
                    }
                    else
                    {
                        {
                            lblAlert.Text = "Username or Password is wrong";
                        }
                    }
                }
                else
                {
                    {
                        lblAlert.Text = "Username or Password is wrong";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Export fail !!\n" + ex.Message);
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

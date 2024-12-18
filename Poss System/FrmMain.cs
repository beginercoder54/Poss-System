using hu;
using Poss_System.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poss_System
{
    public partial class FrmMain : Form
    {
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
            FrmOder frmOder = new FrmOder();
            this.Hide();
            frmOder.Show();
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
                FrmTW frmTW = new FrmTW();
                this.Hide();
                frmTW.Show();
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

            if (Application.OpenForms["FrmSetting"] == Application.OpenForms[Application.OpenForms.Count - 1])
            {
                pnlMenu.Visible = false;
            }
            else
            {
                FrmRQSetting frmRQSetting = new FrmRQSetting();
                frmRQSetting.Show();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            connect.Open();
            SqlCommand cmd = new SqlCommand("select tableID from MyTable", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            for (int i=0;i<24;i++)
            {
                Button btn = new Button()
                {
                    Width = 330,
                    Height = 180,
                    BackgroundImage = Image.FromFile("C:\\Users\\hoang\\Source\\Repos\\Poss-System\\Poss System\\Resources\\Bàn.png"),
                    BackgroundImageLayout = ImageLayout.Zoom,
                    BackColor = Color.Gainsboro,
                };
                btn.Click += btnTable1_Click;
                fpnlTable.Controls.Add(btn);
            }
            connect.Close();
        }
      
    }
}

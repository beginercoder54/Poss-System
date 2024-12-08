using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poss_System
{
    public partial class FrmMain : Form
    {
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
            if (Application.OpenForms["FrmOder"] == Application.OpenForms[Application.OpenForms.Count - 1])
            {
                pnlMenu.Visible = false;
            }
            else
            {
                FrmOder frmOder = new FrmOder();
                this.Hide();
                frmOder.Show();
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
                FrmSetting frmSetting = new FrmSetting();  
                this.Hide();
                frmSetting.Show();
            }
        }
    }
}

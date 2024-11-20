﻿using System;
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
    public partial class FrmLogin : Form
    {
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
            if(txtUsername.Text=="admin" && txtPassword.Text == "123")
            {
                FrmMain frmMain= new FrmMain();
                this.Hide();
                frmMain.Show();
            }
            else
            {
                lblAlert = ShowDialog("Username or Password is wrong");
            }
        }
    }
}

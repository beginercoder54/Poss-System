﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poss_System.Component;
using static Poss_System.Component.Widget;

namespace Poss_System
{
    public partial class FrmTW : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmTW()
        {
            InitializeComponent();
        }

        private void pictureIconMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible == false)
            {
                pnlMenu.Visible = true;
            }
            else
            {
                pnlMenu.Visible = false;
            }
        }
        private void pnlTableMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmMain"] == Application.OpenForms[Application.OpenForms.Count - 1])
            {
                pnlMenu.Visible = false;
            }
            else
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
                FrmSetting frmSetting = new FrmSetting();
                frmSetting.Show();
            }
        }


        public void AddItem(String name,double cost, string categories,Image image )
        {
            var w =new Widget()
            {
                Title = name,
                Cost = cost,
                Category = categories,
                Icon = image,
                Tag = categories
            };
            flowLayoutPanel1.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                   
                    
                        if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                        {
                            item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                            item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblCost.Text));
                        CalculateTotal();
                            return;
                        }


                    

                }
                dataGridView1.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.Cost});
                CalculateTotal();
            };
        }

        public void CalculateTotal()
        {
            double total = 0;
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total += double.Parse(item.Cells[2].Value.ToString());
                }
                    
            }
            lblTotalPrice.Text = "$ "+ total.ToString();
        }

        private void FrmOder_Shown(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select productname,sellPrice, category, imgProduct from Product",connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int n = dt.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                string productName = dt.Rows[i]["productname"].ToString();
                double sellPrice = Convert.ToDouble((dt.Rows[i]["sellPrice"]));
                string category = dt.Rows[i]["category"].ToString();
                byte[] imgData = dt.Rows[i]["imgProduct"] as byte[];
                Image imgProduct = null;
                if (imgData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        imgProduct = Image.FromStream(ms);
                    }
                }
                AddItem(productName, sellPrice, category, imgProduct);
            }
            connect.Close();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length == 0)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    var wdg = (Widget)item;
                    wdg.Visible = wdg.lblTitle.Text.ToLower().Contains(txtSearch.Text.Trim().ToLower());
                }
            }
               
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllItems_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.Tag.ToString() != lblAllItems.Text.Trim();
            }
        }

        private void Desserts_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.Tag.ToString().ToUpper().Contains(lblDessert.Text.Trim().ToUpper  ());
            }
        }

        private void Alcohol_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.Tag.ToString().ToUpper().Contains(lblAlcohol.Text.Trim().ToUpper());
            }
        }

        private void Food_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.Tag.ToString().ToUpper().Contains(lblFood.Text.Trim().ToUpper());
            }
        }

        private void ColdDirnks_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.Tag.ToString().ToUpper().Contains(lblDrink.Text.Trim().ToUpper());
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
   
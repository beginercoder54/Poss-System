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

namespace Poss_System
{
    public partial class FrmProFileProducts : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmProFileProducts()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == ""|| txtName.Text == ""||txtPrice.Text == ""||txtPurchase.Text == ""||cbbCategory.Text == ""||pictureBox1.Image == null)
            {
                MessageBox.Show("Please enter the information.", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (Checkitem() == 0)
                {
                    byte[] data = ImageToByteArray(pictureBox1.Image);
                    connect.Open();
                    decimal sellPrice = decimal.Parse(txtPrice.Text);
                    decimal purchasePrice = decimal.Parse(txtPurchase.Text);
                    SqlCommand cmd = new SqlCommand("insert into Product values (@productID,@productname,@Category,@sellPricce,@purchasePrice,@imgProduct)", connect);
                    cmd.Parameters.AddWithValue("@productID", txtID.Text);
                    cmd.Parameters.AddWithValue("@productname", txtName.Text);
                    cmd.Parameters.AddWithValue("@Category", cbbCategory.Text);
                    cmd.Parameters.AddWithValue("@sellPricce", sellPrice);
                    cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                    cmd.Parameters.AddWithValue("@imgProduct", data);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Add new product success.", "Notification", MessageBoxButtons.OK);
                    txtID.Text = "";
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtPurchase.Text = "";
                    cbbCategory.Text = "";
                    pictureBox1.Image = null;
                }
                else
                    MessageBox.Show("Product is available","Notiffication",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
     
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public int Checkitem()
        {
            // Assuming FrmSetting is already open and accessible
            FrmSetting frmSetting = Application.OpenForms.OfType<FrmSetting>().FirstOrDefault();

            // Check if the form is null (not open)
            if (frmSetting == null)
            {
                MessageBox.Show("FrmSetting form is not open.");
                return 0; // No products to check
            }

            // Iterate through the rows in the DataGridView
            foreach (DataGridViewRow row in frmSetting.dgvProducts.Rows)
            {
                // Check if the value in the first cell is not null or empty before comparing
                var cellValue = row.Cells[0].Value?.ToString().Trim(); // Safe null check

                if (string.IsNullOrEmpty(cellValue))
                {
                    continue; // Skip rows with null or empty ID
                }

                // Compare the value from the text box to the cell value
                if (cellValue == txtID.Text.Trim())
                {
                    return 1; // Product ID exists, return 1 to indicate duplication
                }
            }

            return 0; // No matching product ID found
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMore frmMore = new FrmMore();
           
            frmMore.txtID.Text = txtID.Text;
            frmMore.txtName.Text = txtName.Text;
            frmMore.cbbCategory.Text = cbbCategory.Text;
            frmMore.txtPrice.Text = txtPrice.Text;
            frmMore.txtPurchase.Text = txtPurchase.Text;
            frmMore.pictureBox1.Image = pictureBox1.Image;
            this.Close();
            frmMore.Show();

        }
    }


}

using System;
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
    public partial class FrmUpdateProFile : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmUpdateProFile()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                byte[] data = ImageToByteArray(pictureBox1.Image);
                connect.Open();
                decimal sellPrice = decimal.Parse(txtPrice.Text);
                decimal purchasePrice = decimal.Parse(txtPurchase.Text);
                SqlCommand cmd = new SqlCommand("update  Product set  productID = @productID , productname = @productname ,category = @Category,sellPrice = @sellPricce,purchasePrice =@purchasePrice,imgProduct = @imgProduct where productID=@productID or productname= @productname", connect);
                cmd.Parameters.AddWithValue("productID", txtID.Text);
                cmd.Parameters.AddWithValue("productname", txtName.Text);
                cmd.Parameters.AddWithValue("Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("sellPricce", sellPrice);
                cmd.Parameters.AddWithValue("purchasePrice", purchasePrice);
                cmd.Parameters.AddWithValue("imgProduct", data);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Update new product success.", "Notification", MessageBoxButtons.OK);
            
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            FrmUpdateMore frmUpdateMore = new FrmUpdateMore();
            frmUpdateMore.txtID.Text = txtID.Text;
            frmUpdateMore.txtName.Text = txtName.Text;
            frmUpdateMore.txtCategory.Text = txtCategory.Text;
            frmUpdateMore.txtPrice.Text = txtPrice.Text;
            frmUpdateMore.txtPurchase.Text = txtPurchase.Text;
            frmUpdateMore.pictureBox1.Image = pictureBox1.Image;
            this.Close();
            frmUpdateMore.Show(); 
        }
    }
}

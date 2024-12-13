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
            if (txtID.Text == ""|| txtName.Text == ""||txtPrice.Text == ""||txtPurchase.Text == ""||txtCategory.Text == ""||pictureBox1.Image == null)
            {
                MessageBox.Show("Please enter the information.", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (Checkitem() == 0)
                {
                    //byte[] data = ImageToByteArray(pictureBox1.Image);
                    //connect.Open();
                    //decimal sellPrice = decimal.Parse(txtPrice.Text);
                    //decimal purchasePrice = decimal.Parse(txtPurchase.Text);
                    //SqlCommand cmd = new SqlCommand("insert into Product values (@productID,@productname,@Category,@sellPricce,@purchasePrice,@imgProduct)", connect);
                    //cmd.Parameters.AddWithValue("@productID", txtID.Text);
                    //cmd.Parameters.AddWithValue("@productname", txtName.Text);
                    //cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                    //cmd.Parameters.AddWithValue("@sellPricce", sellPrice);
                    //cmd.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                    //cmd.Parameters.AddWithValue("@imgProduct", data);
                    //cmd.ExecuteNonQuery();
                    //connect.Close();
                    //MessageBox.Show("Add new product success.", "Notification", MessageBoxButtons.OK);
                    //txtID.Text = "";
                    //txtName.Text = "";
                    //txtPrice.Text = "";
                    //txtPurchase.Text = "";
                    //txtCategory.Text = "";
                    //pictureBox1.Image = null;
                    MessageBox.Show("0", "Notiffication", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Khởi tạo FrmSetting (nếu chưa khởi tạo từ trước)
            FrmSetting frmSetting = new FrmSetting();

            // Duyệt qua các dòng trong dgvProducts
            foreach (DataGridViewRow row in frmSetting.dgvProducts.Rows)
            {
                // Kiểm tra xem giá trị của ô cột 0 có phải null không
                if (row.Cells[0].Value.ToString().Trim() == null || row.Cells[0].Value.ToString().Trim() == txtID.Text)
                {
                    return 1; // Nếu tìm thấy ID thì trả về 1
                }
            }

            return 0; // Nếu không tìm thấy ID thì trả về 0
        }
    }


}

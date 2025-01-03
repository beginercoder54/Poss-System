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
    public partial class FrmMore : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        int indexRow = -1;
        public FrmMore()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            FrmProFileProducts frmProFileProducts = new FrmProFileProducts();

            frmProFileProducts.txtID.Text = txtID.Text;
            frmProFileProducts.txtName.Text = txtName.Text;
            frmProFileProducts.cbbCategory.Text = cbbCategory.Text;
            frmProFileProducts.txtPrice.Text = txtPrice.Text;
            frmProFileProducts.txtPurchase.Text = txtPurchase.Text;
            frmProFileProducts.pictureBox1.Image = pictureBox1.Image;
            this.Close();
            frmProFileProducts.Show();
            
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (Checkingredient()==0)
            {
                dgvIngredient.Rows.Add(txtIname.Text, txtKg.Text);
                txtIname.Text = txtKg.Text = "";
            }
            else
                MessageBox.Show("Ingredient has available", "Notiffication", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btndelIn_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0)
            {
                dgvIngredient.Rows.RemoveAt(indexRow);
                MessageBox.Show("Delete success", "Notiffication", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Select ingredient for delete","Notiffication",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void dgvIngredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                foreach(DataGridViewRow item in dgvIngredient.Rows)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into Ingredient values (@productID,@ingredientName,@kg)", connect);
                    cmd2.Parameters.AddWithValue("@productID", txtID.Text);
                    cmd2.Parameters.AddWithValue("@ingredientName", item.Cells[0].Value.ToString());
                    cmd2.Parameters.AddWithValue("@kg", decimal.Parse(item.Cells[1].Value.ToString().Replace(".", ",")));
                    cmd2.ExecuteNonQuery();
                }
               
                connect.Close();
                MessageBox.Show("Add new product success.", "Notification", MessageBoxButtons.OK);
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtPurchase.Text = "";
                cbbCategory.Text = "";
                pictureBox1.Image = null;
                dgvIngredient.Rows.Clear();
                txtIname.Text = txtKg.Text = "";
            }
            else
                MessageBox.Show("Product is available", "Notiffication", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int Checkingredient()
        {
           
            // Iterate through the rows in the DataGridView
            foreach (DataGridViewRow row in dgvIngredient.Rows)
            {
                // Check if the value in the first cell is not null or empty before comparing
                var cellValue = row.Cells[0].Value?.ToString().Trim(); // Safe null check

                if (string.IsNullOrEmpty(cellValue))
                {
                    continue; // Skip rows with null or empty ID
                }

                // Compare the value from the text box to the cell value
                if (cellValue == txtIname.Text.Trim())
                {
                    return 1; // Product ID exists, return 1 to indicate duplication
                }
            }

            return 0; // No matching product ID found
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
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
    }
}

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
    public partial class FrmUpdateMore : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        int indexRow = -1;
        public FrmUpdateMore()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            FrmUpdateProFile frmUpdateProFile = new FrmUpdateProFile();
            frmUpdateProFile.txtName.Text = txtName.Text;
            frmUpdateProFile.txtID.Text = txtID.Text;
            frmUpdateProFile.cbbCategory.Text = cbbCategory.Text;
            frmUpdateProFile.txtPrice.Text = txtPrice.Text;
            frmUpdateProFile.txtPurchase.Text = txtPurchase.Text;
            frmUpdateProFile.pictureBox1.Image = pictureBox1.Image;
            this.Close();
            frmUpdateProFile.Show();
            
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

            if (Checkingredient() == 0)
            {
                dgvIngredient.Rows.Add(txtIname.Text, txtKg.Text);
                txtIname.Text = txtKg.Text = "";
            }
            else
            {
                dgvIngredient.Rows.RemoveAt(indexRow);
                dgvIngredient.Rows.Add(txtIname.Text, txtKg.Text);
            }

            //{
            //    connect.Open();
            //    SqlCommand sqlCommand = new SqlCommand("update Ingredient set ingredientName = @ingredientName,kg=@kg where productID=@productID", connect);
            //    sqlCommand.Parameters.AddWithValue("productID", txtID.Text);
            //    sqlCommand.Parameters.AddWithValue("ingredientName", txtIname.Text);
            //    sqlCommand.Parameters.AddWithValue("kg", txtKg.Text.Replace(",", "."));
            //    sqlCommand.ExecuteNonQuery();
            //    connect.Close();
            //    txtIname.Text = txtKg.Text = "";
            //    loadIngredient();
            //}
        }

        private void btndelIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexRow >= 0)
                {
                    dgvIngredient.Rows.RemoveAt(indexRow);
                    txtIname.Text = txtKg.Text = "";
                    MessageBox.Show("Delete success", "Notiffication", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Select ingredient for delete", "Notiffication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex) { MessageBox.Show("Select ingredient again", "Notiffication", MessageBoxButtons.OK); }
            
        }

        private void dgvIngredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            txtIname.Text = dgvIngredient.Rows[indexRow].Cells[0].Value.ToString();
            txtKg.Text = dgvIngredient.Rows[indexRow].Cells[1].Value.ToString();
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
                foreach (DataGridViewRow item in dgvIngredient.Rows)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into Ingredient values (@productID,@ingredientName,@kg)", connect);
                    cmd2.Parameters.AddWithValue("@productID", txtID.Text);
                    cmd2.Parameters.AddWithValue("@ingredientName", item.Cells[0].Value.ToString());
                    cmd2.Parameters.AddWithValue("@kg", decimal.Parse(item.Cells[1].Value.ToString().Replace(".", ",")));
                    cmd2.ExecuteNonQuery();
                }

                connect.Close();
                MessageBox.Show("Add new product success.", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                byte[] data = ImageToByteArray(pictureBox1.Image);
                connect.Open();
                decimal sellPrice = decimal.Parse(txtPrice.Text);
                decimal purchasePrice = decimal.Parse(txtPurchase.Text);
                SqlCommand cmd = new SqlCommand("update  Product set  productID = @productID , productname = @productname ,category = @Category,sellPrice = @sellPricce,purchasePrice =@purchasePrice,imgProduct = @imgProduct where productID=@productID or productname= @productname", connect);
                cmd.Parameters.AddWithValue("productID", txtID.Text);
                cmd.Parameters.AddWithValue("productname", txtName.Text);
                cmd.Parameters.AddWithValue("Category", cbbCategory.Text);
                cmd.Parameters.AddWithValue("sellPricce", sellPrice);
                cmd.Parameters.AddWithValue("purchasePrice", purchasePrice);
                cmd.Parameters.AddWithValue("imgProduct", data);
                cmd.ExecuteNonQuery();
                if (checkProductvalid(txtID.Text) == 0)
                {
                    foreach (DataGridViewRow item in dgvIngredient.Rows)
                    {
                        SqlCommand cmd2 = new SqlCommand("insert into Ingredient values (@productID,@ingredientName,@kg)", connect);
                        cmd2.Parameters.AddWithValue("@productID", txtID.Text);
                        cmd2.Parameters.AddWithValue("@ingredientName", item.Cells[0].Value.ToString());
                        cmd2.Parameters.AddWithValue("@kg", decimal.Parse(item.Cells[1].Value.ToString().Replace(".",",")));
                        cmd2.ExecuteNonQuery();
                    }
                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand("delete from Ingredient where productID = @productID", connect);
                    cmd3.Parameters.AddWithValue("productID", txtID.Text);
                    cmd3.ExecuteNonQuery();
                    foreach (DataGridViewRow item in dgvIngredient.Rows)
                    {
                        SqlCommand cmd4 = new SqlCommand("insert into Ingredient values (@productID,@ingredientName,@kg)", connect);
                        cmd4.Parameters.AddWithValue("@productID", txtID.Text);
                        cmd4.Parameters.AddWithValue("@ingredientName", item.Cells[0].Value.ToString());
                        cmd4.Parameters.AddWithValue("@kg", decimal.Parse(item.Cells[1].Value.ToString().Replace(".", ",")));
                        cmd4.ExecuteNonQuery();
                    }
                }
                connect.Close();
                MessageBox.Show("Update new product success.", "Notification", MessageBoxButtons.OK);
            }
               
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

        private void FrmUpdateMore_Shown(object sender, EventArgs e)
        {
            if (checkProductvalid(txtID.Text) == 1)  loadIngredient();

        }
        public void loadIngredient()
        {
            SqlCommand cmd = new SqlCommand("select ingredientName,ROUND(kg, 4) as kg from Ingredient where productID = @productID", connect);
            cmd.Parameters.AddWithValue("@productID", txtID.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            dgvIngredient.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvIngredient.Rows.Add(dt.Rows[i]["ingredientName"].ToString(), dt.Rows[i]["kg"].ToString());
            }
            
        }

        public int checkProductvalid(string ID)
        {
            SqlCommand cmd = new SqlCommand("select * from Ingredient where productID ='"+ID+"'",connect);
            DataTable check = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(check);

            if (check.Rows.Count > 0) return 1;
            return 0;
        }

    }
}

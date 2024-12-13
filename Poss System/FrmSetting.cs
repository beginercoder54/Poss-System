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
    public partial class FrmSetting : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        int indexRow;
        public FrmSetting()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from Product", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvProducts.DataSource = dt;
            connect.Close();
        }
        private void FrmSetting_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProFileProducts frmProFileProducts = new FrmProFileProducts();
            frmProFileProducts.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (indexRow > 0)
            {
                FrmUpdateProFile frmUpdateProFile = new FrmUpdateProFile();
                frmUpdateProFile.Show();
                frmUpdateProFile.txtID.Text = dgvProducts.Rows[indexRow].Cells[0].Value.ToString();
                frmUpdateProFile.txtName.Text = dgvProducts.Rows[indexRow].Cells[1].Value.ToString();
                frmUpdateProFile.txtCategory.Text = dgvProducts.Rows[indexRow].Cells[2].Value.ToString();
                frmUpdateProFile.txtPrice.Text = dgvProducts.Rows[indexRow].Cells[3].Value.ToString();
                frmUpdateProFile.txtPurchase.Text = dgvProducts.Rows[indexRow].Cells[4].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dgvProducts.Rows[indexRow].Cells[5].Value);
                frmUpdateProFile.pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Select product for update","Notiffication",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow= e.RowIndex;
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (indexRow > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete the product ?", "Alarm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string id = dgvProducts.Rows[indexRow].Cells[0].Value.ToString();
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("delete Product where productID = @productID", connect);
                    cmd.Parameters.AddWithValue("productID", id);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Delete success.", "Notiffication", MessageBoxButtons.OK);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Select product for delete", "Notiffication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if(txtID.Text=="" && txtName.Text=="" && txtType.Text==""){
                MessageBox.Show("Input value to search product", "Notiffication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtID.Text != "" && txtName.Text == "" && txtType.Text == "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product where productID like '%" + txtID.Text + "%'", connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    connect.Close(); ;
                }
                if (txtID.Text == "" && txtName.Text != "" && txtType.Text == "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product where productname like '%" + txtName.Text + "%'", connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    connect.Close(); ;
                }
                if (txtID.Text == "" && txtName.Text == "" && txtType.Text != "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product where Category like '%" + txtType.Text + "%'", connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    connect.Close(); ;
                }
                if (txtID.Text != "" && txtName.Text != "" && txtType.Text == "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product where productID like '%" + txtID.Text + "%'and productname like '%" + txtName.Text + "%'", connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    connect.Close(); ;
                }
                if (txtID.Text != "" && txtName.Text == "" && txtType.Text != "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product where productID like '%" + txtID.Text + "%'and Category like '%" + txtType.Text + "%'", connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    connect.Close(); ;
                }
                if (txtID.Text == "" && txtName.Text != "" && txtType.Text != "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product where productname like '%" + txtName.Text + "%'and Category like '%" + txtType.Text + "%'", connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    connect.Close(); ;
                }
                if (txtID.Text != "" && txtName.Text != "" && txtType.Text != "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product where productname like '%" + txtName.Text + "%'and Category like '%" + txtType.Text + "%'and productID like '%" + txtID.Text + "%'", connect);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    connect.Close(); ;
                }
            }
            

        }

    }
}


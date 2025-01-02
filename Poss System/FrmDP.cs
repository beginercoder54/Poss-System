using Poss_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace spoil
{
    public partial class FrmDP : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmDP()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to close this application?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                // Sao chép danh sách các form đang mở vào một mảng hoặc danh sách riêng biệt
                var openForms = Application.OpenForms.Cast<Form>().ToList();

                // Đóng tất cả các form đang mở
                foreach (Form openForm in openForms)
                {
                    if(openForm.Name != "FrmLogin") openForm.Close();
                }
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text =="" || txtProductName.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Input value to add","Notiffication",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               
                    dataGridView1.Rows.Add(txtProductID.Text, txtProductName.Text, txtQuantity.Text);
                    txtProductID.Text = txtProductName.Text = txtQuantity.Text = "";
                    btnSubmit.Enabled = true;
                
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            connect.Open();
            DateTime dateTime = DateTime.Now;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                SqlCommand cmd = new SqlCommand("insert into DefectiveProduct values (@productID,@productName,@DfDate,@Quantity)", connect);
                cmd.Parameters.AddWithValue("@productID", item.Cells[0].Value.ToString() );
                cmd.Parameters.AddWithValue("@productName", item.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@DfDate",dateTime );
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(item.Cells[2].Value));
                cmd.ExecuteNonQuery();
            }

            var openForms = Application.OpenForms.Cast<Form>().ToList();

            // Đóng tất cả các form đang mở
            foreach (Form openForm in openForms)
            {
                if (openForm.Name != "FrmLogin") openForm.Close();
            }
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

            connect.Close();
           
        }

        private void FrmDP_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            
            
            SqlCommand cmd = new SqlCommand("select productID from Product ",connect);
            DataTable dtID= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtID);
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

            // Duyệt qua DataTable và thêm vào AutoCompleteStringCollection
            foreach (DataRow row in dtID.Rows)
            {
                autoCompleteCollection.Add(row["productID"].ToString());
            }
            txtProductID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductID.AutoCompleteCustomSource = autoCompleteCollection;

            SqlCommand cmd1 = new SqlCommand("select productname from Product ", connect);
            DataTable dtname = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dtname);
            AutoCompleteStringCollection autoCompleteCollection1 = new AutoCompleteStringCollection();

            // Duyệt qua DataTable và thêm vào AutoCompleteStringCollection
            foreach (DataRow row in dtname.Rows)
            {
                autoCompleteCollection1.Add(row["productname"].ToString());
            }
            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = autoCompleteCollection1;


            

        }

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            connect.Open();
            if (txtProductID.Text!="")
            {
                SqlCommand cmd1 = new SqlCommand("select productname from Product where productID = @productID", connect);
                cmd1.Parameters.AddWithValue("@productID", txtProductID.Text);
                txtProductName.Text = (string)cmd1.ExecuteScalar();
            }
            connect.Close();
        }

        private void txtProductID_Enter(object sender, EventArgs e)
        {
            connect.Open();
            if (txtProductName.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("select productID from Product where productname = @productname", connect);
                cmd1.Parameters.AddWithValue("@productname", txtProductName.Text);
                txtProductID.Text = (string)cmd1.ExecuteScalar();
            }
            connect.Close();
        }
       
    }
}

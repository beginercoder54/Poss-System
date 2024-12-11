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
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProFileProducts frmProFileProducts = new FrmProFileProducts();
            frmProFileProducts.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}


using Poss_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hu
{
    public partial class FrmRQSetting : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmRQSetting()
        {
            InitializeComponent();
        }

  

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Account WHERE upass= '" +txtPass.Text + "'", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FrmSetting frmSetting = new FrmSetting();
                this.Close();
                frmSetting.Show();
            }
            else
            {
                {
                    MessageBox.Show("Password is wrong", "Notiffication", MessageBoxButtons.OK);
                }
            }
        }
    }
}

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

namespace spoil
{
    public partial class FrmExport : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        public FrmExport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;
            string dayfrom = ""+from.Year+"/"+from.Month+"/"+from.Day+"";
            string dayto = "" + to.Year + "/" + to.Month + "/" + to.Day + "";

            if (AllCheck() == 1)
            {
                SqlCommand cmd = new SqlCommand("select BillID,username,InsertBill,CheckOut,ISNULL(tableID, 0) as tableID,fID as ProductID,fName as ProductName,Quantity,FoodPrice,TotalPrice from Orders where CONVERT(DATE, CheckOut) between '" + dayfrom + "'and '" + dayto + "'", connect);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {

            }
        }
        
        public int AllCheck()
        {
            foreach (Control itemo in grbOptionOrders.Controls)
            {
                if (itemo is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)itemo;
                    if (checkBox.Checked) return 1;
                }
            }

            foreach (Control item in grbOptionProduct.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox1 = (CheckBox)item;
                    if (checkBox1.Checked) return 1;
                }
            }

            return 0;
        }

        private void tabExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabExport.SelectedIndex == 0)
            {
                foreach (Control itemo in grbOptionOrders.Controls)
                {
                    if (itemo is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)itemo;
                        checkBox.Checked = true;
                    }
                }
            }else
            {
                foreach (Control item in grbOptionProduct.Controls)
                {
                    if(item is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)item;
                        checkBox.Checked = true;
                    }
                    
                }
            }
        }

        private void FrmExport_Load(object sender, EventArgs e)
        {
            foreach (Control itemo in grbOptionOrders.Controls)
            {
                if (itemo is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)itemo;
                    checkBox.Checked = true;
                }
            }
        }

        private void btnApplyP_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;
            string dayfrom = "" + from.Year + "/" + from.Month + "/" + from.Day + "";
            string dayto = "" + to.Year + "/" + to.Month + "/" + to.Day + "";

            if (AllCheck() == 1)
            {
                SqlCommand cmd = new SqlCommand("select  from Orders where CONVERT(DATE, CheckOut) between '" + dayfrom + "'and '" + dayto + "'", connect);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {

            }
        }

        private void rbtnPD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPD.Checked == true) chkbDate.Visible = true;
        }

        private void rbtnProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPD.Checked == false) chkbDate.Visible = false;
        }
    }
}

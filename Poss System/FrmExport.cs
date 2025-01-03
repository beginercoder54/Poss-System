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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace spoil
{
    public partial class FrmExport : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Pos_System;Integrated Security=True");
        decimal num;
        decimal costp;
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

            
            SqlCommand cmd = new SqlCommand("select BillID,username,InsertBill,CheckOut,ISNULL(tableID, 0) as tableID,fID as ProductID,fName as ProductName,Quantity,FoodPrice,TotalPrice from Orders where CONVERT(DATE, CheckOut) between '" + dayfrom + "'and '" + dayto + "'", connect);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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
            DateTime from = dateTimePicker4.Value;
            DateTime to = dateTimePicker3.Value;
            string dayfrom = "" + from.Year + "/" + from.Month + "/" + from.Day + "";
            string dayto = "" + to.Year + "/" + to.Month + "/" + to.Day + "";

            if (rbtnProduct.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("select fID ,fName,SUM(Quantity) 'Quantity' from Orders where CONVERT(DATE, CheckOut) between '" + dayfrom + "'and '" + dayto + "'group by fID,fName", connect);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (rbtnPD.Checked==true)
            {
                SqlCommand cmd = new SqlCommand("select df.productID,df.productName,i.ingredientName,i.kg*df.Quantity 'Quantity' from DefectiveProduct df,Product p,Ingredient i where df.productID = p.productID and p.productID = i.productID  and CONVERT(DATE, DfDate) between '" + dayfrom + "'and '" + dayto + "'", connect);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
           
        }

       

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (tabExport.SelectedIndex == 0)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Export Excel";
                    saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            ExportExcel(saveFileDialog.FileName);
                            MessageBox.Show("Export success !!", "Notiffication", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Export fail !!\n" + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You need to apply option first", "Notification", MessageBoxButtons.OK);
                }
            }else
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Export Excel";
                    saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            ExportExcel(saveFileDialog.FileName);
                            MessageBox.Show("Export success !!", "Notiffication", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Export fail !!\n" + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You need to apply option first", "Notification", MessageBoxButtons.OK);
                }
            }
            
        }

        private void ExportExcel(string path)
        {

            
            if (tabExport.SelectedIndex == 0)
            {
                DateTime from = dateTimePicker1.Value;
                DateTime to = dateTimePicker2.Value;
                string dayfrom = "" + from.Year + "/" + from.Month + "/" + from.Day + "";
                string dayto = "" + to.Year + "/" + to.Month + "/" + to.Day + "";
                Excel.Application application = new Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
          
                if (TotalRevenue.Checked==true)
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("select ISNULL(sum(distinct TotalPrice),0) from Orders  where CONVERT(DATE, CheckOut) between '" + dayfrom + "'and '" + dayto + "'and Status in (1,null)", connect);
                    num = (decimal)command.ExecuteScalar();
                    application.Cells[1, 11] = TotalRevenue.Name;
                    application.Cells[2, 11] = num.ToString() ;
                    connect.Close();    
                }

                if (Profit.Checked==true)
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("select o.Quantity*p.purchasePrice  from Orders o ,Product p where o.fID = p.productID  and CONVERT(DATE, CheckOut) between '" + dayfrom + "'and '" + dayto + "'group by o.fID,o.fName,o.Quantity*p.purchasePrice", connect);
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da4 = new SqlDataAdapter(command);
                    da4.Fill(dt3);
                    decimal profit = 0;
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        profit += Convert.ToDecimal(dt3.Rows[i][0]);
                    }
                    decimal a = num - profit;
                    costp = profit;
                    application.Cells[1, 12] = Profit.Name;
                    application.Cells[2, 12] = a;
                    connect.Close();
                }

                if (TotalCost.Checked == true)
                {
                    connect.Open();

                    application.Cells[1, 13] = TotalCost.Name;
                    application.Cells[2, 13] = costp.ToString();
                    connect.Close();
                }
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;
            }
            else
            {
                DateTime from = dateTimePicker4.Value;
                DateTime to = dateTimePicker3.Value;
                string dayfrom = "" + from.Year + "/" + from.Month + "/" + from.Day + "";
                string dayto = "" + to.Year + "/" + to.Month + "/" + to.Day + "";
                Excel.Application application = new Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    application.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;

                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
                
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;
            }
            
        }
    }
}

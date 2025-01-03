
namespace spoil
{
    partial class FrmExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabExport = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.grbOptionOrders = new System.Windows.Forms.GroupBox();
            this.btnApplyO = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.grbOptionProduct = new System.Windows.Forms.GroupBox();
            this.rbtnProduct = new System.Windows.Forms.RadioButton();
            this.rbtnPD = new System.Windows.Forms.RadioButton();
            this.btnApplyP = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TotalCost = new System.Windows.Forms.CheckBox();
            this.Profit = new System.Windows.Forms.CheckBox();
            this.TotalRevenue = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.grbOptionOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabProduct.SuspendLayout();
            this.grbOptionProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(15, 375);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 28);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(137, 375);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.tabExport);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 417);
            this.panel1.TabIndex = 2;
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.tabOrders);
            this.tabExport.Controls.Add(this.tabProduct);
            this.tabExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabExport.Location = new System.Drawing.Point(0, 0);
            this.tabExport.Margin = new System.Windows.Forms.Padding(4);
            this.tabExport.Name = "tabExport";
            this.tabExport.SelectedIndex = 0;
            this.tabExport.Size = new System.Drawing.Size(636, 368);
            this.tabExport.TabIndex = 0;
            this.tabExport.SelectedIndexChanged += new System.EventHandler(this.tabExport_SelectedIndexChanged);
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.grbOptionOrders);
            this.tabOrders.Controls.Add(this.dataGridView1);
            this.tabOrders.Location = new System.Drawing.Point(4, 25);
            this.tabOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabOrders.Size = new System.Drawing.Size(628, 339);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // grbOptionOrders
            // 
            this.grbOptionOrders.Controls.Add(this.Profit);
            this.grbOptionOrders.Controls.Add(this.TotalRevenue);
            this.grbOptionOrders.Controls.Add(this.TotalCost);
            this.grbOptionOrders.Controls.Add(this.btnApplyO);
            this.grbOptionOrders.Controls.Add(this.dateTimePicker2);
            this.grbOptionOrders.Controls.Add(this.dateTimePicker1);
            this.grbOptionOrders.Controls.Add(this.label2);
            this.grbOptionOrders.Controls.Add(this.label1);
            this.grbOptionOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOptionOrders.Location = new System.Drawing.Point(9, 4);
            this.grbOptionOrders.Margin = new System.Windows.Forms.Padding(4);
            this.grbOptionOrders.Name = "grbOptionOrders";
            this.grbOptionOrders.Padding = new System.Windows.Forms.Padding(4);
            this.grbOptionOrders.Size = new System.Drawing.Size(615, 117);
            this.grbOptionOrders.TabIndex = 1;
            this.grbOptionOrders.TabStop = false;
            this.grbOptionOrders.Text = "Option";
            // 
            // btnApplyO
            // 
            this.btnApplyO.Location = new System.Drawing.Point(25, 81);
            this.btnApplyO.Name = "btnApplyO";
            this.btnApplyO.Size = new System.Drawing.Size(94, 28);
            this.btnApplyO.TabIndex = 18;
            this.btnApplyO.Text = "Apply";
            this.btnApplyO.UseVisualStyleBackColor = true;
            this.btnApplyO.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/mm/yy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(59, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(624, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.grbOptionProduct);
            this.tabProduct.Controls.Add(this.dataGridView2);
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(4);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(4);
            this.tabProduct.Size = new System.Drawing.Size(628, 339);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // grbOptionProduct
            // 
            this.grbOptionProduct.Controls.Add(this.rbtnProduct);
            this.grbOptionProduct.Controls.Add(this.rbtnPD);
            this.grbOptionProduct.Controls.Add(this.btnApplyP);
            this.grbOptionProduct.Controls.Add(this.dateTimePicker3);
            this.grbOptionProduct.Controls.Add(this.dateTimePicker4);
            this.grbOptionProduct.Controls.Add(this.label3);
            this.grbOptionProduct.Controls.Add(this.label4);
            this.grbOptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOptionProduct.Location = new System.Drawing.Point(9, 4);
            this.grbOptionProduct.Margin = new System.Windows.Forms.Padding(4);
            this.grbOptionProduct.Name = "grbOptionProduct";
            this.grbOptionProduct.Padding = new System.Windows.Forms.Padding(4);
            this.grbOptionProduct.Size = new System.Drawing.Size(611, 112);
            this.grbOptionProduct.TabIndex = 2;
            this.grbOptionProduct.TabStop = false;
            this.grbOptionProduct.Text = "Option";
            // 
            // rbtnProduct
            // 
            this.rbtnProduct.AutoSize = true;
            this.rbtnProduct.Location = new System.Drawing.Point(194, 18);
            this.rbtnProduct.Name = "rbtnProduct";
            this.rbtnProduct.Size = new System.Drawing.Size(126, 24);
            this.rbtnProduct.TabIndex = 20;
            this.rbtnProduct.TabStop = true;
            this.rbtnProduct.Text = "Product Sale";
            this.rbtnProduct.UseVisualStyleBackColor = true;
            // 
            // rbtnPD
            // 
            this.rbtnPD.AutoSize = true;
            this.rbtnPD.Location = new System.Drawing.Point(194, 51);
            this.rbtnPD.Name = "rbtnPD";
            this.rbtnPD.Size = new System.Drawing.Size(164, 24);
            this.rbtnPD.TabIndex = 20;
            this.rbtnPD.TabStop = true;
            this.rbtnPD.Text = "Product Defective";
            this.rbtnPD.UseVisualStyleBackColor = true;
            // 
            // btnApplyP
            // 
            this.btnApplyP.Location = new System.Drawing.Point(23, 76);
            this.btnApplyP.Name = "btnApplyP";
            this.btnApplyP.Size = new System.Drawing.Size(94, 28);
            this.btnApplyP.TabIndex = 19;
            this.btnApplyP.Text = "Apply";
            this.btnApplyP.UseVisualStyleBackColor = true;
            this.btnApplyP.Click += new System.EventHandler(this.btnApplyP_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/mm/yy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(54, 48);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(54, 19);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "From:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 123);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(628, 213);
            this.dataGridView2.TabIndex = 1;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(209, 51);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(103, 24);
            this.TotalCost.TabIndex = 19;
            this.TotalCost.Text = "TotalCost";
            this.TotalCost.UseVisualStyleBackColor = true;
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.Location = new System.Drawing.Point(209, 81);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(71, 24);
            this.Profit.TabIndex = 19;
            this.Profit.Text = "Profit";
            this.Profit.UseVisualStyleBackColor = true;
            // 
            // TotalRevenue
            // 
            this.TotalRevenue.AutoSize = true;
            this.TotalRevenue.Location = new System.Drawing.Point(209, 23);
            this.TotalRevenue.Name = "TotalRevenue";
            this.TotalRevenue.Size = new System.Drawing.Size(138, 24);
            this.TotalRevenue.TabIndex = 19;
            this.TotalRevenue.Text = "Total Revenue";
            this.TotalRevenue.UseVisualStyleBackColor = true;
            // 
            // FrmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 417);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExport";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmExport_Load);
            this.panel1.ResumeLayout(false);
            this.tabExport.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.grbOptionOrders.ResumeLayout(false);
            this.grbOptionOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.grbOptionProduct.ResumeLayout(false);
            this.grbOptionProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabExport;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grbOptionOrders;
        private System.Windows.Forms.GroupBox grbOptionProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApplyO;
        private System.Windows.Forms.Button btnApplyP;
        private System.Windows.Forms.RadioButton rbtnProduct;
        private System.Windows.Forms.RadioButton rbtnPD;
        private System.Windows.Forms.CheckBox Profit;
        private System.Windows.Forms.CheckBox TotalRevenue;
        private System.Windows.Forms.CheckBox TotalCost;
    }
}
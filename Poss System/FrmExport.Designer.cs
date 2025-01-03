
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
            this.ckTotal = new System.Windows.Forms.CheckBox();
            this.ckFoodPrice = new System.Windows.Forms.CheckBox();
            this.ckQuantity = new System.Windows.Forms.CheckBox();
            this.ckProductName = new System.Windows.Forms.CheckBox();
            this.ckProductID = new System.Windows.Forms.CheckBox();
            this.ckInsertBill = new System.Windows.Forms.CheckBox();
            this.ckCheckOut = new System.Windows.Forms.CheckBox();
            this.ckTableID = new System.Windows.Forms.CheckBox();
            this.ckUserName = new System.Windows.Forms.CheckBox();
            this.BillID = new System.Windows.Forms.CheckBox();
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
            this.chkboxQuantity = new System.Windows.Forms.CheckBox();
            this.chkboxPName = new System.Windows.Forms.CheckBox();
            this.chkboxPID = new System.Windows.Forms.CheckBox();
            this.chkbDate = new System.Windows.Forms.CheckBox();
            this.chkboxIngredient = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.panel1.Size = new System.Drawing.Size(722, 417);
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
            this.tabExport.Size = new System.Drawing.Size(720, 368);
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
            this.tabOrders.Size = new System.Drawing.Size(712, 339);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // grbOptionOrders
            // 
            this.grbOptionOrders.Controls.Add(this.btnApplyO);
            this.grbOptionOrders.Controls.Add(this.ckTotal);
            this.grbOptionOrders.Controls.Add(this.ckFoodPrice);
            this.grbOptionOrders.Controls.Add(this.ckQuantity);
            this.grbOptionOrders.Controls.Add(this.ckProductName);
            this.grbOptionOrders.Controls.Add(this.ckProductID);
            this.grbOptionOrders.Controls.Add(this.ckInsertBill);
            this.grbOptionOrders.Controls.Add(this.ckCheckOut);
            this.grbOptionOrders.Controls.Add(this.ckTableID);
            this.grbOptionOrders.Controls.Add(this.ckUserName);
            this.grbOptionOrders.Controls.Add(this.BillID);
            this.grbOptionOrders.Controls.Add(this.dateTimePicker2);
            this.grbOptionOrders.Controls.Add(this.dateTimePicker1);
            this.grbOptionOrders.Controls.Add(this.label2);
            this.grbOptionOrders.Controls.Add(this.label1);
            this.grbOptionOrders.Location = new System.Drawing.Point(9, 4);
            this.grbOptionOrders.Margin = new System.Windows.Forms.Padding(4);
            this.grbOptionOrders.Name = "grbOptionOrders";
            this.grbOptionOrders.Padding = new System.Windows.Forms.Padding(4);
            this.grbOptionOrders.Size = new System.Drawing.Size(695, 117);
            this.grbOptionOrders.TabIndex = 1;
            this.grbOptionOrders.TabStop = false;
            this.grbOptionOrders.Text = "Option";
            // 
            // btnApplyO
            // 
            this.btnApplyO.Location = new System.Drawing.Point(23, 76);
            this.btnApplyO.Name = "btnApplyO";
            this.btnApplyO.Size = new System.Drawing.Size(94, 28);
            this.btnApplyO.TabIndex = 18;
            this.btnApplyO.Text = "Apply";
            this.btnApplyO.UseVisualStyleBackColor = true;
            this.btnApplyO.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ckTotal
            // 
            this.ckTotal.AutoSize = true;
            this.ckTotal.Location = new System.Drawing.Point(560, 23);
            this.ckTotal.Name = "ckTotal";
            this.ckTotal.Size = new System.Drawing.Size(94, 20);
            this.ckTotal.TabIndex = 8;
            this.ckTotal.Text = "Total Price";
            this.ckTotal.UseVisualStyleBackColor = true;
            // 
            // ckFoodPrice
            // 
            this.ckFoodPrice.AutoSize = true;
            this.ckFoodPrice.Location = new System.Drawing.Point(430, 74);
            this.ckFoodPrice.Name = "ckFoodPrice";
            this.ckFoodPrice.Size = new System.Drawing.Size(95, 20);
            this.ckFoodPrice.TabIndex = 9;
            this.ckFoodPrice.Text = "Food Price";
            this.ckFoodPrice.UseVisualStyleBackColor = true;
            // 
            // ckQuantity
            // 
            this.ckQuantity.AutoSize = true;
            this.ckQuantity.Location = new System.Drawing.Point(430, 48);
            this.ckQuantity.Name = "ckQuantity";
            this.ckQuantity.Size = new System.Drawing.Size(77, 20);
            this.ckQuantity.TabIndex = 10;
            this.ckQuantity.Text = "Quantity";
            this.ckQuantity.UseVisualStyleBackColor = true;
            // 
            // ckProductName
            // 
            this.ckProductName.AutoSize = true;
            this.ckProductName.Location = new System.Drawing.Point(430, 23);
            this.ckProductName.Name = "ckProductName";
            this.ckProductName.Size = new System.Drawing.Size(115, 20);
            this.ckProductName.TabIndex = 11;
            this.ckProductName.Text = "Product Name";
            this.ckProductName.UseVisualStyleBackColor = true;
            // 
            // ckProductID
            // 
            this.ckProductID.AutoSize = true;
            this.ckProductID.Location = new System.Drawing.Point(313, 75);
            this.ckProductID.Name = "ckProductID";
            this.ckProductID.Size = new System.Drawing.Size(91, 20);
            this.ckProductID.TabIndex = 12;
            this.ckProductID.Text = "Product ID";
            this.ckProductID.UseVisualStyleBackColor = true;
            // 
            // ckInsertBill
            // 
            this.ckInsertBill.AutoSize = true;
            this.ckInsertBill.Location = new System.Drawing.Point(202, 75);
            this.ckInsertBill.Name = "ckInsertBill";
            this.ckInsertBill.Size = new System.Drawing.Size(82, 20);
            this.ckInsertBill.TabIndex = 13;
            this.ckInsertBill.Text = "Insert Bill";
            this.ckInsertBill.UseVisualStyleBackColor = true;
            // 
            // ckCheckOut
            // 
            this.ckCheckOut.AutoSize = true;
            this.ckCheckOut.Location = new System.Drawing.Point(313, 22);
            this.ckCheckOut.Name = "ckCheckOut";
            this.ckCheckOut.Size = new System.Drawing.Size(90, 20);
            this.ckCheckOut.TabIndex = 14;
            this.ckCheckOut.Text = "Check Out";
            this.ckCheckOut.UseVisualStyleBackColor = true;
            // 
            // ckTableID
            // 
            this.ckTableID.AutoSize = true;
            this.ckTableID.Location = new System.Drawing.Point(313, 48);
            this.ckTableID.Name = "ckTableID";
            this.ckTableID.Size = new System.Drawing.Size(81, 20);
            this.ckTableID.TabIndex = 15;
            this.ckTableID.Text = "Table ID";
            this.ckTableID.UseVisualStyleBackColor = true;
            // 
            // ckUserName
            // 
            this.ckUserName.AutoSize = true;
            this.ckUserName.Location = new System.Drawing.Point(202, 48);
            this.ckUserName.Name = "ckUserName";
            this.ckUserName.Size = new System.Drawing.Size(98, 20);
            this.ckUserName.TabIndex = 16;
            this.ckUserName.Text = "User Name";
            this.ckUserName.UseVisualStyleBackColor = true;
            // 
            // BillID
            // 
            this.BillID.AutoSize = true;
            this.BillID.Location = new System.Drawing.Point(202, 22);
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(63, 20);
            this.BillID.TabIndex = 17;
            this.BillID.Text = "Bill ID";
            this.BillID.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/mm/yy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(54, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(712, 213);
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
            this.tabProduct.Size = new System.Drawing.Size(712, 339);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // grbOptionProduct
            // 
            this.grbOptionProduct.Controls.Add(this.rbtnProduct);
            this.grbOptionProduct.Controls.Add(this.rbtnPD);
            this.grbOptionProduct.Controls.Add(this.btnApplyP);
            this.grbOptionProduct.Controls.Add(this.chkboxQuantity);
            this.grbOptionProduct.Controls.Add(this.chkboxPName);
            this.grbOptionProduct.Controls.Add(this.chkboxPID);
            this.grbOptionProduct.Controls.Add(this.chkbDate);
            this.grbOptionProduct.Controls.Add(this.chkboxIngredient);
            this.grbOptionProduct.Controls.Add(this.dateTimePicker3);
            this.grbOptionProduct.Controls.Add(this.dateTimePicker4);
            this.grbOptionProduct.Controls.Add(this.label3);
            this.grbOptionProduct.Controls.Add(this.label4);
            this.grbOptionProduct.Location = new System.Drawing.Point(9, 4);
            this.grbOptionProduct.Margin = new System.Windows.Forms.Padding(4);
            this.grbOptionProduct.Name = "grbOptionProduct";
            this.grbOptionProduct.Padding = new System.Windows.Forms.Padding(4);
            this.grbOptionProduct.Size = new System.Drawing.Size(695, 112);
            this.grbOptionProduct.TabIndex = 2;
            this.grbOptionProduct.TabStop = false;
            this.grbOptionProduct.Text = "Option";
            // 
            // rbtnProduct
            // 
            this.rbtnProduct.AutoSize = true;
            this.rbtnProduct.Location = new System.Drawing.Point(194, 18);
            this.rbtnProduct.Name = "rbtnProduct";
            this.rbtnProduct.Size = new System.Drawing.Size(105, 20);
            this.rbtnProduct.TabIndex = 20;
            this.rbtnProduct.TabStop = true;
            this.rbtnProduct.Text = "Product Sale";
            this.rbtnProduct.UseVisualStyleBackColor = true;
            this.rbtnProduct.CheckedChanged += new System.EventHandler(this.rbtnProduct_CheckedChanged);
            // 
            // rbtnPD
            // 
            this.rbtnPD.AutoSize = true;
            this.rbtnPD.Location = new System.Drawing.Point(194, 51);
            this.rbtnPD.Name = "rbtnPD";
            this.rbtnPD.Size = new System.Drawing.Size(134, 20);
            this.rbtnPD.TabIndex = 20;
            this.rbtnPD.TabStop = true;
            this.rbtnPD.Text = "Product Defective";
            this.rbtnPD.UseVisualStyleBackColor = true;
            this.rbtnPD.CheckedChanged += new System.EventHandler(this.rbtnPD_CheckedChanged);
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
            // chkboxQuantity
            // 
            this.chkboxQuantity.AutoSize = true;
            this.chkboxQuantity.Location = new System.Drawing.Point(354, 81);
            this.chkboxQuantity.Name = "chkboxQuantity";
            this.chkboxQuantity.Size = new System.Drawing.Size(77, 20);
            this.chkboxQuantity.TabIndex = 7;
            this.chkboxQuantity.Text = "Quantity";
            this.chkboxQuantity.UseVisualStyleBackColor = true;
            // 
            // chkboxPName
            // 
            this.chkboxPName.AutoSize = true;
            this.chkboxPName.Location = new System.Drawing.Point(354, 50);
            this.chkboxPName.Name = "chkboxPName";
            this.chkboxPName.Size = new System.Drawing.Size(115, 20);
            this.chkboxPName.TabIndex = 7;
            this.chkboxPName.Text = "Product Name";
            this.chkboxPName.UseVisualStyleBackColor = true;
            // 
            // chkboxPID
            // 
            this.chkboxPID.AutoSize = true;
            this.chkboxPID.Location = new System.Drawing.Point(354, 18);
            this.chkboxPID.Name = "chkboxPID";
            this.chkboxPID.Size = new System.Drawing.Size(91, 20);
            this.chkboxPID.TabIndex = 7;
            this.chkboxPID.Text = "Product ID";
            this.chkboxPID.UseVisualStyleBackColor = true;
            // 
            // chkbDate
            // 
            this.chkbDate.AutoSize = true;
            this.chkbDate.Location = new System.Drawing.Point(494, 52);
            this.chkbDate.Name = "chkbDate";
            this.chkbDate.Size = new System.Drawing.Size(58, 20);
            this.chkbDate.TabIndex = 7;
            this.chkbDate.Text = "Date";
            this.chkbDate.UseVisualStyleBackColor = true;
            // 
            // chkboxIngredient
            // 
            this.chkboxIngredient.AutoSize = true;
            this.chkboxIngredient.Location = new System.Drawing.Point(494, 18);
            this.chkboxIngredient.Name = "chkboxIngredient";
            this.chkboxIngredient.Size = new System.Drawing.Size(88, 20);
            this.chkboxIngredient.TabIndex = 7;
            this.chkboxIngredient.Text = "Ingredient";
            this.chkboxIngredient.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/mm/yy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(54, 48);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(54, 19);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "From:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 123);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(712, 213);
            this.dataGridView2.TabIndex = 1;
            // 
            // FrmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 417);
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
        private System.Windows.Forms.CheckBox chkboxPID;
        private System.Windows.Forms.CheckBox chkbDate;
        private System.Windows.Forms.CheckBox chkboxIngredient;
        private System.Windows.Forms.CheckBox chkboxQuantity;
        private System.Windows.Forms.CheckBox chkboxPName;
        private System.Windows.Forms.CheckBox ckTotal;
        private System.Windows.Forms.CheckBox ckFoodPrice;
        private System.Windows.Forms.CheckBox ckQuantity;
        private System.Windows.Forms.CheckBox ckProductName;
        private System.Windows.Forms.CheckBox ckProductID;
        private System.Windows.Forms.CheckBox ckInsertBill;
        private System.Windows.Forms.CheckBox ckCheckOut;
        private System.Windows.Forms.CheckBox ckTableID;
        private System.Windows.Forms.CheckBox ckUserName;
        private System.Windows.Forms.CheckBox BillID;
        private System.Windows.Forms.Button btnApplyO;
        private System.Windows.Forms.Button btnApplyP;
        private System.Windows.Forms.RadioButton rbtnProduct;
        private System.Windows.Forms.RadioButton rbtnPD;
    }
}
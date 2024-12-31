namespace Poss_System
{
    partial class FrmStatistics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameRes = new System.Windows.Forms.Label();
            this.pictureIconBurger = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowBill = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnReveunue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBurger)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.lblNameRes);
            this.panel1.Controls.Add(this.pictureIconBurger);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 66);
            this.panel1.TabIndex = 0;
            // 
            // lblNameRes
            // 
            this.lblNameRes.AutoSize = true;
            this.lblNameRes.BackColor = System.Drawing.Color.Transparent;
            this.lblNameRes.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRes.ForeColor = System.Drawing.Color.White;
            this.lblNameRes.Location = new System.Drawing.Point(84, 16);
            this.lblNameRes.Name = "lblNameRes";
            this.lblNameRes.Size = new System.Drawing.Size(282, 34);
            this.lblNameRes.TabIndex = 7;
            this.lblNameRes.Text = "Tam Thai Tu Restaurant";
            // 
            // pictureIconBurger
            // 
            this.pictureIconBurger.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureIconBurger.Image = global::Poss_System.Properties.Resources.burger;
            this.pictureIconBurger.Location = new System.Drawing.Point(15, 16);
            this.pictureIconBurger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureIconBurger.Name = "pictureIconBurger";
            this.pictureIconBurger.Size = new System.Drawing.Size(63, 35);
            this.pictureIconBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIconBurger.TabIndex = 6;
            this.pictureIconBurger.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1092, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistics";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtAccount);
            this.panel2.Controls.Add(this.txtBill);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblBill);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 54);
            this.panel2.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.BlanchedAlmond;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDate.Location = new System.Drawing.Point(651, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(1008, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1118, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(350, 15);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(215, 22);
            this.txtAccount.TabIndex = 1;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(78, 15);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(157, 22);
            this.txtBill.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(606, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(269, 18);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(58, 16);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account:";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(28, 18);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(44, 16);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "Bill ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtBill,
            this.dtAccount,
            this.dtDate,
            this.dtTotal});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dtBill
            // 
            this.dtBill.DataPropertyName = "BillID";
            this.dtBill.HeaderText = "Bill ID";
            this.dtBill.MinimumWidth = 6;
            this.dtBill.Name = "dtBill";
            // 
            // dtAccount
            // 
            this.dtAccount.DataPropertyName = "username";
            this.dtAccount.HeaderText = "Account";
            this.dtAccount.MinimumWidth = 6;
            this.dtAccount.Name = "dtAccount";
            // 
            // dtDate
            // 
            this.dtDate.DataPropertyName = "CheckOut";
            this.dtDate.HeaderText = "Date";
            this.dtDate.MinimumWidth = 6;
            this.dtDate.Name = "dtDate";
            // 
            // dtTotal
            // 
            this.dtTotal.DataPropertyName = "TotalPrice";
            this.dtTotal.HeaderText = "Total Price";
            this.dtTotal.MinimumWidth = 6;
            this.dtTotal.Name = "dtTotal";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(18, 501);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 59);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1127, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowBill
            // 
            this.btnShowBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowBill.Location = new System.Drawing.Point(128, 501);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(104, 59);
            this.btnShowBill.TabIndex = 5;
            this.btnShowBill.Text = "Show";
            this.btnShowBill.UseVisualStyleBackColor = true;
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcel.Location = new System.Drawing.Point(350, 501);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(104, 59);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel export";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnReveunue
            // 
            this.btnReveunue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReveunue.Location = new System.Drawing.Point(238, 501);
            this.btnReveunue.Name = "btnReveunue";
            this.btnReveunue.Size = new System.Drawing.Size(104, 59);
            this.btnReveunue.TabIndex = 5;
            this.btnReveunue.Text = "Revenue";
            this.btnReveunue.UseVisualStyleBackColor = true;
            this.btnReveunue.Click += new System.EventHandler(this.btnReveunue_Click);
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 572);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnReveunue);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBurger)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblNameRes;
        private System.Windows.Forms.PictureBox pictureIconBurger;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtTotal;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowBill;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnReveunue;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtInsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNameRes = new System.Windows.Forms.Label();
            this.pictureIconBurger = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBurger)).BeginInit();
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
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtDate);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1008, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1118, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(718, 15);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(157, 22);
            this.txtDate.TabIndex = 1;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(373, 15);
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
            this.lblDate.Location = new System.Drawing.Point(659, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(309, 18);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtBill,
            this.dtAccount,
            this.dtInsert,
            this.dtCheckout,
            this.dtDate,
            this.dtTotal});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 352);
            this.dataGridView1.TabIndex = 2;
            // 
            // dtBill
            // 
            this.dtBill.HeaderText = "Bill ID";
            this.dtBill.MinimumWidth = 6;
            this.dtBill.Name = "dtBill";
            // 
            // dtAccount
            // 
            this.dtAccount.HeaderText = "Account";
            this.dtAccount.MinimumWidth = 6;
            this.dtAccount.Name = "dtAccount";
            // 
            // dtInsert
            // 
            this.dtInsert.HeaderText = "Insert Bill";
            this.dtInsert.MinimumWidth = 6;
            this.dtInsert.Name = "dtInsert";
            // 
            // dtCheckout
            // 
            this.dtCheckout.HeaderText = "Check Out";
            this.dtCheckout.MinimumWidth = 6;
            this.dtCheckout.Name = "dtCheckout";
            // 
            // dtDate
            // 
            this.dtDate.HeaderText = "Date";
            this.dtDate.MinimumWidth = 6;
            this.dtDate.Name = "dtDate";
            // 
            // dtTotal
            // 
            this.dtTotal.HeaderText = "Total Price";
            this.dtTotal.MinimumWidth = 6;
            this.dtTotal.Name = "dtTotal";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(51, 501);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 59);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1110, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
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
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 572);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBurger)).EndInit();
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
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtTotal;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblNameRes;
        private System.Windows.Forms.PictureBox pictureIconBurger;
    }
}
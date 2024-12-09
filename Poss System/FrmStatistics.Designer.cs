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
            this.titlebar = new System.Windows.Forms.Panel();
            this.pictureIconMenu = new System.Windows.Forms.PictureBox();
            this.lblNameRes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clInsert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 572);
            this.panel1.TabIndex = 0;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(43)))));
            this.titlebar.Controls.Add(this.pictureIconMenu);
            this.titlebar.Controls.Add(this.lblNameRes);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1240, 58);
            this.titlebar.TabIndex = 1;
            // 
            // pictureIconMenu
            // 
            this.pictureIconMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureIconMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureIconMenu.Image = global::Poss_System.Properties.Resources.list1;
            this.pictureIconMenu.Location = new System.Drawing.Point(1169, 16);
            this.pictureIconMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureIconMenu.Name = "pictureIconMenu";
            this.pictureIconMenu.Size = new System.Drawing.Size(63, 32);
            this.pictureIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIconMenu.TabIndex = 6;
            this.pictureIconMenu.TabStop = false;
            // 
            // lblNameRes
            // 
            this.lblNameRes.AutoSize = true;
            this.lblNameRes.BackColor = System.Drawing.Color.Transparent;
            this.lblNameRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameRes.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRes.ForeColor = System.Drawing.Color.White;
            this.lblNameRes.Location = new System.Drawing.Point(12, 14);
            this.lblNameRes.Name = "lblNameRes";
            this.lblNameRes.Size = new System.Drawing.Size(94, 34);
            this.lblNameRes.TabIndex = 5;
            this.lblNameRes.Text = "Setting";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtAccount);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.txtBill);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblBill);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 58);
            this.panel2.TabIndex = 2;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(12, 24);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(52, 16);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "BILL ID:";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(70, 21);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(194, 22);
            this.txtBill.TabIndex = 1;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(289, 24);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(76, 16);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "ACCOUNT:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(773, 21);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(228, 22);
            this.txtDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(709, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "DATE:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(371, 21);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(314, 22);
            this.txtAccount.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1093, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clBill,
            this.clAccount,
            this.clInsert,
            this.clCheckOut,
            this.clDate,
            this.clTotal});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 127);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1234, 391);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clBill
            // 
            this.clBill.Text = "Bill ID";
            this.clBill.Width = 128;
            // 
            // clAccount
            // 
            this.clAccount.Text = "Account";
            this.clAccount.Width = 273;
            // 
            // clInsert
            // 
            this.clInsert.Text = "InsertBill";
            this.clInsert.Width = 184;
            // 
            // clCheckOut
            // 
            this.clCheckOut.Text = "Check out";
            this.clCheckOut.Width = 226;
            // 
            // clDate
            // 
            this.clDate.Text = "Date";
            this.clDate.Width = 197;
            // 
            // clTotal
            // 
            this.clTotal.Text = "Total Price";
            this.clTotal.Width = 221;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1117, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Del";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(439, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 27);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1240, 572);
            this.panel4.TabIndex = 5;
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            this.panel1.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.PictureBox pictureIconMenu;
        private System.Windows.Forms.Label lblNameRes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clBill;
        private System.Windows.Forms.ColumnHeader clAccount;
        private System.Windows.Forms.ColumnHeader clInsert;
        private System.Windows.Forms.ColumnHeader clCheckOut;
        private System.Windows.Forms.ColumnHeader clDate;
        private System.Windows.Forms.ColumnHeader clTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
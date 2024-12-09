namespace Poss_System
{
    partial class FrmSetting
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSellPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPurchasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtFindType = new System.Windows.Forms.TextBox();
            this.txtFindID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.titlebar = new System.Windows.Forms.Panel();
            this.pictureIconMenu = new System.Windows.Forms.PictureBox();
            this.lblNameRes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 616);
            this.panel1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clName,
            this.clType,
            this.clSellPrice,
            this.clPurchasePrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1544, 382);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clID
            // 
            this.clID.Text = "ID";
            this.clID.Width = 68;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clName.Width = 218;
            // 
            // clType
            // 
            this.clType.Text = "Type";
            this.clType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clType.Width = 153;
            // 
            // clSellPrice
            // 
            this.clSellPrice.Text = "Sell Price";
            this.clSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSellPrice.Width = 522;
            // 
            // clPurchasePrice
            // 
            this.clPurchasePrice.Text = "Purchase Price";
            this.clPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPurchasePrice.Width = 586;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFindName);
            this.panel2.Controls.Add(this.txtFindType);
            this.panel2.Controls.Add(this.txtFindID);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1544, 73);
            this.panel2.TabIndex = 3;
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(864, 21);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(295, 22);
            this.txtFindName.TabIndex = 6;
            // 
            // txtFindType
            // 
            this.txtFindType.Location = new System.Drawing.Point(439, 21);
            this.txtFindType.Name = "txtFindType";
            this.txtFindType.Size = new System.Drawing.Size(295, 22);
            this.txtFindType.TabIndex = 6;
            // 
            // txtFindID
            // 
            this.txtFindID.Location = new System.Drawing.Point(41, 21);
            this.txtFindID.Name = "txtFindID";
            this.txtFindID.Size = new System.Drawing.Size(295, 22);
            this.txtFindID.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(811, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(391, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1367, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 41);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 530);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 59);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(122, 530);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 59);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(232, 530);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 59);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1396, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 59);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
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
            this.titlebar.Size = new System.Drawing.Size(1550, 58);
            this.titlebar.TabIndex = 4;
            // 
            // pictureIconMenu
            // 
            this.pictureIconMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureIconMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureIconMenu.Image = global::Poss_System.Properties.Resources.list1;
            this.pictureIconMenu.Location = new System.Drawing.Point(1479, 16);
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
            this.lblNameRes.Size = new System.Drawing.Size(119, 34);
            this.lblNameRes.TabIndex = 5;
            this.lblNameRes.Text = "Statistics";
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 616);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSetting";
            this.Text = "Setting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.TextBox txtFindType;
        private System.Windows.Forms.TextBox txtFindID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clType;
        private System.Windows.Forms.ColumnHeader clSellPrice;
        private System.Windows.Forms.ColumnHeader clPurchasePrice;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.PictureBox pictureIconMenu;
        private System.Windows.Forms.Label lblNameRes;
    }
}
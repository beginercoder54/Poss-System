namespace Poss_System
{
    partial class FrmMore
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
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblModify = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIname = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.dgvIngredient = new System.Windows.Forms.DataGridView();
            this.IngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btndelIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(325, 191);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(189, 22);
            this.txtPurchase.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(325, 148);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(189, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(325, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(325, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(98, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.Location = new System.Drawing.Point(244, 194);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(64, 16);
            this.lblModify.TabIndex = 4;
            this.lblModify.Text = "BuyPrice:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(244, 151);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Sell Price:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(244, 103);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 16);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Category:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(244, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(244, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(72, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "Product ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtIname
            // 
            this.txtIname.Location = new System.Drawing.Point(24, 269);
            this.txtIname.Name = "txtIname";
            this.txtIname.Size = new System.Drawing.Size(198, 22);
            this.txtIname.TabIndex = 7;
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(237, 269);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(198, 22);
            this.txtKg.TabIndex = 8;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(453, 268);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(37, 24);
            this.btnAddIngredient.TabIndex = 9;
            this.btnAddIngredient.Text = "+";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // dgvIngredient
            // 
            this.dgvIngredient.AllowUserToAddRows = false;
            this.dgvIngredient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientName,
            this.clKg});
            this.dgvIngredient.EnableHeadersVisualStyles = false;
            this.dgvIngredient.Location = new System.Drawing.Point(-1, 306);
            this.dgvIngredient.Name = "dgvIngredient";
            this.dgvIngredient.RowHeadersVisible = false;
            this.dgvIngredient.RowHeadersWidth = 51;
            this.dgvIngredient.RowTemplate.Height = 24;
            this.dgvIngredient.Size = new System.Drawing.Size(551, 346);
            this.dgvIngredient.TabIndex = 17;
            this.dgvIngredient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredient_CellClick);
            // 
            // IngredientName
            // 
            this.IngredientName.DataPropertyName = "ingredientName";
            this.IngredientName.HeaderText = "IngredientName";
            this.IngredientName.MinimumWidth = 6;
            this.IngredientName.Name = "IngredientName";
            // 
            // clKg
            // 
            this.clKg.DataPropertyName = "kg";
            this.clKg.HeaderText = "Kg";
            this.clKg.MinimumWidth = 6;
            this.clKg.Name = "clKg";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(12, 669);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShort.Location = new System.Drawing.Point(123, 669);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(89, 29);
            this.btnShort.TabIndex = 12;
            this.btnShort.Text = "Short";
            this.btnShort.UseVisualStyleBackColor = false;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(447, 668);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 29);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btndelIn
            // 
            this.btndelIn.Location = new System.Drawing.Point(502, 268);
            this.btndelIn.Name = "btndelIn";
            this.btndelIn.Size = new System.Drawing.Size(34, 23);
            this.btndelIn.TabIndex = 10;
            this.btndelIn.Text = "-";
            this.btndelIn.UseVisualStyleBackColor = true;
            this.btndelIn.Click += new System.EventHandler(this.btndelIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingredient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kg";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(24, 213);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(89, 29);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Items.AddRange(new object[] {
            "Food",
            "Drink",
            "Dessert",
            "Alcohol"});
            this.cbbCategory.Location = new System.Drawing.Point(325, 100);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(189, 24);
            this.cbbCategory.TabIndex = 22;
            // 
            // FrmMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 709);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvIngredient);
            this.Controls.Add(this.btndelIn);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtIname);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblModify);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPurchase;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtIname;
        public System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Button btnAddIngredient;
        public System.Windows.Forms.DataGridView dgvIngredient;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btndelIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKg;
        public System.Windows.Forms.ComboBox cbbCategory;
    }
}
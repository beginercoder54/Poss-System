namespace Poss_System.Component
{
    partial class Widget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.imgImage);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 161);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "$";
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCost.ForeColor = System.Drawing.Color.Chocolate;
            this.lblCost.Location = new System.Drawing.Point(42, 101);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(94, 46);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "4.00";
            // 
            // imgImage
            // 
            this.imgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgImage.Image = ((System.Drawing.Image)(resources.GetObject("imgImage.Image")));
            this.imgImage.Location = new System.Drawing.Point(207, 20);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(136, 127);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImage.TabIndex = 2;
            this.imgImage.TabStop = false;
            this.imgImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ranch Burger";
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Widget";
            this.Size = new System.Drawing.Size(366, 174);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblCost;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox imgImage;
    }
}

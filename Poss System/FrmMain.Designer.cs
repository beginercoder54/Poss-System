﻿namespace Poss_System
{
    partial class FrmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureIconMenu = new System.Windows.Forms.PictureBox();
            this.lblNameRes = new System.Windows.Forms.Label();
            this.pictureIconBurger = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(43)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureIconMenu);
            this.panel2.Controls.Add(this.lblNameRes);
            this.panel2.Controls.Add(this.pictureIconBurger);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 58);
            this.panel2.TabIndex = 1;
            // 
            // pictureIconMenu
            // 
            this.pictureIconMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureIconMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureIconMenu.Image = global::Poss_System.Properties.Resources.list1;
            this.pictureIconMenu.Location = new System.Drawing.Point(893, 14);
            this.pictureIconMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureIconMenu.Name = "pictureIconMenu";
            this.pictureIconMenu.Size = new System.Drawing.Size(63, 32);
            this.pictureIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIconMenu.TabIndex = 4;
            this.pictureIconMenu.TabStop = false;
            // 
            // lblNameRes
            // 
            this.lblNameRes.AutoSize = true;
            this.lblNameRes.BackColor = System.Drawing.Color.Transparent;
            this.lblNameRes.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRes.ForeColor = System.Drawing.Color.White;
            this.lblNameRes.Location = new System.Drawing.Point(85, 12);
            this.lblNameRes.Name = "lblNameRes";
            this.lblNameRes.Size = new System.Drawing.Size(282, 34);
            this.lblNameRes.TabIndex = 3;
            this.lblNameRes.Text = "Tam Thai Tu Restaurant";
            // 
            // pictureIconBurger
            // 
            this.pictureIconBurger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureIconBurger.BackColor = System.Drawing.Color.Transparent;
            this.pictureIconBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureIconBurger.Image = global::Poss_System.Properties.Resources.burger;
            this.pictureIconBurger.Location = new System.Drawing.Point(16, 11);
            this.pictureIconBurger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureIconBurger.Name = "pictureIconBurger";
            this.pictureIconBurger.Size = new System.Drawing.Size(63, 32);
            this.pictureIconBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIconBurger.TabIndex = 2;
            this.pictureIconBurger.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 532);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconBurger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureIconBurger;
        private System.Windows.Forms.Label lblNameRes;
        private System.Windows.Forms.PictureBox pictureIconMenu;
    }
}
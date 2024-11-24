using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poss_System.Component
{
    public partial class Widget : UserControl
    {
        private categories _category;
        public event EventHandler OnSelect = null;
        private Label lblTitle;
        private PictureBox imgImage;

        public Widget()
        {
            InitializeComponent();
            lblTitle = new Label
            {
                AutoSize = true,
                Location = new Point(10, 10),
                Text = "Title"
            };
            this.Controls.Add(lblTitle);

            imgImage = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10, 40),
                Size = new Size(100, 100)
            };
            this.Controls.Add(imgImage);
        }

        public enum categories { Food, Alcohol, ColdDrinks, HotDrinks, Desserts }
        public categories Category { get => _category; set => _category = value; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string Cost { get => lblTitle.Text; set => lblTitle.Text = value; } 
        public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}

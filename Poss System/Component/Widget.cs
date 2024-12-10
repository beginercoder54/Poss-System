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
        public event EventHandler OnSelect = null;


        public Widget()
        {
            InitializeComponent();
          
        }

        public string Category { get; set; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public decimal Cost { get ; set; } 
        public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}

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
    public partial class InfoReceipt : UserControl
    {
        public InfoReceipt()
        {
            InitializeComponent();
        }

        public string Quantity { get => lblQuantity.Text; set => lblQuantity.Text = value; }
        public string Name { get => lblName.Text; set => lblName.Text = value; }
        public string Price { get => lblPrice.Text.Replace(",","."); set => lblPrice.Text = value.ToString(); }
    }
}

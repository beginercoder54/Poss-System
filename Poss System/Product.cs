using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poss_System
{
    public class Product
    {

        private string id;
        private string name;
        private string category;
        private double sellPrice;
        private double purchase;
        Image img;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public double SellPrice { get => sellPrice; set => sellPrice = value; }
        public double Purchase { get => purchase; set => purchase = value; }
        public Image Img { get => img; set => img = value; }
    }
}

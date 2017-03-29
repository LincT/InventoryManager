using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Item
    {
        private string type, color, size,desc;
        private decimal price;
        public Item() { }

        public Item(string desc,string type, string color, string size, decimal price)
        {
            this.desc = desc;
            this.type = type;
            this.color = color;
            this.size = size;
            this.price = price;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string GetDisplayText()
        {
            string output = desc +", "+ type + ", " + color + ", " + size + ": $" + price.ToString();
            return output;
        }
    }
}

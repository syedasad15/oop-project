using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace buisnessApplicationOOP.BL
{
    public class manager : pharmacy
    {
        private int price;

        public manager(string name, int price,int quantity):base(name,quantity) 
        {
            this.Price = price;
        }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public int Price { get => price; set => price = value; }

        public override int getPrice()
        {
            return Price;
        }
        public override void setPrice(int price)
        {
            this.Price = price;
        }
    }
}

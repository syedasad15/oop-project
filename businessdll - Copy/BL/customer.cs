using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessApplicationOOP.BL
{
    public class customer : pharmacy
    {
        private int customerPrice;

        List<customer> cart;
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int CustomerPrice { get => customerPrice; set => customerPrice = value; }

        public customer(string name,int quantity):base(name,quantity)
        {
            this.cart = new List<customer>();
        }

        public int calculateLBill()
        {
            int bill = 0;
            foreach(var i in cart)
            {
                bill += i.CustomerPrice * i.Quantity;
            }
            return bill;
        }
        public void addProductInCart(customer product)
        {
            cart.Add(product);
        }

        public List<customer> getCartList()
        {
            return cart;
        }
        

        public override void setProductPrice(int price)
        {
            this.CustomerPrice = price;
        }
        public string toString()
        {
            string a = getName() + getQuantity().ToString() + CustomerPrice.ToString();
            return a;
        }
        public override int getPrice()
        {
            return CustomerPrice;
        }

        public static bool checkInt(string item)
        {
            bool flag = false;
            int count = 0;
            foreach (var i in item)
            {
                int num = i - '0';
                if (num >= 0 && num <= 9)
                {
                    count++;
                }
            }
            if (count == item.Length)
            {
                flag = true;
            }
            return flag;
        }
    }
}

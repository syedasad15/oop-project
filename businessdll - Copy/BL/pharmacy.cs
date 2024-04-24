using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessApplicationOOP.BL
{
    public class pharmacy
    {
        protected string name;
        protected int quantity;

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public pharmacy(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public string getName()
        {
            return Name;
        }
        public int getQuantity()
        {
            return Quantity;
        }
        public void setQuantity(int i)
        {
            Quantity = i;
        }
        public virtual int getPrice()
        {
            return 0;
        }
        public virtual void setPrice(int price) 
        {
            
        }

        public virtual void setProductPrice(int price)
        {
   
        }
    }
}

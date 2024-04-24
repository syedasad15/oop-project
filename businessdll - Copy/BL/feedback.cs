using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessApplicationOOP.BL
{
    public class feedback
    {
        private string name;
        private string description;
        public feedback(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        
       
    }
}

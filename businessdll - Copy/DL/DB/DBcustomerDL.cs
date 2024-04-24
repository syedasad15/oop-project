using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessApplicationOOP.DL
{
    public class customerDL
    {
        public static List<customer> custList = new List<customer>();

        public static void addInCustList(customer c)
        {
            custList.Add(c);
        }
    }
}

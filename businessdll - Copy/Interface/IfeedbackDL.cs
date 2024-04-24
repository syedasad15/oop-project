using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessdll.Interface
{
    internal interface IfeedbackDL
    {
        void addInList(feedback f);
        void addFeedBackDataInFile(string path);
        bool readFromFile(string path);
    }
}

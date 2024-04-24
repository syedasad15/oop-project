using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace buisnessApplicationOOP.DL
{
    public class feedbackDL
    {
        public static  List<feedback> feedbackDLList = new List<feedback>();

         public static void addInList(feedback f)
        {
            feedbackDLList.Add(f);
        }
        public static void addFeedBackDataInFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < feedbackDLList.Count(); i++)
            {
                f.WriteLine(feedbackDLList[i].Name + "," + feedbackDLList[i].Description);

            }
            f.Close();

        }
        public static bool readFromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != string.Empty)
                {
                    string[] splittedRec = record.Split(',');
                    string name = splittedRec[0];
                    string description = splittedRec[1];
                    feedback n = new feedback(name, description);
                    addInList(n);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;

namespace buisnessApplicationOOP.DL
{
    public class UserDLDB
    {
        static List<User> Users = new List<User>();

        public static void AddUserInList(User U)
        {
            Users.Add(U);
           
        }
        public static void AddUserDataINFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            for(int i=0; i<Users.Count; i++)
            {
                f.WriteLine(Users[i].GetName() + "," + Users[i].GetPassword() + "," + Users[i].GetRole());
            }
            f.Close();
        }
        public static bool ReadFromFile(string path)
        {
            string record;
            if(File.Exists(path)) 
            {
                StreamReader f = new StreamReader(path);
                while((record = f.ReadLine())!= null)
                {
                    if(record == "")
                    {
                        break;
                    }
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    signUp n = new signUp(role, name, password);
                    AddUserInList(n);

                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void addAdmin()
        {
            string name = "asad";
            string password = "ali";
            string role = "admin";
            signUp s = new signUp(role,name, password);
            Users.Add(s);
        }
        public static bool CheckValid(signUp S)
        {
            bool flag = true;
            foreach (var a in Users)
            {
                if (S.GetName() == a.GetName())
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        public  static string GetRoleForSignIn(signIn S)
        {
            string role = "";
            foreach (var a in Users)
            {
                if (S.GetName() == a.GetName() && S.GetPassword() == a.GetPassword())
                {
                    role = a.GetRole();
                    break;
                }
            }
            return role;
        }
        public static int getIndex(string name,string pass)
        {
            int index = -1;
            for (int i = 0; i < Users.Count; i++)
            {
                if (name == Users[i].GetName() && pass == Users[i].GetPassword())
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static void updatePass(int index, string pass)
        {
            Users[index].setPass(pass);
        }
    }
}

using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessdll.Interface
{
    internal interface IUserDL
    {
        void AddUserInList(User U);
        void AddUserDataINFile(string path);
        bool ReadFromFile(string path);
        void addAdmin();
        bool CheckValid(signUp S);
        string GetRoleForSignIn(signIn S);
        int getIndex(string name, string pass);
        void updatePass(int index, string pass);
        bool validateUser(User user);
        bool storeUserIntoDb(User user);
        List<User> getAllUsers(string dbConnectionString);
      
    }
}

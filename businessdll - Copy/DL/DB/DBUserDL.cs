using buisnessApplicationOOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
using System.Data.SqlClient;

namespace buisnessApplicationOOP.DL
{
    public class UserDL
    {
        public static List<User> Users = new List<User>();

        public static void AddUserInList(User U)
        {
            Users.Add(U);

        }

        private static bool validateUser(User user)
        {



            string connectionString = "Server=DESKTOP-B10A0HU\\SQLEXPRESS;Database=MUSER;Trusted_Connection=True;";
            // string connectionString = @"Data Source=(local);Initial Catalog=MUSER;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from MUser where userName = '{0}'", user.GetName());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public static bool storeUserIntoDb(User user)
        {
            string connectionString = "Server=DESKTOP-B10A0HU\\SQLEXPRESS;Database=MUSER;Trusted_Connection=True;";
            //string connectionString = @"Data Source=(local);Initial Catalog=MUSER;Integrated Security=True";
            if (!validateUser(user))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = String.Format("insert into MUser (userName, userPassword, userRole) VALUES('{0}', '{1}', '{2}')", user.GetName(), user.GetPassword(), user.GetRole());
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;

        }
        public static List<User> getAllUsers(string dbConnectionString)
        {
            List<User> usersList = new List<User>();
            SqlConnection connection = new SqlConnection(dbConnectionString);
            connection.Open();
            string query = "SELECT * FROM MUser";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["UserName"].ToString();
                string pass = reader["UserPassword"].ToString();
                string role = reader["UserRole"].ToString();
                User user = new signUp(role, name, pass);
                //Userdata user = new Userdata(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                usersList.Add(user);
            }
            connection.Close();
            return usersList;
        }

        public static void addAdmin()
        {
            string name = "asad";
            string password = "ali";
            string role = "admin";
            signUp s = new signUp(role, name, password);
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

        public static string GetRoleForSignIn(signIn S)
        {
            string role = "";
            foreach (var a in Users)
            {
                if (S.GetName() == a.GetName() && S.GetPassword() == a.GetPassword())
                {
                    role = a.GetRole();
                }
            }
            return role;
        }
        public static int getIndex(string name, string pass)
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

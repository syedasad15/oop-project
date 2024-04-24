using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessApplicationOOP.BL
{
    public class User
    {
        protected string Username;
        protected string Password;

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public string GetName()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }

        public virtual string GetRole()
        {
            return "";
        }
        public void setPass(string pass)
        {
            this.Password = pass;
        }
        public void setName(string name)
        {
            this.Username = name;
        }
        public virtual void setRole(string role)
        {

        }
    }
}

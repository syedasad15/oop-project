using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnessApplicationOOP.BL
{
    public class signUp : User
    {
        private string Role;

        public signUp(string Role, string Username, string Password) : base(Username, Password)
        {
            this.Role = Role;
        }

        public override string GetRole()
        {
            return Role;
        }
        public override void setRole(string role)
        {
            this.Role=role;
        }
    }
}

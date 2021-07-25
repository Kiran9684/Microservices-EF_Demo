using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtRoleBasedAuthentication.Modals
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailID { get; set; }
        public string RoleModel { get; set; }
    }
}

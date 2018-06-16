using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCare.EL
{
    class User
    {
        public String Key { get; set; }
        public int RoleID { get; set; }
        public String UserName { get; set; }
        public int UserImage { get; set; }
        public String UserCode { get; set; }
        public String Special { get; set; }

        public List<User> userList { get; set; }

    }
}

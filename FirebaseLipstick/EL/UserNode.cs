using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrCare.EL
{
    class UserNode
    {
        public String UserKey { get; set; }

        public User user { get; set; }

        public UserNode(String key, User user)
        {
            this.UserKey = key;
            this.user = user;
        }

    }
}

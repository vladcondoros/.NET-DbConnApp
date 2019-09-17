using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnTest
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }

        public string FullUserInfo
        {
            get
            {
                return $"{ Name } { Role } { Location }";
            }
        }
    }
}

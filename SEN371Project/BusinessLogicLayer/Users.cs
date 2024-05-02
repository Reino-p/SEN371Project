using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371Project.BusinessLogicLayer
{
    internal class Users
    {
        //properties
        string email { get; set; }
        string password { get; set; }
        string name { get; set; }
        string surname { get; set; }

        //constructor
        public Users(string e, string p, string n, string s)
        {
            this.email = e;
            this.password = p;
            this.name = n;
            this.surname = s;
        }

        //methods
        public void createUser()
        {
            //enter user details into repository
        }

        public string getUser()
        {
            //return user details from repository
            return "";
        }

        public string updateUser()
        {
            //update user details in the repository
            return "";
        }

        public string deleteUser()
        {
            //remove the user details from repository
            return "";
        }
    }
}

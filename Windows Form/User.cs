using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Project
{
    public class User
    {
        public string National_Number
        {
            set;
            get;
        }
        public string Password
        {
            get;
            set;
        }
        string Phone_Number;
        public User()
        {
            National_Number = "";
            Password = "";

        }
        public User(string national_Number, string password)
        {
            National_Number = national_Number;
            Password = password;
        }

        public bool EasterEgg()
        {
            if(!(National_Number == ""))
            {
                return true;
            }
            return false;
        }
    }
}

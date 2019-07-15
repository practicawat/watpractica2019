using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class InfoUser
    {
        public int ID_user { get; set; }
        public string First_Name { get;  private set; }
        public string Last_Name { get; private set; }
        public string Email { get; private set; }
        public int Phone_Number { get; private set; }

        public InfoUser()
        {

        }

        public InfoUser(string first_name, string last_name, string email,
            int phone)
        {
            this.First_Name = first_name;
            this.Last_Name = last_name;
            this.Email = email;
            this.Phone_Number = phone;
        }

    }
}

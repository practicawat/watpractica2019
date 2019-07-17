using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class InfoUser
    {
        [Key]
        public int IdUser { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Int32 PhoneNumber { get; set; }

        public InfoUser()
        {

        }

        public InfoUser(int id,string firstName, string lastName, string email,
            int phone)
        {
            this.IdUser=id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phone;
        }

    }
}

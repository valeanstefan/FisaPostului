using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class UserDto
    {
        public int id { get; set; }

        public string username { get; set; }

        public string user_password { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }
    }
}
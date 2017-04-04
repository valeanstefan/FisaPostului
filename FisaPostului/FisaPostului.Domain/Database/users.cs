namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int id { get; set; }

        public string username { get; set; }

        public string user_password { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }
    }
}

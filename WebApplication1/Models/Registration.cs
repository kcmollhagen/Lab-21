using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Registration
    {
        [Key]
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
        public string occupation { get; set; }
        public string city { get; set; }
        public string favoriteRoast { get; set; }

    }

    public class DBRegistrationContext : DbContext
    {
        public DbSet<Registration> Registration { get; set; }
    }
}
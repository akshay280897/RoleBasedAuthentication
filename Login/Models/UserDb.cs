using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class UserDb : DbContext
    {
        public UserDb() : base("DefaultConnection")
        {
            Database.SetInitializer<UserDb>(new CreateDatabaseIfNotExists<UserDb>());
        }
        public DbSet<User> users { get; set; }
    }
}
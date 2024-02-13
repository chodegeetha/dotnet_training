using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webmvc.Models
{
    public class UserContext : DbContext
    {
        public static string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public DbSet<User_Table> Users { get; set; }
        public UserContext() : base(conn)
        {

        }

    }
}
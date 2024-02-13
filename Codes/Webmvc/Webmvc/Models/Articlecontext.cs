using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;


namespace Webmvc.Models
{
    public class Articlecontext:DbContext
    {
        public static string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public DbSet<Articlemodel> Articles { get; set; }
        public DbSet<User_Table> Users { get; set; }
        public DbSet<Category_Table> Categories { get; set; }

        public Articlecontext() : base(conn)
        {

        }




    }
}
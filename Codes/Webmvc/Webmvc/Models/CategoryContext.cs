using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webmvc.Models
{
    public class CategoryContext:DbContext
    {
        public static string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public DbSet<Category_Table> categories { get; set; }
        public CategoryContext() : base(conn)
        {

        }

    }
}
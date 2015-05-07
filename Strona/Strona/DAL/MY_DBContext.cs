using Strona.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Strona.DAL
{
    public class MY_DBContext : DbContext
    {
        public MY_DBContext() : base("UsersPolaczenie") { }

        static MY_DBContext()
        {
            Database.SetInitializer<MY_DBContext>(new MY_DBInitializer());
        }

        public DbSet<Users> Users { get; set; }

    }
}
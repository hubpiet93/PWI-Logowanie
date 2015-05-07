using Strona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using Strona.Migrations;

namespace Strona.DAL
{
    public class MY_DBInitializer : MigrateDatabaseToLatestVersion<MY_DBContext, Configuration>
    {
        //protected override void Seed(MY_DBContext context)
        //{
        //    SeedZaliczenieData(context);
        //    base.Seed(context);
        //}



        public static void SeedUsersData(MY_DBContext context)
        {
            var users = new List<Users>
            {
                new Users(){UserId=1,UserName="hubpiet93",Nationality="Poland",City="Warsaw",E_mail="pietruczukhubert@gmail.com",Password="haselko",Phone="519854891"},
                new Users(){UserId=2,UserName="grother",Nationality="Poland",City="Warsaw",E_mail="hubertpietruczuk@interia.pl",Password="nic",Phone="519854891"},
                
            };
            users.ForEach(user => context.Users.AddOrUpdate(user));
            context.SaveChanges();

        }
    }
}
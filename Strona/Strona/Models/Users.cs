using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Strona.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string City { get; set; }
        public string Nationality{ get; set; }
        public string E_mail { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }


        public virtual ICollection<Users> Uzytkownicy { get; set; }
    }
}
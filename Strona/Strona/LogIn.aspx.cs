using Strona.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Strona
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            witaj.Text = "";
            try
            {
                string text1 = Server.HtmlEncode(Request.Cookies["torcik"]["name"]);
                witaj.Text = text1;
                wyloguj_btn1.Visible = true;
            }
            catch (Exception)
            {
                witaj.Text = "";
                wyloguj_btn1.Visible = false;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var context = new DAL.MY_DBContext();
            errors_text.Text = "";
            if (!(hasłot.Text == "" || logint.Text == "" || witaj.Text !=""))
            {
                try
                {
                    Users login = context.Users.SingleOrDefault<Users>(x =>logint.Text==x.E_mail );//pobranie do zmiennej kolesia z szukanym loginem
                    
                    if (hasłot.Text == HashingPasswords.Kodowanie.Decrypt(login.Password))
                    {
                        Response.Cookies["torcik"]["name"] = login.UserName.ToString() ;
                        Response.Cookies["torcik"].Expires = DateTime.Now.AddDays(1);
                        Response.Write(Request.RawUrl.ToString());
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        errors_text.Text = "Błędne Hasło";
                    }

                    //Page.ClientScript.RegisterStartupScript(
                    //    this.GetType(),
                    //    "alert" + UniqueID,
                    //    "alert('" + "login:" + login.E_mail.ToString() + "');",
                    //    true);
                   
                }
                catch (Exception)
                {
                    errors_text.Text = "Błędny login";
                }  
            }
            else
            {
                errors_text.Text = "Zapomniałeś podać login lub hasło";
                if (witaj.Text != "")
                {
                    errors_text.Text = "Chyba już ktoś jest zalogowany";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void wyloguj_btn_Click(object sender, EventArgs e)
        {
            Response.Cookies["torcik"].Expires = DateTime.Now.AddDays(-3);
            Response.Write(Request.RawUrl.ToString());
            Response.Write(Request.RawUrl.ToString());
            witaj.Text = "";
            wyloguj_btn1.Visible = false;
        }
    }
}
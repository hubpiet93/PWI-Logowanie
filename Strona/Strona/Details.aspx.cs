using Strona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Strona
{
    public partial class Details : System.Web.UI.Page
    {
        DAL.MY_DBContext context = new DAL.MY_DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            witaj.Text = "";
            username_label.Text = "";
            city_label.Text = "";
            nationality_label.Text="";
            email_label.Text = "";
            phone_label.Text = "";
            try
            {
                string text1 = Server.HtmlEncode(Request.Cookies["torcik"]["name"]);
                witaj.Text = text1;
                wyloguj_btn1.Visible = true;
                Zarejestruj.Visible = false;
                Zaloguj.Visible = false;
                ShowInfo();
            }
            catch (Exception)
            {
                witaj.Text = "";
                wyloguj_btn1.Visible = false;
                Zarejestruj.Visible = true;
                Zaloguj.Visible = true;
            }
        }

        protected void wyloguj_btn_Click(object sender, EventArgs e)
        {
            Response.Cookies["torcik"].Expires = DateTime.Now.AddDays(-3);
            Response.Write(Request.RawUrl.ToString());
            Response.Write(Request.RawUrl.ToString());
            witaj.Text = "";
            wyloguj_btn1.Visible = false;
            Response.Redirect("Details.aspx");
        }

        protected void Zarejestruj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Zaloguj_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }

        protected void Wroc_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        private void ShowInfo() //To już będzie wywowałne kiedy będziemy zalogowani 
        {
            try
            {
                //pobranie usera z ciasteczka
                string current_user_name = Server.HtmlEncode(Request.Cookies["torcik"]["name"]);
                //pobranie usera

                Users current_user = context.Users.First(user => user.UserName ==current_user_name); 
                //wyświetlenie danych

                username_label.Text = current_user.UserName;
                city_label.Text = current_user.City;
                nationality_label.Text = current_user.Nationality;
                email_label.Text = current_user.E_mail;
                phone_label.Text = current_user.Phone;
            }
            catch (Exception)
            {
            }


        }
    }
}
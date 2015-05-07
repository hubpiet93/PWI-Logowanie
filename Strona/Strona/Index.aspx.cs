using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Strona
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            witaj.Text = "";
            Slajd1.ImageUrl = "images/1.jpg";
            Slajd2.ImageUrl = "images/2.jpg";
            Slajd3.ImageUrl = "images/3.jpg";
            Slajd4.ImageUrl = "images/4.jpg";
            Slajd5.ImageUrl = "images/5.jpg";
            

            Ikona1.ImageUrl = "images/Icons/programming.png";
            Ikona1.CssClass = "img-responsive";
            Ikona1.AlternateText = "Zdjecie sie nie wczytalo";
            Ikona2.ImageUrl = "images/Icons/css8.png";
            Ikona2.CssClass = "img-responsive";
            Ikona2.AlternateText = "Zdjecie sie nie wczytalo";
            Ikona3.ImageUrl = "images/Icons/html.png";
            Ikona3.CssClass = "img-responsive";
            Ikona3.AlternateText = "Zdjecie sie nie wczytalo";
            Ikona4.ImageUrl = "images/Icons/javascript.png";
            Ikona4.CssClass = "img-responsive";
            Ikona4.AlternateText = "Zdjecie sie nie wczytalo";

            Zadanie1.ImageUrl = "images/zadania/1.jpg";
            Zadanie1.CssClass = "img-responsive thumbnail";
            Zadanie1.AlternateText = "Zdjecie sie nie wczytalo";

            Zadanie2.ImageUrl = "images/zadania/1.jpg";
            Zadanie2.CssClass = "img-responsive thumbnail";
            Zadanie2.AlternateText = "Zdjecie sie nie wczytalo";

            Zadanie3.ImageUrl = "images/zadania/1.jpg";
            Zadanie3.CssClass = "img-responsive thumbnail";
            Zadanie3.AlternateText = "Zdjecie sie nie wczytalo";

            Zadanie3.ImageUrl = "images/zadania/1.jpg";
            Zadanie3.CssClass = "img-responsive thumbnail";
            Zadanie3.AlternateText = "Zdjecie sie nie wczytalo";

            Zadanie4.ImageUrl = "images/zadania/1.jpg";
            Zadanie4.CssClass = "img-responsive thumbnail";
            Zadanie4.AlternateText = "Zdjecie sie nie wczytalo";

            Zadanie5.ImageUrl = "images/zadania/1.jpg";
            Zadanie5.CssClass = "img-responsive thumbnail";
            Zadanie5.AlternateText = "Zdjecie sie nie wczytalo";

            Zadanie6.ImageUrl = "images/zadania/1.jpg";
            Zadanie6.CssClass = "img-responsive thumbnail";
            Zadanie6.AlternateText = "Zdjecie sie nie wczytalo";


            Me.ImageUrl = "images/me1.jpg";
            Me.CssClass = "img-circle img-responsive";
            
            Me_Modal.ImageUrl = "images/me1.jpg";
            Me_Modal.CssClass = "img-rounded  img-responsive";

            

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
        protected void wyloguj_btn_Click(object sender, EventArgs e) 
        {
            Response.Cookies["torcik"].Expires = DateTime.Now.AddDays(-3);
            Response.Write(Request.RawUrl.ToString());
            Response.Write(Request.RawUrl.ToString());
            witaj.Text = "";
            wyloguj_btn1.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Regex imienazwisko_test = new Regex("^[A-Za-z]{2,30} [A-Za-z]{2,30}$");
            Regex email_test = new Regex(@"^[a-z0-9\._%-]+@[a-z0-9\.-]+\.[a-z]{2,4}$");
            bool correct = true;
           
            Errors.Text = "";
            Good.Text = "";
            if (!imienazwisko_test.IsMatch((imienazwisko_text.Text).ToLower()))
            {
                correct = false;
                Errors.Text = Errors.Text + "Złe imie i nazwisko" + "<br/>";
            }
            if (!email_test.IsMatch((email_text.Text).ToLower()))
            {
                correct = false;
                Errors.Text = Errors.Text + "Zły email" + "<br/>";
            }

            if (correct == true)
            {
                Errors.Text = "";
                Good.Text = "Dane są poprawne";
            }
        }

        protected void Logowanie_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }

        protected void rejestracja_ods_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

    }
}
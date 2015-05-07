using Strona.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Strona
{
    public partial class Register : System.Web.UI.Page
    {
        DAL.MY_DBContext context = new DAL.MY_DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            witaj.Text = "";
            try
            {
                string text1 = Server.HtmlEncode(Request.Cookies["torcik"]["name"]);
                witaj.Text = text1;
                wyloguj_btn1.Visible = true;
                Zarejestruj.Visible = false;
                Label7.Text = "Jesteś zalogowany!!";
            }
            catch (Exception)
            {
                witaj.Text = "";
                wyloguj_btn1.Visible = false;
                Zarejestruj.Visible = true;
                Label7.Text = "";
            }

            #region
            NarodowościCombo.Items.Add("Albania");
            NarodowościCombo.Items.Add("Andora");
            NarodowościCombo.Items.Add("Austria");
            NarodowościCombo.Items.Add("Belgia");
            NarodowościCombo.Items.Add("Białoruś");
            NarodowościCombo.Items.Add("Bośnia i Hercegowina");
            NarodowościCombo.Items.Add("Bułgaria");
            NarodowościCombo.Items.Add("Chorwacja");
            NarodowościCombo.Items.Add("Czarnogóra");
            NarodowościCombo.Items.Add("Czechy");
            NarodowościCombo.Items.Add("Dania");
            NarodowościCombo.Items.Add("Estonia");
            NarodowościCombo.Items.Add("Finlandia");
            NarodowościCombo.Items.Add("Francja");
            NarodowościCombo.Items.Add("Grecja");
            NarodowościCombo.Items.Add("Hiszpania");
            NarodowościCombo.Items.Add("Holandia");
            NarodowościCombo.Items.Add("Irlandia");
            NarodowościCombo.Items.Add("Islandia");
            NarodowościCombo.Items.Add("Kazachstan");
            NarodowościCombo.Items.Add("Liechtenstein");
            NarodowościCombo.Items.Add("Litwa");
            NarodowościCombo.Items.Add("Luksemburg");
            NarodowościCombo.Items.Add("Łotwa");
            NarodowościCombo.Items.Add("Macedonia");
            NarodowościCombo.Items.Add("Malta");
            NarodowościCombo.Items.Add("Mołdawia");
            NarodowościCombo.Items.Add("Monako");
            NarodowościCombo.Items.Add("Niemcy");
            NarodowościCombo.Items.Add("Norwegia");
            NarodowościCombo.Items.Add("Polska");
            NarodowościCombo.Items.Add("Portugalia");
            NarodowościCombo.Items.Add("Rosja");
            NarodowościCombo.Items.Add("Rumunia");
            NarodowościCombo.Items.Add("San Marino");
            NarodowościCombo.Items.Add("Serbia");
            NarodowościCombo.Items.Add("Słowacja");
            NarodowościCombo.Items.Add("Słowenia");
            NarodowościCombo.Items.Add("Szwajcaria");
            NarodowościCombo.Items.Add("Szwecja");
            NarodowościCombo.Items.Add("Turcja");
            NarodowościCombo.Items.Add("Ukraina");
            NarodowościCombo.Items.Add("Watykan");
            NarodowościCombo.Items.Add("Węgry");
            NarodowościCombo.Items.Add("Wielka Brytania");
            NarodowościCombo.Items.Add("Włochy");
            #endregion
        }

        protected void wyloguj_btn_Click(object sender, EventArgs e)
        {
            Response.Cookies["torcik"].Expires = DateTime.Now.AddDays(-3);
            Response.Write(Request.RawUrl.ToString());
            Response.Write(Request.RawUrl.ToString());
            witaj.Text = "";
            wyloguj_btn1.Visible = false;
            Response.Redirect("Register.aspx");
        }

        protected void Zarejestruj_Click(object sender, EventArgs e) // rejestrowanie
        {
            bool można_rejestrować = true;
            //walidacja username

            if (username.Text == "")
            {
                error1.Text = "Pole nie może być puste";
                można_rejestrować = false;
            }
            else
            {
                error1.Text = "";
                Regex test1 = new Regex(@"^[A-Za-z0-9_-]{3,15}$");
                if (test1.IsMatch(username.Text))
                {
                    error1.Text = "";
                    można_rejestrować = true;
                }
                else
                {
                    error1.Text = "Niepoprawna nazwa użytkownika";
                    można_rejestrować = false;
                }
                można_rejestrować = true;
            }

            //walidacja city
            if (city.Text=="")
            {
                error2.Text = "Pole nie może być puste";
                można_rejestrować = false;
            }
            else
            {
                error2.Text = "";
                Regex test2 = new Regex(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$");
                if (test2.IsMatch(city.Text))
                {
                    error2.Text = "";
                    można_rejestrować = true;
                }
                else
                {
                    error2.Text = "Niepoprawne miasto";
                    można_rejestrować = false;
                }
                można_rejestrować = true;
            }


            //walidacja email
            if (e_mail.Text=="")
            {
                error3.Text = "Pole nie może być puste";
                można_rejestrować = false;
            }
            else
            {
                error3.Text = "";
                Regex test3 = new Regex(@"^[a-z0-9\._%-]+@[a-z0-9\.-]+\.[a-z]{2,4}$");
                if (test3.IsMatch(e_mail.Text))
                {
                    error3.Text = "";
                    można_rejestrować = true;
                }
                else
                {
                    error3.Text = "Niepoprawny email";
                    można_rejestrować = false;
                }
                można_rejestrować = true;
            }

            //walidacja phone
            if (phone.Text =="")
            {
                error4.Text = "Pole nie może być puste";
                można_rejestrować = false;
            }
            else
            {
                error4.Text = "";
                Regex test4 = new Regex(@"^[2-9]\d{2}-\d{3}-\d{3}$");
                if (test4.IsMatch(phone.Text))
                {
                    error4.Text = "";
                    można_rejestrować = true;
                }
                else
                {
                    error4.Text = "Niepoprawny numer telefonu";
                    można_rejestrować = false;
                }
                można_rejestrować = true;
            }

            //walidacja password
            if (password.Text == "")
            {
                error5.Text = "Pole nie może być puste";
                można_rejestrować = false;
            }
            else
            {
                error5.Text = "";
                Regex test5 = new Regex(@"^[a-zA-Z]\w{3,14}$");
                if (test5.IsMatch(password.Text))
                {
                    error5.Text = "";
                    można_rejestrować = true;
                }
                else
                {
                    error5.Text = "Niepoprawne hasło";
                    można_rejestrować = false;
                }
                można_rejestrować = true;
            }


            if (można_rejestrować==true)
            {
                //wpierw sprawdzimy czy takiej nazwy użytkownika już nie ma i czy nie istnieje ktoś z takim mailem 
                bool mailinazwa = true;

                bool check1 = context.Users.Any(u => u.UserName == username.Text);
                bool check2 = context.Users.Any(u => u.E_mail == e_mail.Text);

                if (check1 != false)
                {
                    error1.Text = "Taki użytkownik już istnieje";
                    mailinazwa = false;
                }
                else
                {
                    error1.Text = "";
                    mailinazwa = true;
                }

                if (check2 != false)
                {
                    error3.Text = "Podany adres email jest już zajęty";
                    mailinazwa = false;
                }
                else
                {
                    error3.Text = "";
                    mailinazwa = true;
                }


                if (mailinazwa==true) // i dopiero teraz mogę kogoś dodać do bazy
                {

                    string hash_password = HashingPasswords.Kodowanie.Encrypt(password.Text);
                    Users newuser = new Users() { UserName = username.Text, Nationality = NarodowościCombo.SelectedValue, City = city.Text, E_mail = e_mail.Text, Password = hash_password, Phone = phone.Text };
                    context.Users.Add(newuser);
                    context.SaveChanges();

                    Page.ClientScript.RegisterStartupScript(
                        this.GetType(),
                        "alert" + UniqueID,
                        "alert('" + "Rejestracja powiodła się" + "');",
                        true);
                    Response.Redirect("Index.aspx");
                }
            }
        }

        protected void Zaloguj_Click(object sender, EventArgs e) //przejdz do logowanie
        {
            Response.Redirect("LogIn.aspx");
        }

        protected void Wroc_Click(object sender, EventArgs e) // to home page
        {
            Response.Redirect("Index.aspx");
        }
    }
}
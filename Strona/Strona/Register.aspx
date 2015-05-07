<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Strona.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Hubert Pietruczuk</title>
    <!-- Style -->
    <link rel="stylesheet/less" type="text/css" href="css/moje.css" />
    <link rel="stylesheet" type="text/css" href="css/Animate.css" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <!-- LESS Script -->
    <script src="Scripts/less-1.5.1.min.js" type="text/javascript"></script>
    <script src="js/wow.js"></script>
    <script>
        new WOW().init();
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="cos">lalala</div>
        <header id="menu" class="navbar-fixed-top">
            <div class="container">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <nav class="navbar" role="navigation" id="pasek_nawigacji">
                        <div class="container-fluid">
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#moje-menu">
                                    <span class="sr-only">Nawigacja</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <a class="navbar-brand hidden-xs hidden-sm" href="Index.aspx">Menu</a>

                                <asp:Label ID="witaj" CssClass="navbar-brand" runat="server" Text=""></asp:Label>
                                <asp:LinkButton ID="wyloguj_btn1" CssClass="navbar-brand" OnClick="wyloguj_btn_Click" runat="server">wyloguj</asp:LinkButton>
                            </div>
                            <div class="collapse navbar-collapse" id="moje-menu">
                                <ul class="nav navbar-nav navbar-right" id="main-nav">
                                    <li class="active"><a href="#cos">Home</a></li>
                                    <li><a href="#ostronie">O stronie</a></li>
                                    <li><a href="#omnie">O mnie</a></li>
                                    <li><a href="#zadania">Zadania</a></li>
                                    <li><a href="#kontakt">Kontakt</a></li>
                                </ul>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>
        </header>

        <section id="logowanie">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8  col-sm-offset-2 col-md-offset-2 col-lg-offset-2">
                        <div class="ramka">
                            <div>
                                <asp:Label ID="Label7" runat="server" Text="asdasda"></asp:Label>
                            </div>
                            <div class="row">
                                
                                <div class="col-sm-4 col-md-4 col-lg-4 hidden-xs form-group ">
                                    <asp:Label ID="Label3" runat="server" Text="Nazwa użytkownika: "></asp:Label>
                                </div>
                                <div class="col-sm-8 col-md-8 col-lg-8 form-group ">
                                    <asp:TextBox ID="username" TextMode="SingleLine" CssClass="form-control" placeholder="Nazwa użytkownika" runat="server"></asp:TextBox>
                                    <p class="bg-warning">
                                        <asp:Label ID="error1" runat="server" Text=""></asp:Label>
                                    </p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-4 col-md-4 col-lg-4 hidden-xs form-group ">
                                    <asp:Label ID="Label4" runat="server" Text="Miasto: "></asp:Label>
                                </div>
                                <div class="col-sm-8 col-md-8 col-lg-8 form-group ">
                                    <asp:TextBox ID="city" TextMode="SingleLine" CssClass="form-control" placeholder="Miasto" runat="server"></asp:TextBox>
                                    <p class="bg-warning">
                                        <asp:Label ID="error2" runat="server" Text=""></asp:Label>
                                    </p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-4 col-md-4 col-lg-4 hidden-xs form-group ">
                                    <asp:Label ID="Label5" runat="server" Text="Narodowość: "></asp:Label>
                                </div>
                                <div class="col-sm-8 col-md-8 col-lg-8 form-group ">
                                    <asp:DropDownList ID="NarodowościCombo" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-4 col-md-4 col-lg-4 hidden-xs form-group ">
                                    <asp:Label ID="Label6" runat="server" Text="E-mail: "></asp:Label>
                                </div>
                                <div class="col-sm-8 col-md-8 col-lg-8 form-group ">
                                    <asp:TextBox ID="e_mail" TextMode="SingleLine" CssClass="form-control" placeholder="E-mail" runat="server" title="JakisAdres@domena.cos " data-toggle="tooltip" data-placement="top"></asp:TextBox>
                                    <p class="bg-warning">
                                        <asp:Label ID="error3" runat="server" Text=""></asp:Label>
                                    </p>
                                </div>

                            </div>
                            <div class="row">
                                <div class="col-sm-4 col-md-4 col-lg-4 hidden-xs form-group ">
                                    <asp:Label ID="Label1" runat="server" Text="Telefon: "></asp:Label>
                                </div>
                                <div class="col-sm-8 col-md-8 col-lg-8 form-group ">
                                    <asp:TextBox ID="phone" TextMode="SingleLine" CssClass="form-control" placeholder="Telefon 000-000-000" runat="server" title="123-123-123" data-toggle="tooltip" data-placement="top"></asp:TextBox>
                                    <p class="bg-warning">
                                        <asp:Label ID="error4" runat="server" Text=""></asp:Label>
                                    </p>
                                </div>

                            </div>
                            <div class="row">
                                <div class="col-sm-4 col-md-4 col-lg-4 hidden-xs form-group ">
                                    <asp:Label ID="Label2" runat="server" Text="Hasło: "></asp:Label>
                                </div>
                                <div class="col-sm-8 col-md-8 col-lg-8 form-group ">
                                    <asp:TextBox ID="password" TextMode="Password" CssClass="form-control" placeholder="Hasło" runat="server" title="od 3 do 14 znaków" data-toggle="tooltip" data-placement="top"></asp:TextBox>
                                    <p class="bg-warning">
                                        <asp:Label ID="error5" runat="server" Text=""></asp:Label>
                                    </p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-4 col-md-4 col-lg-4 hidden-xs form-group ">
                                </div>
                                <div class="col-sm-8 col-md-8 col-lg-8 form-group ">
                                </div>
                            </div>


                            <asp:Button ID="Zarejestruj" CssClass="btn btn-success" OnClick="Zarejestruj_Click" runat="server" Text="Zarejestruj" />
                            <asp:Button ID="Zaloguj" CssClass="btn btn-success" OnClick="Zaloguj_Click" runat="server" Text="Logowanie" />
                            <asp:Button ID="Wroc" CssClass="btn btn-danger" OnClick="Wroc_Click" runat="server" Text="Wróc" />

                            <div class="bg-danger">
                                <asp:Label ID="errors_text" runat="server" Text=""></asp:Label>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id="stopka" style="margin-top:100px">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                        <h3>Copyright 2015 &copy; Hubert Pietruczuk</h3>
                    </div>
                </div>
            </div>
        </section>
    </form>


    <!-- JavaScript -->
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="js/moje.js"></script>
    <script src="js/moje2.js"></script>

    <script>  $("input").tooltip(); </script>
</body>
</html>

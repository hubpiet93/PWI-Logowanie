<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Strona.LogIn" %>

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
                                <a class="navbar-brand hidden-xs hidden-sm" href="Index.aspx">PWI</a>

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
                    <div class="col-xs-8 col-sm-6 col-md-6 col-lg-6 col-xs-offset-2 col-sm-offset-3 col-md-offset-3 col-lg-offset-3">
                        <div class="ramka">
                            <div class="form-group">
                                <asp:Label ID="Label1" runat="server" Text="E-mail: "></asp:Label>
                                <asp:TextBox ID="logint" TextMode="SingleLine" CssClass="form-control" placeholder="Login" runat="server"></asp:TextBox>

                                <%--     <asp:RegularExpressionValidator ID="login_regex" runat="server"
                                ControlToValidate="login" ErrorMessage="Musisz wypełnić to pole" 
                                ValidationExpression="^(?!\s*$).+" ValidationGroup="check"/>--%>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="Hasło: "></asp:Label>
                                <asp:TextBox ID="hasłot" TextMode="Password" CssClass="form-control" placeholder="Hasło" runat="server"></asp:TextBox>
                            </div>
                            <asp:Button ID="Button1" CssClass="btn btn-success" OnClick="Button1_Click" runat="server" Text="Zaloguj" />
                            <asp:Button ID="Button2" CssClass="btn btn-danger" OnClick="Button2_Click" runat="server" Text="Wroc" />
                            <div class="bg-danger">
                                <asp:Label ID="errors_text" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id="stopka" style="position: absolute; bottom: 0px">
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

</body>
</html>

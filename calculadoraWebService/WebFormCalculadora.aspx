<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalculadora.aspx.cs" Inherits="calculadoraWebService.WebFormCalculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CALCULADORA</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <link href="Styles/StyleSheet1.css" rel="stylesheet" />

</head>


<body>
    <form id="form1" runat="server">

            <h1 class="text-center texto">CALCULADORA CON WEB SERVICES</h1>


        <section class="container">
            <div class="row">
                <div class="col">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>
            </div>
        </section>

        <div class="text-center texto"><h3>RESULTADO</h3></div>

        <div class="container">
            <div class="row">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>   
        </div>

        <section class="container">
            <div class="row">
                 <div class="col">
                     <asp:Button ID="Button1" runat="server" Text="Sumar" CssClass="minimal-button" OnClick="clickSumar" /></div>
                 <div class="col">
                     <asp:Button ID="Button2" runat="server" Text="Restar" CssClass="minimal-button" OnClick="clickRestar" /></div>
                 <div class="col">
                     <asp:Button ID="Button3" runat="server" Text="Multiplicar" CssClass="minimal-button" OnClick="clickMultiplicar" /></div>
                 <div class="col">
                     <asp:Button ID="Button4" runat="server" Text="Dividir" CssClass="minimal-button" OnClick="clickDividir" /></div>
            </div>


        </section>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>

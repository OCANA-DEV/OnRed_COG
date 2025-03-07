<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="OnRed.PaginaPrincipal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>Página Principal - On Red</title>
  <link href="css/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Bienvenido a la Página Principal</h2>
            <asp:Label ID="lblUsuario" runat="server" Font-Bold="true"></asp:Label>         
            <br /><br /><br />
            <!-- Botón Volver a la página principal -->
            <asp:Button ID="btnVolver" CssClass="btn" runat="server" Text="Inicio" OnClick="btnVolverMain_Click" />
            <br /><br />

        </div>
    </form>
    
    <div class="footer">
        By: Carlos Ocaña
    </div>
</body> 
</html>
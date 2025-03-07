<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="OnRed.CambiarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Cambiar contraseña</title>
    <link rel="stylesheet" href="css/styles.css"/>
</head>
<body>
   <form id="form1" runat="server">
    <div class="container">
        <h1>Cambiar Contraseña</h1>

        <h4>Nueva Contraseña</h4>
        <asp:TextBox ID="txtNuevaContraseña" runat="server" TextMode="Password" placeholder="Introduce tu nueva contraseña" />
        <br /><br />

        <h4>Confirmar Nueva Contraseña</h4>
        <asp:TextBox ID="txtConfirmarContraseña" runat="server" TextMode="Password" placeholder="Confirma tu nueva contraseña" />
        <br /><br />

        <asp:Button ID="btnCambiarContraseña" runat="server" CssClass="btn" Text="Cambiar Contraseña" OnClick="btnCambiarContraseña_Click" />
        <br /><br />

        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" />
    </div>
</form>
     <div class="footer">
  By: Carlos Ocaña
 </div>
</body>
</html>

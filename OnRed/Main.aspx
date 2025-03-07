<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="OnRed.Main" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>On Red</title>
    <link href="css/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form" runat="server">
        <div class="container">
            <h2>Selecciona el ejercicio</h2>
            
            <!-- Botón para redirigir al Ejercicio 1 (WebForms) -->
            <asp:Button ID="btnEjercicio1" runat="server" Text="WebForms" OnClick="btnEjercicio1_Click" CssClass="btn-redirigir" />
            <br />
            
            <!-- Botón para redirigir al Ejercicio 2 (Login) -->
            <asp:Button ID="btnEjercicio2" runat="server" Text="Login" OnClick="btnEjercicio2_Click" CssClass="btn-redirigir" />
        </div>
    </form>
    <div class="footer">
     By: Carlos Ocaña
    </div>
</body>
</html>
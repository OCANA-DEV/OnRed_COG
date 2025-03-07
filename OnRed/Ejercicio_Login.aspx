<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_Login.aspx.cs" Inherits="OnRed.Ejercicio_Login" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Login - On Red</title>
    <link href="css/styles.css" rel="stylesheet" />
</head>
<body>
    
  <form id="form1" runat="server">
    <div class="container">
        <!-- Botón Volver a la página principal -->
        <asp:Button ID="btnVolver" CssClass="btn" runat="server" Text="Volver" OnClick="btnVolverMain_Click" />
        <br /><br />

        <!-- Sección de login -->
        <h1>Iniciar sesión</h1>

        <!-- Formulario de Login -->
        <asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnLogin">
            <div>
                <h4>Usuario</h4>
                <asp:TextBox ID="txtUsuario" runat="server" placeholder="Introduce tu usuario" />
            
                <h4>Contraseña</h4>
                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" placeholder="Introduce tu contraseña" />
                <br /><br />

                <asp:Button ID="btnLogin" CssClass="btn" runat="server" Text="Iniciar sesión" OnClick="btnLogin_Click" />
                <br /><br />


                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" />
                <br /><br />

                <asp:LinkButton ID="lbRecuperarContraseña" runat="server" OnClick="lbRecuperarContraseña_Click">¿Olvidaste tu contraseña?</asp:LinkButton>
            </div>
        </asp:Panel>

        <!-- Formulario para recuperación de contraseña -->
        <asp:Panel ID="pnlRecuperarContraseña" runat="server" Visible="false">
            <div>
                 <h4>Usuario</h4>
                <asp:TextBox ID="txtUsuarioRecuperar" runat="server" placeholder="Introduce tu usuario" />
                
                <h4>Contraseña</h4>
                <asp:Button ID="btnRecuperarContraseña" CssClass="btn" runat="server" Text="Recuperar Contraseña" OnClick="btnRecuperarContraseña_Click" />
            
                <br /><br />
                <asp:Label ID="lblMensajeRecuperar"  runat="server" ForeColor="Red" />                    
                <asp:Button ID="btnLoginPanel" Visible="false" CssClass="btn" runat="server" Text="Iniciar Sesión" OnClick="btnLoginPanel_Click" />
            </div>
        </asp:Panel>

        <br /><br />

    </div>

    <!-- Pie de página con el autor -->
    <div class="footer">
        By: Carlos Ocaña
    </div>
</form>
</body>
</html>

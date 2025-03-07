<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_WebForms.aspx.cs" Inherits="OnRed.Ejercicio_WebForms" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <title>WebForms  - On Red</title>
      <link href="css/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <asp:Button ID="btnVolver" CssClass="btn" runat="server" Text="Volver" OnClick="btnVolverMain_Click" />
            <br /><br />
            <br /><br />

            <!-- Sección para mostrar los días de la semana -->    
            <asp:GridView ID="gvDiasSemana" runat="server" AutoGenerateColumns="false" CssClass="gridview">
                <Columns>                 
                    <asp:BoundField DataField="Dia" HeaderText="Día de la Semana" SortExpression="Dia" />
                </Columns>
            </asp:GridView>

            <!-- Sección para seleccionar una profesión -->
            <h2>Seleccionar Profesión</h2>
            <asp:RadioButton ID="rbAlbanil" runat="server" GroupName="Profesion" Text="Albañil" Checked="true" />
            <asp:RadioButton ID="rbFontanero" runat="server" GroupName="Profesion" Text="Fontanero" />
            <br /><br />
            
            <!-- Botón para mostrar la profesión seleccionada -->
            <asp:Button ID="btnMostrarProfesion" CssClass="btn" runat="server" Text="Mostrar Profesión" OnClick="btnMostrarProfesion_Click" />
            <br /><br />

            <!-- Mensaje de confirmación de profesión seleccionada -->
            <asp:Label ID="lblMensaje" runat="server" CssClass="message"></asp:Label>

            <!-- Sección para generar trabajadores aleatorios -->
            <h2>Generar Trabajadores Aleatorios</h2>
            <asp:TextBox ID="txtNumero" runat="server" Width="50px"></asp:TextBox>
            <br /><br />     

            <!-- Botón para generar la lista aleatoria de trabajadores -->
            <asp:Button ID="btnGenerarTrabajadores" CssClass="btn" runat="server" Text="Generar Trabajadores" OnClick="btnGenerarTrabajadores_Click" />
            <br /><br />

            <!-- Mensaje de confirmación de generación de lista -->
            <asp:Label ID="lblMensajeGeneracion" runat="server" CssClass="message"></asp:Label>
            <br /><br />

            <!-- GridView para mostrar la lista generada de trabajadores -->
            <asp:GridView ID="gvTrabajadores" runat="server" AutoGenerateColumns="true" CssClass="gridview"></asp:GridView>
        </div>
    </form>
       <div class="footer">
      By: Carlos Ocaña
  </div>
</body>
</html>

using System;
using System.Collections.Generic;
using Bibliotecas;

namespace OnRed
{
    public partial class Ejercicio_Login : System.Web.UI.Page
    {
        /// <summary>
        /// Simulación de base de datos de usuarios.
        /// </summary>
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("Rodrigo","Majadahonda22"),
            new Usuario("Carlos", "1234")
        };

        /// <summary>
        /// Maneja el evento de clic en el botón de inicio de sesión.
        /// </summary>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            var usuarioEncontrado = usuarios.Find(u => u.NombreUsuario == usuario);

            if (usuarioEncontrado != null && usuarioEncontrado.ValidarUsuario(usuario, contraseña))
            {
                // Guardar la lista de usuarios en la sesión
                Session["usuarios"] = usuarios;

                if (usuarioEncontrado.ContraseñaTemporal)
                {
                    // Redirigir a la página para cambiar la contraseña
                    Response.Redirect("CambiarContraseña.aspx?usuario=" + usuario);
                }
                else
                {
                    Response.Redirect("paginaPrincipal.aspx");
                }
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos.";
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el enlace para recuperar la contraseña.
        /// </summary>
        protected void lbRecuperarContraseña_Click(object sender, EventArgs e)
        {
            // Mostrar el panel para recuperar la contraseña
            pnlLogin.Visible = false;
            pnlRecuperarContraseña.Visible = true;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para recuperar la contraseña generando una nueva temporal.
        /// </summary>
        protected void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioRecuperar.Text.Trim();
            var usuarioEncontrado = usuarios.Find(u => u.NombreUsuario == usuario);

            if (usuarioEncontrado != null)
            {
                // Generar contraseña temporal
                string nuevaContraseña = Usuario.GenerarContraseñaAleatoria();
                usuarioEncontrado.ActualizarContraseña(nuevaContraseña);

                // Mostrar la nueva contraseña en lblMensajeRecuperar
                lblMensajeRecuperar.Text = "Tu nueva contraseña temporal es: <span style='color:blue; font-weight:bold;'>" + nuevaContraseña + "</span>. Por favor, cámbiala al iniciar sesión.";
                btnLoginPanel.Visible = true;
            }
            else
            {
                lblMensajeRecuperar.Text = "El usuario no fue encontrado.";
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de volver a la página principal.
        /// </summary>
        protected void btnVolverMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para volver a la pantalla de login.
        /// </summary>
        protected void btnLoginPanel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio_Login.aspx");
        }
    }
}
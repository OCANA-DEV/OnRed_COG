using System;
using System.Collections.Generic;
using Bibliotecas;

namespace OnRed
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        /// <summary>
        /// Evento que se ejecuta al cargar la página.
        /// Valida que el usuario exista en la sesión y redirige si no es válido.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["usuario"]))
            {
                Response.Redirect("Ejercicio_Login.aspx");
            }

            // Obtener la lista de usuarios desde la sesión
            List<Usuario> usuarios = (List<Usuario>)Session["usuarios"];
            if (usuarios == null)
            {
                Response.Redirect("Ejercicio_Login.aspx");
            }

            string usuario = Request.QueryString["usuario"];
            var usuarioEncontrado = usuarios.Find(u => u.NombreUsuario == usuario);

            if (usuarioEncontrado == null)
            {
                Response.Redirect("Ejercicio_Login.aspx");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de cambiar contraseña.
        /// Valida y actualiza la contraseña del usuario si es correcta.
        /// </summary>
        protected void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string usuario = Request.QueryString["usuario"];
            List<Usuario> usuarios = (List<Usuario>)Session["usuarios"];

            if (usuarios != null)
            {
                var usuarioEncontrado = usuarios.Find(u => u.NombreUsuario == usuario);

                if (usuarioEncontrado != null)
                {
                    string nuevaContraseña = txtNuevaContraseña.Text.Trim();
                    string confirmarContraseña = txtConfirmarContraseña.Text.Trim();

                    // Verificación de que la nueva contraseña tenga al menos 8 caracteres
                    if (nuevaContraseña.Length < 8)
                    {
                        lblMensaje.Text = "La contraseña debe tener al menos 8 caracteres.";
                        return;
                    }

                    // Verifica si las contraseñas coinciden antes de actualizar
                    if (nuevaContraseña == confirmarContraseña)
                    {
                        usuarioEncontrado.ActualizarContraseña(nuevaContraseña);
                        usuarioEncontrado.ContraseñaTemporal = false;

                        // Redirigir a la página principal después de cambiar la contraseña
                        Response.Redirect("paginaPrincipal.aspx");
                    }
                    else
                    {
                        lblMensaje.Text = "Las contraseñas no coinciden. Por favor, intenta nuevamente.";
                    }
                }
                else
                {
                    lblMensaje.Text = "El usuario no fue encontrado.";
                }
            }
            else
            {
                lblMensaje.Text = "Error: No se encontraron los usuarios.";
            }
        }
    }
}
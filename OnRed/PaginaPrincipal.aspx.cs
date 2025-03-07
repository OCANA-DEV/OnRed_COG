using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnRed
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        /// <summary>
        /// Maneja el evento de carga de la página. Verifica si el usuario está autenticado y si la sesión ha caducado por inactividad.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si la variable de sesión "UsuarioLogueado" existe
            if (Session["UsuarioLogueado"] == null)
            {
                // Si no está logueado, redirigir a la página de login
                Response.Redirect("Ejercicio_Login.aspx");
            }
            else
            {
                // Verificar si la sesión ha caducado (por inactividad de más de 5 minutos)
                DateTime? ultimaAccion = Session["UltimaAccion"] as DateTime?;
                if (ultimaAccion.HasValue && (DateTime.Now - ultimaAccion.Value).TotalMinutes > 5)
                {
                    // Si han pasado más de 5 minutos, abandonar la sesión y redirigir al login
                    Session.Abandon();
                    Response.Redirect("Ejercicio_Login.aspx");
                }
                else
                {
                    // Actualizar la hora de la última acción en la sesión
                    Session["UltimaAccion"] = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para volver a la página principal.
        /// </summary>
        protected void btnVolverMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}
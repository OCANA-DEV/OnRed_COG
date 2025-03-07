using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnRed
{
    public partial class Main : Page
    {
        /// <summary>
        /// Maneja el evento de clic en el botón para redirigir a la página de Ejercicio 1 (WebForms).
        /// </summary>
        protected void btnEjercicio1_Click(object sender, EventArgs e)
        {
            // Redirige a la página de Ejercicio 1 WebForms
            Response.Redirect("/Ejercicio_WebForms.aspx");
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para redirigir a la página de Ejercicio 2 (Login).
        /// </summary>
        protected void btnEjercicio2_Click(object sender, EventArgs e)
        {
            // Redirige a la página de Ejercicio 2 Login
            Response.Redirect("/Ejercicio_Login.aspx");
        }
    }
}
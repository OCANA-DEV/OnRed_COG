using Bibliotecas;
using System;
using System.Linq;
using System.Web.UI.WebControls;


namespace OnRed
{
    public partial class Ejercicio_WebForms : System.Web.UI.Page
    {
        /// <summary>
        /// Evento que se ejecuta al cargar la página. Carga los días de la semana si no es un postback.
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDiasSemana();
            }
        }

        /// <summary>
        /// Carga la lista de días de la semana en la parrilla desde la biblioteca de clases.
        /// </summary>
        private void CargarDiasSemana()
        {
            // Creamos una lista de objetos con la propiedad 'Dia' que contiene los días de la semana
            var dias = DiasSemana.ObtenerDiasSemana().Select(dia => new { Dia = dia }).ToList();

            // Asignamos esta lista como origen de datos del GridView
            gvDiasSemana.DataSource = dias;
            gvDiasSemana.DataBind();
        }

        /// <summary>
        /// Maneja el evento del botón para mostrar un mensaje según la profesión seleccionada.
        /// </summary>
        protected void btnMostrarProfesion_Click(object sender, EventArgs e)
        {
            // Crear el objeto y mostrar el saludo según la profesión seleccionada
            if (rbAlbanil.Checked)
            {
                // Crear instancia de Albañil solo para obtener el saludo.
                Albanil albanil = new Albanil();
                lblMensaje.Text = "Has seleccionado: Albañil y este es su saludo: <br />" + albanil.Saludo();
            }
            else if (rbFontanero.Checked)
            {
                // Crear instancia de Fontanero solo para obtener el saludo.
                Fontanero fontanero = new Fontanero();
                lblMensaje.Text = "Has seleccionado: Fontanero y este es su saludo: <br />" + fontanero.Saludo();
            }
        }

        /// <summary>
        /// Genera una lista aleatoria de trabajadores (albañiles y fontaneros) y la muestra en la parrilla.
        /// </summary>
        protected void btnGenerarTrabajadores_Click(object sender, EventArgs e)
        {
            // Intentamos convertir el texto a un número entero
            if (int.TryParse(txtNumero.Text, out int cantidad))
            {
                // Verificamos que el número esté dentro del rango válido (1 a 10)
                if (cantidad >= 1 && cantidad <= 10)
                {
                    var trabajadores = GeneradorTrabajadores.GenerarTrabajadores(cantidad);

                    gvTrabajadores.DataSource = trabajadores.Item1;
                    gvTrabajadores.DataBind();

                    lblMensajeGeneracion.Text = "Lista generada correctamente.";
                }
                else
                {
                    lblMensajeGeneracion.Text = "Por favor, ingrese un número válido entre 1 y 10.";
                }
            }
            else
            {
                lblMensajeGeneracion.Text = "Por favor, ingrese un número entero.";
            }
        }

        /// <summary>
        /// Redirige a la página principal.
        /// </summary>
        protected void btnVolverMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}
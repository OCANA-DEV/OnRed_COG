using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    // 1) Clase que devuelve los días de la semana
    public static class DiasSemana
    {
        public static List<string> ObtenerDiasSemana()
        {
            return new List<string> { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        }
    }

    // 2) Clase base Persona
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    // Clase Albañil heredando de Persona
    public class Albanil : Persona
    {
        public int AñosExperiencia { get; set; }

        public string Saludo()
        {
            return $"Hola! El cielo esta enladrillado y lo voy a desanladrillar!";
        }
    }

    // Clase Fontanero heredando de Persona
    public class Fontanero : Persona
    {
        public int AñosExperiencia { get; set; }

        public string Saludo()
        {
            return $"Hola! Soy Mario Bros! has visto a Luigi?";
        }
    }

    // 3) Método que genera una lista y un array de Albañiles y Fontaneros
    public static class GeneradorTrabajadores
    {
        private static Random rand = new Random();

        public static (List<Persona>, Persona[]) GenerarTrabajadores(int cantidad)
        {
            List<Persona> lista = new List<Persona>();
            Persona[] array = new Persona[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                if (rand.Next(2) == 0)
                {
                    var albañil = new Albanil
                    {
                        Nombre = $"Albañil_{i}",
                        Edad = rand.Next(20, 60),
                        AñosExperiencia = rand.Next(1, 5)
                    };
                    lista.Add(albañil);
                    array[i] = albañil;
                }
                else
                {
                    var fontanero = new Fontanero
                    {
                        Nombre = $"Fontanero_{i}",
                        Edad = rand.Next(20, 60),
                        AñosExperiencia = rand.Next(1, 5)
                    };
                    lista.Add(fontanero);
                    array[i] = fontanero;
                }
            }
            return (lista, array);
        }
    }

    // 4) Clase Usuario para validación y gestión de contraseñas
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool ContraseñaTemporal { get; set; } // Indica si la contraseña es temporal

        public Usuario(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            ContraseñaTemporal = false;
        }

        public bool ValidarUsuario(string usuario, string contraseña)
        {
            return NombreUsuario == usuario && Contraseña == contraseña;
        }

        public void ActualizarContraseña(string nuevaContraseña)
        {
            Contraseña = nuevaContraseña;
            ContraseñaTemporal = true; // La contraseña es temporal después de la actualización
        }

        public static string GenerarContraseñaAleatoria()
        {
            // Generar una contraseña aleatoria
            return "Temp" + new Random().Next(1000, 9999).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
    public class Socio
    {
        private static int _contadorId = 0;

        public int IdSocio { get; set; }// Identificador único del socio
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public DateTime FechaAfiliacion { get; set; }
        internal List<Actividad> Actividades { get; set; } = new List<Actividad>(); // Lista de actividades en las que está inscrito el socio

        public Socio(string nombre, string apellido, string direccion, int dni, string contacto)
        {
            IdSocio = ++_contadorId;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            DNI = dni;
            Contacto = contacto;
            FechaAfiliacion = DateTime.Today;
        }
    }
}

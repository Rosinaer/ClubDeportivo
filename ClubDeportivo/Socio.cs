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
        public string Direccion { get; set; }
        public string Contacto { get; set; }
       
        public string Tipo { get; set; }// Tipo de miembro (socio o no socio)
        public DateTime FechaAfiliacion { get; set; }

        public Socio(string nombre, string direccion, string contacto, string tipo, DateTime FechaAfiliacion)
        {
            IdSocio = ++_contadorId;
            Nombre = nombre;
            Direccion = direccion;
            Contacto = contacto;
            Tipo = tipo;
            FechaAfiliacion = DateTime.Today; // Genera la fecha actual al momento de crear el socio
           
        }
    }
}

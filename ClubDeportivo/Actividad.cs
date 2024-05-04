using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
    internal class Actividad
    {
        private static int _contadorId = 0;

        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public float Costo { get; set; }

        public Actividad(string nombre, float costo)
        {
            IdActividad = ++_contadorId;
            Nombre = nombre;
            Costo = costo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
    internal class GestionClubDeportivo
    {
        public List<Socio> Socios { get; set; } 
        public List<Profesor> Profesores { get; set; } 
        public List<Cuota> CuotasPendientes { get; set; } 
        public List<Actividad> Actividades { get; set; }

        public GestionClubDeportivo()
        {
            // Inicializa las listas
            Socios = new List<Socio>();
            Profesores = new List<Profesor>();
            CuotasPendientes = new List<Cuota>();
            Actividades = new List<Actividad>();
        }
    }
}

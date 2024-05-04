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
        // metodo para registrr pago de cuota
        public void CobrarCuotaMensual(Socio socio, float monto, DateTime fechaPago)
        {
            Cuota cuotaPagada = new Cuota(fechaPago, monto, "Pagado");
            CuotasPendientes.Add(cuotaPagada);
        }
        // metodo para buscar socios con cuota pendiente
        public List<Socio> ListarSociosCuotaVence(DateTime fecha)
        {
            List<Socio> sociosCuotaVence = new List<Socio>();
            foreach (Socio socio in Socios)
            {
                foreach (Cuota cuota in CuotasPendientes)
                {
                    if (cuota.FechaPago == fecha)
                    {
                        sociosCuotaVence.Add(socio);
                        break;
                    }
                }
            }
            return sociosCuotaVence;
        }

    }

}

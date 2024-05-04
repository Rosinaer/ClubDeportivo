using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivo
{
    internal class Cuota
    {
        public int IdCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public float Monto { get; set; }
        public string Estado { get; set; }
    }
}

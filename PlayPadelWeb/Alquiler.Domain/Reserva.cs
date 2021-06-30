using Identity.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alquiler.Domain
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public ApplicationUser Usuario { get; set; }
        public Pista Pista { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        
    }
}

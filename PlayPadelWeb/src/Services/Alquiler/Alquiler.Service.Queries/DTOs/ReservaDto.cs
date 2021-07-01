using Alquiler.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using static Alquiler.Common.Enums;

namespace Alquiler.Service.Queries.DTOs
{
    public class ReservaDto
    {
        public int ReservaID { get; set; }
        public string Usuario { get; set; }
        public PistaNumerada Pista { get; set; }

        public DateTime Fecha { get; set; }
        public int HoraInicio { get; set; }

        public int HoraFin { get; set; }


    }
}

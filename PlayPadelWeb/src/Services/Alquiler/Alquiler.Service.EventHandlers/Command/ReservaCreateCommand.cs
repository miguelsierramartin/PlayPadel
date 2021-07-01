using Alquiler.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using static Alquiler.Common.Enums;

namespace Alquiler.Service.EventHandlers.Command
{
    public class ReservaCreateCommand : INotification
    {
        public string Usuario { get; set; }
         public PistaNumerada Pista { get; set; }

        public DateTime Fecha { get; set; }
        public int HoraInicio { get; set; }

        public int HoraFin { get; set; }

    }
}

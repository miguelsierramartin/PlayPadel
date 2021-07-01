using Alquiler.Domain;
using Alquiler.Persistence.Database;
using Alquiler.Service.EventHandlers.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alquiler.Service.EventHandlers
{
   public class ReservaCreateEventHandler
        : INotificationHandler<ReservaCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ReservaCreateEventHandler(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ReservaCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Reserva
            {
                  Usuario=notification.Usuario,
                  Pista=notification.Pista,
                  Fecha=notification.Fecha,
                  HoraInicio = notification.HoraInicio,
                  HoraFin = notification.HoraFin
            });

            await _context.SaveChangesAsync();
        }
    }

}


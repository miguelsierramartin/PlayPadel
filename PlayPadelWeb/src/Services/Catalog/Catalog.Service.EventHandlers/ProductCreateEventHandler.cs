using Catalog.Domain;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductCreateEventHandler :
        INotificationHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductCreateEventHandler(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ProductCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Product
            {
                Nombre = notification.Nombre,
                Descripcion = notification.Descripcion,
                Precio = notification.Precio
            });

            await _context.SaveChangesAsync();
        }
    }
}
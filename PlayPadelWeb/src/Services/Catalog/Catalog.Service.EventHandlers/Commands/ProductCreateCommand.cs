using MediatR;

namespace Catalog.Service.EventHandlers.Commands
{
    public class ProductCreateCommand : INotification
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
namespace Catalog.Services.Queries.DTOs
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public ProductInStockDto Stock { get; set; }
    }
}

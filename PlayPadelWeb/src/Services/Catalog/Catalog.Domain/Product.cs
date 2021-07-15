namespace Catalog.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
       // public ProductInStock Stock { get; set; }
    }
}

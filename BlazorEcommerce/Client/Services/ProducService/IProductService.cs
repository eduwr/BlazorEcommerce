namespace BlazorEcommerce.Client.Services.ProducService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}

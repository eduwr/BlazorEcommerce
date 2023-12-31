﻿namespace BlazorEcommerce.Client.Services.ProducService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/{productId}");

            if (result == null)
            {
                return new ServiceResponse<Product>()
                {
                    Success = false,
                    Message = "Something went wrong"
                };
            }

            return result;
        }

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            if (result != null && result.Data != null)
                Products = result.Data;
        }
    }
}

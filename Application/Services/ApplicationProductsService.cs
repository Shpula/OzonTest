using Domain.Interfaces;
using Domain.Models;
using Domain.Repos;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ApplicationProductsService
    {
        private readonly IProductsService _productsService;

        public ApplicationProductsService(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public Task<List<ProductsItem>> GetAllProducts(CancellationToken ct)
        {
            return _productsService.GetAllProducts(ct);
        }

        public Task<int> GetMonthById(int product_id, CancellationToken ct)
        {
            return _productsService.GetMonthByProductId(product_id, ct);
        }

        public Task<List<ProductsItem>> GetProductById(int product_id, CancellationToken ct)
        {
            return _productsService.GetProductByProductId(product_id, ct);
        }

        public Task<int> GetStockById(int product_id, CancellationToken ct)
        {
            return _productsService.GetStockByProductId(product_id, ct);
        }
    }
}

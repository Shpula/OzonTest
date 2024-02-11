using Domain.Interfaces;
using Domain.Models;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductsService : IProductsService
    {
        public readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public Task<List<ProductsItem>> GetAllProducts(CancellationToken ct)
        {
            return _productsRepository.GetAllProducts(ct);
        }

        public Task<int> GetMonthByProductId(int product_id, CancellationToken ct)
        {
            return _productsRepository.GetMonthByProductId(product_id, ct);
        }

        public Task<List<ProductsItem>> GetProductByProductId(int product_id, CancellationToken ct)
        {
            return _productsRepository.GetProductByProductId(product_id, ct);
        }

        public Task<int> GetStockByProductId(int product_id, CancellationToken ct)
        {
            return _productsRepository.GetStockByProductId(product_id, ct);
        }
    }
}

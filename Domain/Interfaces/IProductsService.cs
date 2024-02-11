using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductsService
    {
        Task<List<ProductsItem>> GetAllProducts(CancellationToken ct);
        Task<List<ProductsItem>> GetProductByProductId(int product_id, CancellationToken ct);
        Task<int> GetMonthByProductId(int product_id, CancellationToken ct);
        Task<int> GetStockByProductId(int product_id, CancellationToken ct);
    }
}

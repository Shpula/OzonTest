using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
    public interface ICoeffsRepository
    {
        Task<List<CoeffsItem>> GetAllCoeffs(CancellationToken ct);
        Task<CoeffsItem> GetFirstCoeffByProductId(int product_id, CancellationToken ct);
        Task<double> GetCoeffByProductIdAndMonth(int product_id, int month, CancellationToken ct);
    }
}

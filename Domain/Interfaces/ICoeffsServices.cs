using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICoeffsService
    {
        Task<List<CoeffsItem>> GetAllCoeffs(CancellationToken ct);
        Task<CoeffsItem> GetFirstCoeffByProductId(int product_id, CancellationToken ct);
        Task<double> GetCoeffByProductIdAndMonth(int product_id, int month, CancellationToken ct);
    }
}

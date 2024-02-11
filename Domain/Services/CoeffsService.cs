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
    public class CoeffsService : ICoeffsService
    { 
        public readonly ICoeffsRepository _coeffsRepository;

        public CoeffsService(ICoeffsRepository coeffsRepository)
        {
            _coeffsRepository = coeffsRepository;
        }

        public Task<List<CoeffsItem>> GetAllCoeffs(CancellationToken ct)
        {
            return _coeffsRepository.GetAllCoeffs(ct);
        }
        public Task<CoeffsItem> GetFirstCoeffByProductId(int product_id, CancellationToken ct)
        {
            return _coeffsRepository.GetFirstCoeffByProductId(product_id, ct);
        }

        public Task<double> GetCoeffByProductIdAndMonth(int product_id, int month, CancellationToken ct)
        {
            return _coeffsRepository.GetCoeffByProductIdAndMonth(product_id, month, ct);
        }
    }
}

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
    public class ApplicationCoeffsService
    {
        private readonly ICoeffsService _coeffsService;

        public ApplicationCoeffsService(ICoeffsService coeffsService)
        {
            _coeffsService = coeffsService;
        }
        public Task<List<CoeffsItem>> GetAllCoeffs(CancellationToken ct)
        {
            return _coeffsService.GetAllCoeffs(ct);
        }
        public Task<CoeffsItem> GetFirstCoeffById(int product_id, CancellationToken ct)
        {
            return _coeffsService.GetFirstCoeffByProductId(product_id, ct);
        }

        public Task<double> GetCoeffByIdAndMonth(int product_id, int month, CancellationToken ct)
        {
            return _coeffsService.GetCoeffByProductIdAndMonth(product_id, month, ct);
        }
    }
}

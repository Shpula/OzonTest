using Domain.Interfaces;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ICoeffsRepository _coeffsRepository;

        public StatisticService(IProductsRepository productsRepository, ICoeffsRepository coeffsRepository)
        {
            _productsRepository = productsRepository;
            _coeffsRepository = coeffsRepository;
        }

        public async Task<double> ABS(int product_id, CancellationToken ct)
        {
            var relevantItems = (await _productsRepository
                .GetProductByProductId(product_id, ct))
                .Where(item => item.Sales != 0)
                .OrderBy(item => item.Date)
                .ToList();

            var sumSales = relevantItems.Sum(item => item.Sales);
            var sumDays = relevantItems.Select(item => item.Date).Distinct().Count();

            double ABS = 0;

            if (sumDays == 0)
                ABS = 0;
            else
                ABS = sumSales / sumDays;

            return ABS;
        }

        public async Task<double> Prediction(int product_id, int days, CancellationToken ct)
        {
            var abs = await ABS(product_id, ct);
            var month = await _productsRepository.GetMonthByProductId(product_id, ct);
            var coeff = await _coeffsRepository.GetCoeffByProductIdAndMonth(product_id, month, ct);

            return abs * coeff * days;
        }

        public async Task<double> Demand(int product_id, int days, CancellationToken ct)
        {
            var prediction = await Prediction(product_id, days, ct);
            var stock = await _productsRepository.GetStockByProductId(product_id, ct);
            return prediction - stock;
        }
    }
}

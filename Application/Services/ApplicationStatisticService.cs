using Domain.Interfaces;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ApplicationStatisticService
    {
        private readonly IStatisticService _statisticService;

        public ApplicationStatisticService(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public Task<double> ABS(int product_id, CancellationToken ct)
        {
            return _statisticService.ABS(product_id, ct);
        }

        public Task<double> Prediction(int product_id, int days, CancellationToken ct)
        {
            return _statisticService.Prediction(product_id, days, ct);
        }

        public Task<double> Demand(int product_id, int days, CancellationToken ct)
        {
            return _statisticService.Demand(product_id, days, ct);
        }
    }
}

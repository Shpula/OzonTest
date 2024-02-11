using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStatisticService
    {
        Task<double> ABS(int product_id, CancellationToken ct);
        Task<double> Prediction(int product_id, int days, CancellationToken ct);
        Task<double> Demand(int product_id, int days, CancellationToken ct);
    }
}

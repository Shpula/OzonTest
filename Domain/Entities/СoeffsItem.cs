using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;
public class CoeffsItem
{
    public Guid Id { get; set; }
    public int Product_id { get; set; }
    public int Month {  get; set; }
    public double Coeff { get; set; }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class ProductsItem
{
    public Guid Id { get; set; }
    public int Product_id { get; set; }
    public DateOnly Date { get; set; }
    public int Sales { get; set; }
    public int Stock { get; set; }


}

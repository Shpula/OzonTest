using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Exceptions
{
    public class NotFoundException<T> : Exception
    {
        private NotFoundException(string? msg) : base(msg) { }

        public static NotFoundException<T> Create(int product_id)
        {
            return new NotFoundException<T>($"{typeof(T).Name} with id {product_id} was not found.");
        }

        public static NotFoundException<T> Create(int product_id, int month)
        {
            return new NotFoundException<T>($"{typeof(T).Name} with id {product_id} {month} was not found.");
        }
    }
}
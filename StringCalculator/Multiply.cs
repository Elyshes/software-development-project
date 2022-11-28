using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Multiply : IOperation
    {
        public int Calcuate(List<int> numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
    }
}

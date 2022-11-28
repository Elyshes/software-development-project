using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public interface IOperation
    {
        int Calcuate(List<int> numbers);
    }
}

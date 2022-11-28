using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public interface ITask
    {
        bool WasSuccessful();

        void Do(string val);
    }
}

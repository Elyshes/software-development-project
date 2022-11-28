using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Processor
    {
        public void Execute(ITask task)
        {
        }

        public event EventHandler<EventArgs> Finished;
    }
}

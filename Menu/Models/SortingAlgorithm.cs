using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    abstract class SortingAlgorithm
    {
        public abstract void InitialiseDataSet(List<int> initialData);

        public abstract List<int> PerformStep();

        public abstract Boolean Sorted();    

    }
}

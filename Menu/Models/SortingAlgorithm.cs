using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    abstract class SortingAlgorithm
    {
        protected List<int> data;

        public List<int> DataSet
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public abstract List<int> PerformStep();

        public abstract Boolean Sorted();    

    }
}

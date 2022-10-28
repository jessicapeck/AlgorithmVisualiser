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

       // getter and setter for data
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

        // to keep track of whether the data set is fully sorted or not
        protected bool sorted = false;
        
        // getter and setter for sorted
        public bool Sorted
        {
            get
            {
                return sorted;
            }
            set
            {
                sorted = value;
            }
        }

    }
}

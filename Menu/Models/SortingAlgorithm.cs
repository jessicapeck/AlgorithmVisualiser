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

        // define boolean states for comparisonStep and swapStep
        protected bool comparisonStep = true;
        protected bool swapStep = false;

        // define counters for number of comparisons and swaps
        protected int numberOfComparisons = 0;
        protected int numberOfSwaps = 0;

        // to keep track of whether the data set is fully sorted or not
        protected bool sorted = false;

        // for storing special colour indexes and colour codes in form : (element index, colour code)
        protected List<(int, int)> specialColours = new List<(int, int)>{ };

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

        // getter and setter for numberOfComparisons
        public int NumberOfComparisons
        {
            get
            {
                return numberOfComparisons;
            }
            set
            {
                numberOfComparisons = value;
            }
        }

        // getter and setter for numberOfSwaps
        public int NumberOfSwaps
        {
            get
            {
                return numberOfSwaps;
            }
            set
            {
                numberOfSwaps = value;
            }
        }

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

        // getter and setter for specialColours
        public List<(int,int)> SpecialColours
        {
            get
            {
                return specialColours;
            }
            set
            {
                specialColours = value;
            }
        }

        public abstract List<int> PerformStep();

    }
}

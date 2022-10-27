using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    class InsertionSort : SortingAlgorithm
    {
        // start_index to keep track of starting point
        private int start_index = 1;
        private int counter = 1;

        // define variable for whether the data set is completely sorted
        private bool sorted = false;

        // used in swap
        private int temp;

        public override List<int> PerformStep()
        {
            // check if starting point exceeds end of list
            if (start_index < data.Count())
            {
                // swap data elements if right item is less than the left item
                if (data[counter] < data[counter - 1])
                {
                    temp = data[counter - 1];
                    data[counter - 1] = data[counter];
                    data[counter] = temp;

                    // decrement counter
                    counter--;
                }
                // if there has not been a swap, increment the value of start_index and begin again from that point
                else
                {
                    start_index += 1;
                    counter = start_index;
                }

                // check if counter has hit 0
                if (counter == 0)
                {
                    start_index += 1;
                    counter = start_index;
                }
            }
            // if the start point would exceed the end of the list, then the list is sorted
            else
            {
                sorted = true;
            }

            // return the data set to controller
            return data;
        }

        public override bool Sorted()
        {
            // return true if the data set is sorted
            if (sorted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    class InsertionSort : SortingAlgorithm
    {
        // startIndex to keep track of starting point
        private int startIndex = 1;
        private int counter = 1;

        
        // used in swap
        private int temp;

        public override List<int> PerformStep()
        {
            // check if starting point exceeds end of list
            if (startIndex < data.Count())
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
                // if there has not been a swap, increment the value of startIndex and begin again from that point
                else
                {
                    startIndex++;
                    counter = startIndex;
                }

                // check if counter has hit 0
                if (counter == 0)
                {
                    startIndex += 1;
                    counter = startIndex;
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

        
    }
}

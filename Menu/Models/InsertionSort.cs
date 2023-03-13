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
                if (comparisonStep)
                {
                    // set special colours for elements being compared, counter is main element
                    specialColours.Clear();
                    specialColours.Add((counter, 2));
                    specialColours.Add((counter - 1, 1));

                    // if a swap needs to be made, change boolean states of comparisonStep and swapStep
                    if (data[counter] < data[counter - 1])
                    {
                        comparisonStep = false;
                        swapStep = true;
                    }
                    // if a swap is not required, increment the value of startIndex and begin again from that point
                    // boolean states remain unchanged
                    else
                    {
                        startIndex++;
                        counter = startIndex;
                    }

                    // increment comparison counter
                    numberOfComparisons++;
                }
                else if (swapStep)
                {
                    // swap data elements
                    temp = data[counter - 1];
                    data[counter - 1] = data[counter];
                    data[counter] = temp;

                    // set special colours for elements being swapped, counter - 1 is main element
                    specialColours.Clear();
                    specialColours.Add((counter - 1, 2));
                    specialColours.Add((counter, 1));

                    // decrement counter
                    counter--;

                    // change boolean states of comparisonStep and swapStep
                    comparisonStep = true;
                    swapStep = false;

                    // increment swap counter
                    numberOfSwaps++;
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
                specialColours.Clear();
                sorted = true;
            }

            // return the data set to controller
            return data;
        }        
    }
}

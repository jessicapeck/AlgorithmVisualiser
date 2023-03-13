using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    class BubbleSort : SortingAlgorithm
    {
        private int counter = 0;

        // define variable for storing whether a swap has been made in a pass
        private bool swapped = false;

        private int temp;

        private int passNum = 1;

        public override List<int> PerformStep()
        {
            if (comparisonStep)
            {
                // set special colours for elements being compared
                specialColours.Clear();
                specialColours.Add((counter, 1));
                specialColours.Add((counter + 1, 1));

                // if a swap needs to be made, change boolean states of comparisonStep and swapStep
                if (data[counter] > data[counter + 1])
                {
                    comparisonStep = false;
                    swapStep = true;
                }
                // if a swap is not required, increment the counter, boolean states remain unchanged
                else
                {
                    counter++;
                }

                // incremented comparison counter
                numberOfComparisons++;
            }
            else if (swapStep)
            {
                // swap data elements
                temp = data[counter + 1];
                data[counter + 1] = data[counter];
                data[counter] = temp;

                swapped = true;

                // set special colours for elements being swapped
                specialColours.Clear();
                specialColours.Add((counter, 1));
                specialColours.Add((counter + 1, 1));

                // increment counter by 1
                counter++;

                // change boolean states of comparisonStep and swapStep
                comparisonStep = true;
                swapStep = false;

                // increment swap counter
                numberOfSwaps++;
            }
            
            // TEST : write contents of data set to console
            //Console.WriteLine($"Pass {passNum} - BUBBLE SORT: " + string.Join(", ", data));

            // if end of pass and swaps have been made in the pass, reset the counter and variables
            if ((counter >= data.Count() - passNum) && (swapped == true))
            {
                counter = 0;
                swapped = false;
                sorted = false;

                passNum++;

                // check if the algorithm has reached the end of the final useful pass
                if (passNum == data.Count())
                {
                    specialColours.Clear();
                    sorted = true;
                }
            }
            // if end of pass and no swaps have been made in the pass, the data set is sorted
            else if (((counter >= data.Count() - passNum)) && (swapped == false))
            {
                specialColours.Clear();
                sorted = true;
            }            

            // return data set to controller
            return data;
        }        
    }
}

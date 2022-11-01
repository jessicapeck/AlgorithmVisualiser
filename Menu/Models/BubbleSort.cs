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
            // swap data elements if left item is greater than the right item
            if (data[counter] > data[counter + 1])
            {
                temp = data[counter + 1];
                data[counter + 1] = data[counter];
                data[counter] = temp;

                swapped = true;
            }

            // increment counter by 1
            counter++;

            // test : write contents of data set to console
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
                    sorted = true;
                }
            }
            // if end of pass and no swaps have been made in the pass, the data set is sorted
            else if (((counter >= data.Count() - passNum)) && (swapped == false))
            {
                sorted = true;
            }            

            // return data set to controller
            return data;
        }

        
    }
}

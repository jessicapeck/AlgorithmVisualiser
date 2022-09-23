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
        // define variable for whether the data set is completely sorted
        private bool sorted = false;

        int temp;

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

            // if end of pass and swaps have been made in the pass, reset the counter and variables
            if ((counter == data.Count() - 1) && (swapped == true))
            {
                counter = 0;
                swapped = false;
                sorted = false;
            }
            // if end of pass and no swaps have been made in the pass, the data set is sorted
            else if ((counter == data.Count() - 1) && (swapped == false))
            {
                sorted = true;
            }
            // test : write contents of data set to console
            Console.WriteLine("BUBBLE SORT: " + string.Join(", ", data));

            // return data set
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

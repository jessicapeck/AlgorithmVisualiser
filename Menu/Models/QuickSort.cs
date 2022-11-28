using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    class QuickSort : SortingAlgorithm
    {
        // declare pivot index
        // this quick sort algorithm will always use the last element as the pivot
        private int pivotIndex;
        private int originalPivotIndex;

        // define coutner for indexing elements from list
        private int counter = 0;
        private int startIndex = 0;


        // declare futurePivotIndexes as a new list of tuples of two integers and a string
        private List<(int,int)> futurePivotIndexes = new List<(int, int)> { };

        // define boolean values
        private bool firstPass = true;

        // temp used for swaps
        private int temp;

        public override List<int> PerformStep()
        {
            // will only run on the first call of PerformStep() method
            if (firstPass)
            {
                // define pivot index
                pivotIndex = data.Count() - 1;
                originalPivotIndex = pivotIndex;

                // change boolean state of firstPass to false
                firstPass = false;
            }            

            if (comparisonStep)
            {

                // compare value of counter to value of pivotIndex
                if (counter != pivotIndex)
                {
                    if (data[counter] > data[pivotIndex])
                    {
                        // change boolean states of comparisonStep and swapStep
                        comparisonStep = false;
                        swapStep = true;
                    }
                    else
                    {
                        counter++;
                    }
                }
                else
                {
                    // check if pivot element is not at the far LHS of its sublist
                    if (startIndex != pivotIndex)
                    {
                        // add LHS sublist of smaller elements
                        futurePivotIndexes.Add((startIndex, pivotIndex - 1));

                    }

                    // check if pivot element is not at the far RHS of its sublist
                    if (pivotIndex != originalPivotIndex)
                    {
                        // add RHS sublist of larger elements 
                        futurePivotIndexes.Add((pivotIndex + 1, originalPivotIndex));
                    }                                        

                    // check for any more tuples in futurePivotIndexes list
                    if (futurePivotIndexes.Count() != 0)
                    {
                        // define new counter and pivotIndex
                        (startIndex, pivotIndex) = futurePivotIndexes[0];

                        // set counter to the value of startIndex
                        counter = startIndex;
                        // set originalPivotIndex to the value of pivotIndex
                        originalPivotIndex = pivotIndex;

                        // remove used index tuple
                        futurePivotIndexes.RemoveAt(0);
                    }
                    else
                    {
                        // change boolean state of sorted attribute
                        sorted = true;
                    }                  
                }

                numberOfComparisons++;
            }
            else if (swapStep)
            {
                // move element to end of list
                temp = data[counter];
                data.RemoveAt(counter);
                data.Insert(originalPivotIndex, temp);

                // decrement pivotIndex to maintain same pivot element
                pivotIndex--;

                // change boolean states of comparisonStep and swapStep
                swapStep = false;
                comparisonStep = true;

                // increment swap counter
                numberOfSwaps++;
            }
            
            return data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{

    class MergeSort : SortingAlgorithm
    {
        // define firstPass to be true
        private bool firstPass = true;

        // to be defined during first call of PerformStep()
        private int leftIndex;
        private int rightIndex;
        private int middleIndex;

        private int numberOfElements;

        // in format (left, right)
        private List<(int, int)> indexesForMergeSort = new List<(int, int)> { };

        // to index tuples in indexesForMergeSort
        private int counter;

        private bool newIndexes = true;

        private int r1;
        private int r2;
        private int l1;
        private int l2;

        private List<int> leftSublist = new List<int> { };
        private List<int> rightSublist = new List<int> { };

        private int leftSublistCounter;
        private int rightSublistCounter;

        // for use in swap
        private int temp;

        public override List<int> PerformStep()
        {
            if (firstPass)
            {
                // define data set indexes
                leftIndex = 0;
                rightIndex = data.Count() - 1;
                middleIndex = rightIndex / 2;

                // define number of elements in data set
                numberOfElements = data.Count();

                // add initial indexes to indexesForMergeSort
                indexesForMergeSort.Add((leftIndex, middleIndex));
                indexesForMergeSort.Add((middleIndex + 1, rightIndex));

                for (int i = 0; i < indexesForMergeSort.Count(); i++)
                {
                    (leftIndex, rightIndex) = indexesForMergeSort[i];

                    if ((leftIndex < rightIndex))
                    {
                        middleIndex = (leftIndex + rightIndex) / 2;

                        indexesForMergeSort.Add((leftIndex, middleIndex));
                        indexesForMergeSort.Add((middleIndex + 1, rightIndex));
                    }
                }

                // define counter
                counter = indexesForMergeSort.Count() - 1;                

                // TEST : write contents of indexesForMergeSort to console
                //foreach ((int,int) setOfIndexes in indexesForMergeSort)
                //{
                //    Console.WriteLine(string.Join(", ", setOfIndexes));
                //
                //}

                firstPass = false;
            }

            if (comparisonStep)
            {
                // if either of the sublists have reached the end, move to next set of sublists
                if (leftSublistCounter > l2 || rightSublistCounter > r2)
                {
                    newIndexes = true;
                }

                // get indexes of new set of sublists
                if (newIndexes)
                {
                    if (counter <= 0)
                    {
                        specialColours.Clear();
                        sorted = true;
                    }
                    else
                    {
                        (r1, r2) = indexesForMergeSort[counter];
                        (l1, l2) = indexesForMergeSort[counter - 1];

                        counter = counter - 2;

                        leftSublistCounter = l1;
                        rightSublistCounter = r1;

                        newIndexes = false;
                    }                   
                }

                // only perform comparison if not already sorted
                if (!sorted)
                {
                    // set special colours for elements being compared
                    specialColours.Clear();
                    specialColours.Add((leftSublistCounter, 1));
                    specialColours.Add((rightSublistCounter, 1));

                    // increment comparison counter
                    numberOfComparisons++;

                    if (data[leftSublistCounter] > data[rightSublistCounter])
                    {
                        // change states of comparison and swap bools
                        comparisonStep = false;
                        swapStep = true;
                    }
                    else
                    {
                        leftSublistCounter++;
                    }
                }                
            }
            else if (swapStep)
            {
                // set special colours for elements being swapped
                specialColours.Clear();
                specialColours.Add((leftSublistCounter, 1));
                specialColours.Add((rightSublistCounter, 1));

                // increment swap counter
                numberOfSwaps++;

                // move element to correct position
                temp = data[rightSublistCounter];
                data.RemoveAt(rightSublistCounter);
                data.Insert(leftSublistCounter, temp);

                // keep relative sublist positions
                leftSublistCounter++;
                l2++;
                rightSublistCounter++;

                // change states of comparison and swap bools
                swapStep = false;
                comparisonStep = true;                
            }

            return data;
        }
    }
}

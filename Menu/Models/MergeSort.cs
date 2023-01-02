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
        private (int, int) setOfIndexes;

        private int counter = 0;

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

                    if ((leftIndex < rightIndex) && (rightIndex - leftIndex > 1))
                    {
                        middleIndex = (leftIndex + rightIndex) / 2;

                        indexesForMergeSort.Add((leftIndex, middleIndex));
                        indexesForMergeSort.Add((middleIndex + 1, rightIndex));
                    }
                }
                

                // TEST : write contents of indexesForMergeSort to console
                //foreach ((int,int) setOfIndexes in indexesForMergeSort)
                //{
                //    Console.WriteLine(string.Join(", ", setOfIndexes));
                //
                //}

                firstPass = false;
            }

            return data;
        }
    }
}

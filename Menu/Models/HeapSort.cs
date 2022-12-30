using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    class HeapSort : SortingAlgorithm
    {
        // define firstPass as true
        private bool firstPass = true;

        // attributes for use in if (firstPass)
        private int numberOfNodes;
        private int lastNonLeafNodeIndex;
        private int nodeIndex;
        private bool buildHeap;
        private bool extractElements;
        private bool swapStepForHeapify;
        private bool swapStepForExtractElements;

        // attributes use in heapify
        private int largestNodeIndex;
        private int leftBranchIndex;
        private int rightBranchIndex;
        private List<int> branchIndexes = new List<int> { };
        private List<int> branchAndLargestIndexes = new List<int> { };

        // attributes for if (swapStep)
        private int temp;



        public override List<int> PerformStep()
        {
            // set up for first call of PerformStep()
            if (firstPass)
            {
                numberOfNodes = data.Count();
                lastNonLeafNodeIndex = (numberOfNodes / 2) - 2;

                nodeIndex = lastNonLeafNodeIndex;

                buildHeap = true;
                extractElements = false;

                firstPass = false;

                swapStepForHeapify = false;
                swapStepForExtractElements = false;
            }

            if (comparisonStep)
            {
                if (buildHeap)
                {
                    // heapify nodes from  index 0 to lastNonLeafNodeIndex in reverse order
                    heapify(numberOfNodes, nodeIndex);

                    if (largestNodeIndex != nodeIndex)
                    {
                        comparisonStep = false;
                        swapStepForHeapify = true;                        
                    }
                    else
                    {
                        nodeIndex--;

                        if (nodeIndex < 0)
                        {
                            buildHeap = false;
                            extractElements = true;

                            nodeIndex = numberOfNodes - 1;

                        }
                    }
                }
                // remove largest and heapify
                else if (extractElements)
                {
                    heapify(nodeIndex, 0);

                    if (largestNodeIndex != nodeIndex)
                    {
                        comparisonStep = false;
                        swapStepForHeapify = true;
                    }
                    else
                    {
                        nodeIndex--;

                        if (nodeIndex == 0)
                        {
                            sorted = true;
                        }
                    }
                }

            }
            // swaps
            else if (swapStepForHeapify)
            {
                temp = data[nodeIndex];
                data[nodeIndex] = data[largestNodeIndex];
                data[largestNodeIndex] = temp;

                nodeIndex = largestNodeIndex;

                swapStepForHeapify = false;
                comparisonStep = true;
            }
            else if (swapStepForExtractElements)
            {
                temp = data[0];
                data[0] = data[nodeIndex];
                data[nodeIndex] = temp;

                swapStepForExtractElements = false;
                comparisonStep = true;
            }
            
            
            return data;
        }

        private void heapify(int N, int i)
        {
            // initialise largest as root
            largestNodeIndex = i;

            // initialise leftBranchIndex and rightBranchIndex
            leftBranchIndex = (2 * i) + 1;
            rightBranchIndex = (2 * i) + 2;

            branchIndexes.Add(leftBranchIndex);
            branchIndexes.Add(rightBranchIndex);

            // add indexes to branchAndLargestIndexes if the branchIndex is valid
            branchAndLargestIndexes.Add(largestNodeIndex);
            foreach (int branchIndex in branchIndexes)
            {
                // if index does not exceed end of list
                if (branchIndex < N)
                {
                    branchAndLargestIndexes.Add(branchIndex);
                }
            }

            // assign the new largestNodeIndex
            largestNodeIndex = branchAndLargestIndexes.Max();

        }
    }
}

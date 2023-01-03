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

        // definition in firstPass
        private int numberOfNodes;
        private int nodeIndex;

        // declare index of parent node
        private int parentNodeIndex;

        private int j;

        // for use in swapStep
        private int temp;
        private int a;
        private int b;

        // bools for different sections of heap sort
        private bool buildMaxHeapForLoop = true;
        private bool buildMaxHeapWhileLoop = false;
        private bool heapSortForLoop = false;
        private bool heapSortWhileLoop = false;

        private bool stepComplete = false;


        private int leftChildIndex;
        private int rightChildIndex;
        private int endOfList;
        private int largestChildIndex;

        public override List<int> PerformStep()
        {
            // set up for first call of PerformStep()
            if (firstPass)
            {
                numberOfNodes = data.Count();

                nodeIndex = 1;

                firstPass = false;
            }

            // perform a swap of elements with index a and b
            if (swapStep)
            {
                // set special colours for elements being swapped
                specialColours.Clear();
                specialColours.Add((a, 1));
                specialColours.Add((b, 1));

                temp = data[a];
                data[a] = data[b];
                data[b] = temp;

                // increment swap counter
                numberOfSwaps++;

                swapStep = false;
            }
            else if (buildMaxHeapForLoop)
            {
                // define parentNodeIndex
                parentNodeIndex = (nodeIndex - 1) / 2;

                // set special colours for elements being compared
                specialColours.Clear();
                specialColours.Add((nodeIndex, 1));
                specialColours.Add((parentNodeIndex, 1));

                // increment comparison counter
                numberOfComparisons++;

                // check if the value of the child node is greater than the value of the parent node
                if (data[nodeIndex] > data[parentNodeIndex])
                {
                    // set j to be index of child node
                    j = nodeIndex;

                    // move to buildMaxHeapWhileLoop section
                    buildMaxHeapForLoop = false;
                    buildMaxHeapWhileLoop = true;
                }
                else
                {
                    // increment nodeIndex
                    nodeIndex++;

                    // if nodeIndex exceeds size of data set, move to heapSortForLoop section
                    if (nodeIndex == numberOfNodes)
                    {
                        buildMaxHeapForLoop = false;
                        heapSortForLoop = true;

                        nodeIndex = numberOfNodes - 1;
                    }
                }
            }
            else if (buildMaxHeapWhileLoop)
            {
                // set special colours for elements being compared
                specialColours.Clear();
                specialColours.Add((j, 1));
                specialColours.Add((parentNodeIndex, 1));

                // increment comparison counter
                numberOfComparisons++;

                // swap child and parent node until parent is larger
                parentNodeIndex = (j - 1) / 2;
                if (data[j] > data[parentNodeIndex])
                {
                    a = j;
                    b = parentNodeIndex;

                    swapStep = true;

                    // j point to parent node position after swap
                    j = parentNodeIndex;

                    // if the parent node is at the root, return to buildMaxHeapForLoop section
                    if (j == 0)
                    {
                        buildMaxHeapWhileLoop = false;
                        buildMaxHeapForLoop = true;
                    }
                }
                else
                {
                    buildMaxHeapWhileLoop = false;
                    buildMaxHeapForLoop = true;
                }
            }
            else if (heapSortForLoop)
            {
                if (nodeIndex > 0)
                {
                    // swap the largest element to the end
                    a = 0;
                    b = nodeIndex;

                    swapStep = true;

                    j = 0;

                    heapSortForLoop = false;
                    heapSortWhileLoop = true;
                }
                else
                {
                    sorted = true;
                }
            }

            if (stepComplete)
            {
                stepComplete = false;
            }
            else
            {
                if ((heapSortWhileLoop) && (swapStep))
                {
                    // set special colours for elements being swapped
                    specialColours.Clear();
                    specialColours.Add((a, 1));
                    specialColours.Add((b, 1));

                    temp = data[a];
                    data[a] = data[b];
                    data[b] = temp;

                    // increment swap counter
                    numberOfSwaps++;

                    swapStep = false;
                }
                else if (heapSortWhileLoop && (!swapStep))
                {
                    // set special colours for elements being compared
                    specialColours.Clear();
                    specialColours.Add((leftChildIndex, 1));
                    specialColours.Add((rightChildIndex, 1));
                    specialColours.Add((j, 1));

                    // increment comparison counter
                    numberOfComparisons++;

                    leftChildIndex = (2 * j) + 1;
                    rightChildIndex = leftChildIndex + 1;
                    endOfList = nodeIndex - 1;

                    largestChildIndex = leftChildIndex;

                    // identify whether left child or right child value is largest
                    if ((leftChildIndex < (endOfList)) && data[leftChildIndex] < data[rightChildIndex])
                    {
                        largestChildIndex = rightChildIndex;
                    }
                    if ((largestChildIndex < nodeIndex) && (data[j] < data[largestChildIndex]))
                    {
                        a = j;
                        b = largestChildIndex;
                        swapStep = true;

                        // set stepComplete to true so that two steps aren't performed on next call of PerformStep()
                        stepComplete = true;
                    }

                    j = largestChildIndex;

                    if (largestChildIndex >= nodeIndex)
                    {
                        nodeIndex--;

                        heapSortWhileLoop = false;
                        heapSortForLoop = true;
                    }
                }
            }
                        
            
            return data;
        }
    }
}

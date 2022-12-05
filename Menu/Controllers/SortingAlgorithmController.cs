using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Models;
using Prototype.Views;

namespace Prototype.Controllers
{
    class SortingAlgorithmController
    {
        private SortingAlgorithm firstAlgorithm;
        private SortingAlgorithm secondAlgorithm;
        private SortingAlgorithm tempAlgorithm;

        private SortingAlgorithm CreateInstanceOfAlgorithm(string choice)
        {
            // create an instance of algorithm corresponding to input value
            if (choice == "Bubble Sort")
            {
                tempAlgorithm = new BubbleSort();
            }
            else if (choice == "Insertion Sort")
            {
                tempAlgorithm = new InsertionSort();
            }
            else if (choice == "Quick Sort")
            {
                tempAlgorithm = new QuickSort();
            }
            else if (choice == "Merge Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }
            else if (choice == "Heap Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }

            // return tempAlgorithm
            return tempAlgorithm;
        }

        public async void Sort(SortingAlgorithmAnimationsUI parentForm, int numberOfElements, string startingOrder, string dataValues, string firstChoice, string secondChoice)
        {
            // TEST
            //Console.WriteLine($"number of elements : {numberOfElements}");
            //Console.WriteLine($"starting order : {startingOrder}");
            //Console.WriteLine($"data values : {dataValues}");
            //Console.WriteLine($"first sorting algorithm : {firstChoice}");
            //Console.WriteLine($"second sorting algorithm : {secondChoice}");

            // create initial data set
            List<int> firstInitialDataSet = CreateDataSet(numberOfElements, startingOrder, dataValues);
            // create copy of first data set
            List<int> secondInitialDataSet = new List<int>(firstInitialDataSet);

            // create an instance of the sorting algorithms
            firstAlgorithm = CreateInstanceOfAlgorithm(firstChoice);
            secondAlgorithm = CreateInstanceOfAlgorithm(secondChoice);

            // pass initial data set to sorting algorithms
            firstAlgorithm.DataSet = firstInitialDataSet;
            secondAlgorithm.DataSet = secondInitialDataSet;

            bool finished = firstAlgorithm.Sorted && secondAlgorithm.Sorted;

            List<int> firstAlgorithmData = new List<int>();
            List<int> secondAlgorithmData = new List<int>();

            int stepNumber = 0;


            // keep going until both algorithms are sorted
            while (!finished)
            {
                stepNumber++;

                // tell each algorithm to perform one step and return the current state of the data if not already sorted
                if (!firstAlgorithm.Sorted)
                {
                    firstAlgorithm.PerformStep();
                    firstAlgorithmData = firstAlgorithm.DataSet;
                }

                if (!secondAlgorithm.Sorted)
                {
                    secondAlgorithm.PerformStep();
                    secondAlgorithmData = secondAlgorithm.DataSet;
                }

                // get comparison and swap values
                int comparisonNum1 = firstAlgorithm.NumberOfComparisons;
                int swapNum1 = firstAlgorithm.NumberOfSwaps;
                int comparisonNum2 = secondAlgorithm.NumberOfComparisons;
                int swapNum2 = secondAlgorithm.NumberOfSwaps;

                // get special colour indexes and colour code
                List<(int, int)> specialColours1 = firstAlgorithm.SpecialColours;
                List<(int, int)> specialColours2 = secondAlgorithm.SpecialColours;

                // update the UI
                await parentForm.UpdateUI(stepNumber, firstAlgorithmData, secondAlgorithmData, comparisonNum1, swapNum1, comparisonNum2, swapNum2, specialColours1, specialColours2);
                
                // check if both algorithms are fully sorted
                finished = firstAlgorithm.Sorted && secondAlgorithm.Sorted;
            }

        }

        private List<int> CreateDataSet(int numberOfElements, string startingOrder, string dataValues)
        {
            List<int> dataSet1 = new List<int> { };

            // add each number from 1 to numberOfElements to dataSet
            if (dataValues == "All different")
            {
                for (int counter = 1; counter <= numberOfElements; counter++)
                {
                    dataSet1.Add(counter);
                }

                // TEST
                //Console.WriteLine(string.Join(", ", dataSet1));
            }
            // add 2-3 of each element
            else if (dataValues == "Few unique")
            {
                int counter = 1;

                // loop until the correct number of elements have been added to the list
                while (counter < numberOfElements)
                {
                    // add three lots of every third element to list unless there are 4 left
                    if (((numberOfElements - dataSet1.Count()) >= 3) && ((numberOfElements - dataSet1.Count()) != 4))
                    {
                        for (int i = 0; i<3; i++)
                        {
                            dataSet1.Add(counter);
                        }

                        counter += 3;
                    }
                    // if there are 4 elements left, add 2 lots of every second element left
                    else if ((numberOfElements - dataSet1.Count()) == 4)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                dataSet1.Add(counter);
                            }

                            counter += 2;
                        }
                    }
                    // if there are 2 elements left, add 2 lots the current value of counter
                    else if ((numberOfElements - dataSet1.Count()) == 2)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            dataSet1.Add(counter);
                        }

                        counter += 2;
                    }
                }
            }

            List<int> dataSet2 = new List<int> { };
            bool firstTry = true;
            Random rnd = new Random();
            
            // reverse dataSet1
            List<int> dataSet1Reversed = new List<int>(dataSet1);
            dataSet1Reversed.Reverse();

            if (startingOrder == "Random")
            {
                // enter loop if dataSet2 is already ordered, or it is the first try of creating dataSet2
                while ((dataSet2 == dataSet1) || (dataSet2 == dataSet1Reversed) || firstTry)
                {
                    dataSet2.RemoveRange(0, dataSet2.Count());
                    List<int> dataSet1Copy = new List<int> (dataSet1);
                    
                    for (int i = 0; i < numberOfElements; i++)
                    {
                        // get number of elements in original data set
                        int maxIndex = dataSet1Copy.Count();

                        // generate a random number to represent an index in the original data set
                        int randomIndex = rnd.Next(0, maxIndex);

                        // add the element at the random index in original data set to new data set
                        dataSet2.Add(dataSet1Copy[randomIndex]);
                        // remove the element selected from the original data set
                        dataSet1Copy.RemoveAt(randomIndex);
                    }

                    firstTry = false;
                }
                    
            }
            else if (startingOrder == "Reversed")
            {
                // set dataSet2 to equal the reversed version of dataSet1
                dataSet2 = dataSet1Reversed;
            }
            else if (startingOrder == "Fairly sorted")
            {
                // define leftIndex and rightIndex as the first elements to be swapped
                int leftIndex = 1;
                int rightIndex = dataSet1.Count() - 2;
                // declare temp variables to be used in swap
                int temp;

                // define dataSet2 to initially be dataSet1
                dataSet2 = dataSet1;

                // starting from leftIndex and right Index, swap every third from start index with third from end index
                while (leftIndex <= numberOfElements / 2)
                {
                    // swap
                    temp = dataSet2[leftIndex];
                    dataSet2[leftIndex] = dataSet2[rightIndex];
                    dataSet2[rightIndex] = temp;

                    // increment leftIndex by 3
                    leftIndex += 3;
                    // decrement rightIndex by 3
                    rightIndex -= 3;
                }
            }

            // TEST
            //Console.WriteLine(string.Join(", ", dataSet2));

            return dataSet2;
        }
    }
}

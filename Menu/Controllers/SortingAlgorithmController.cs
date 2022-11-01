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

        private (SortingAlgorithm, SortingAlgorithm) CreateInstanceOfAlgorithms(string firstChoice, string secondChoice)
        {
            // create an instance of the first sorting algorithm
            if (firstChoice == "Bubble Sort")
            {
                firstAlgorithm = new BubbleSort();
            }
            else if (firstChoice == "Insertion Sort")
            {
                firstAlgorithm = new InsertionSort();
            }
            else if (firstChoice == "Merge Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }
            else if (firstChoice == "Quick Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }
            else if (firstChoice == "Heap Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }


            // create an instance of the second algorithm
            if (secondChoice == "Bubble Sort")
            {
                secondAlgorithm = new BubbleSort();
            }
            else if (secondChoice == "Insertion Sort")
            {
                secondAlgorithm = new InsertionSort();
            }
            else if (secondChoice == "Merge Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }
            else if (secondChoice == "Quick Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }
            else if (secondChoice == "Heap Sort")
            {
                // TODO : FURTHER DEVELOPMENT
            }

            // return firstAlgorithm and secondAlgorithm
            return (firstAlgorithm, secondAlgorithm);
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
            (firstAlgorithm, secondAlgorithm) = CreateInstanceOfAlgorithms(firstChoice, secondChoice);

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

                // update the UI
                await parentForm.UpdateUI(stepNumber, firstAlgorithmData, secondAlgorithmData);
                
                // check if both algorithms are fully sorted
                finished = firstAlgorithm.Sorted && secondAlgorithm.Sorted;
            }

        }

        private List<int> CreateDataSet(int numberOfElements, string startingOrder, string dataValues)
        {
            return new List<int> { 15, 19, 4, 20, 5, 8, 3, 7, 1, 16, 14, 18, 2, 6, 9, 13, 11, 17, 10, 12 };
        }
    }
}

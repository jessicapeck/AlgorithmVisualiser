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
        
        public async void Sort(PrototypeUI parentForm)
        {
            // create initial data set
            List<int> firstInitialDataSet = CreateDataSet(9);
            // create copy of first data set
            List<int> secondInitialDataSet = new List<int>(firstInitialDataSet);

            // create an instance of the sorting algorithm
            SortingAlgorithm firstAlgorithm = new BubbleSort();
            SortingAlgorithm secondAlgorithm = new MockSortingAlgorithm();

            // pass initial data set to sorting algorithms
            firstAlgorithm.DataSet = firstInitialDataSet;
            secondAlgorithm.DataSet = secondInitialDataSet;

            bool finished = firstAlgorithm.Sorted() && secondAlgorithm.Sorted();

            List<int> firstAlgorithmData = new List<int>();
            List<int> secondAlgorithmData = new List<int>();

            int stepNumber = 0;


            // keep going until both algorithms are sorted
            while (!finished)
            {
                stepNumber++;

                // tell each algorithm to perform one step and return the current state of the data if not already sorted
                if (!firstAlgorithm.Sorted())
                {
                    firstAlgorithm.PerformStep();
                    firstAlgorithmData = firstAlgorithm.DataSet;
                }

                if (!secondAlgorithm.Sorted())
                {
                    secondAlgorithm.PerformStep();
                    secondAlgorithmData = secondAlgorithm.DataSet;
                }

                // update the UI
                await parentForm.UpdateUI(stepNumber, firstAlgorithmData, secondAlgorithmData);
                
                // check if both algorithms are fully sorted
                finished = firstAlgorithm.Sorted() && secondAlgorithm.Sorted();
            }

        }

        private List<int> CreateDataSet(int numberOfElements)
        {
            return new List<int> { 1, 5, 8, 2, 6, 3, 4, 9, 7 };
        }
    }
}

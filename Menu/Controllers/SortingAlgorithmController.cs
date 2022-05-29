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
        public void Sort(PrototypeUI parentForm)
        {
            // create initial data set
            List<int> initialDataSet = CreateDataSet(9);

            // create an instance of the sorting algorithm
            SortingAlgorithm firstAlgorithm = new MockSortingAlgorithm();
            SortingAlgorithm secondAlgorithm = new MockSortingAlgorithm();

            // pass initial data set to algorithms
            firstAlgorithm.InitialiseDataSet(initialDataSet);
            secondAlgorithm.InitialiseDataSet(initialDataSet);

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
                    firstAlgorithmData = firstAlgorithm.PerformStep();
                }

                if (!secondAlgorithm.Sorted())
                {
                    secondAlgorithmData = secondAlgorithm.PerformStep();
                }

                // update the UI
                parentForm.UpdateUI(stepNumber, firstAlgorithmData, secondAlgorithmData);


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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Models;
using Prototype.Views;

namespace Prototype.Controllers
{
    class InteractiveController
    {
        // for user choice of sorting algorithm
        private SortingAlgorithm sortingAlgorithm;

        public void SetUpAlgorithmChoices(string sortingAlgorithmChoice)
        {
            // create new instance of chosen sorting algorithm
            if (sortingAlgorithmChoice == "Bubble Sort")
            {
                sortingAlgorithm = new BubbleSort();
            }
            else if (sortingAlgorithmChoice == "Insertion Sort")
            {
                // TODO
            }
            else if (sortingAlgorithmChoice == "Merge Sort")
            {
                // TODO
            }
        }

        private void CreateDataSet()
        {
            List<int> data1 = new List<int> { };
            List<int> data2 = new List<int> { };

            int numberOfElements = 5;

            for (int num = 1; num <= numberOfElements; num++)
            {
                data1.Add(num);
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    class MockSortingAlgorithm : SortingAlgorithm
    {
        private List<int> data;
        private int counter = 0;

        public override void InitialiseDataSet(List<int> initialData)
        {
            data = new List<int>(initialData);            
        }

        public override List<int> PerformStep()
        {
            // move the first to the last
            int temp = data[0];
            data.RemoveAt(0);
            data.Add(temp);

            counter++;
            


            return data;
        }

        public override bool Sorted()
        {

            if (counter >= 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

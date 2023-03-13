using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    class MockSortingAlgorithm : SortingAlgorithm
    {
        private int counter = 0;        

        public override List<int> PerformStep()
        {
            // move the first to the last
            int temp = data[0];
            data.RemoveAt(0);
            data.Add(temp);

            counter++;

            // test : write contents of data set to console
            //Console.WriteLine("MOCK SORT: " + string.Join(", ", data));

            return data;
        }        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype.Controllers;

namespace Prototype.Views
{
    public partial class PrototypeUI : Form
    {
        public PrototypeUI()
        {
            InitializeComponent();
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            SortingAlgorithmController controller = new SortingAlgorithmController();
            controller.Sort(this);
        }

        public void UpdateUI(int stepNumber, List<int> data1, List<int> data2)
        {
            Console.WriteLine(stepNumber.ToString());

            Console.Write("Data1: ");
            data1.ForEach(Console.Write);
            Console.WriteLine();

            Console.Write("Data2: ");
            data2.ForEach(Console.Write);
            Console.WriteLine();
        }


    }
}

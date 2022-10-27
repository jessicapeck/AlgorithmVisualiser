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
        private List<int> firstAlgorithmBarHeights;
        private List<int> secondAlgorithmBarHeights;

        // declare a white pen and a black pen for drawing data bars
        private Pen whitePen = new Pen(Color.White);
        private Pen blackPen = new Pen(Color.Black);

        public PrototypeUI()
        {
            InitializeComponent();
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            SortingAlgorithmController controller = new SortingAlgorithmController();
            controller.Sort(this);
        }



        public async Task UpdateUI(int stepNumber, List<int> data1, List<int> data2)
        {
            firstAlgorithmBarHeights = data1;
            secondAlgorithmBarHeights = data2;

            // refresh both picture boxes
            first_algorithm_picture_box.Refresh();
            second_algorithm_picture_box.Refresh();

            // wait time
            await Task.Delay(this.speed_track_bar.Value);
            
            //Console.WriteLine(stepNumber);
        }

        private void drawBars(Graphics g, List<int> barHeights)
        {
            // identify the maximum element in the list
            int maxHeight = barHeights.Max();

            // define the scaling of the lines
            int y_scaling = (first_algorithm_picture_box.Height - 10) / maxHeight;
            int x_scaling = ((first_algorithm_picture_box.Width - 10 - (5 * barHeights.Count)) / barHeights.Count);

            // set the width of the pens to the scaling in the x-direction
            whitePen.Width = x_scaling;
            blackPen.Width = x_scaling;

            // define starting x and y positions within the picture box
            int xPosition = 10;
            int yPosition = first_algorithm_picture_box.Height - 10;

            // iterate through each data element in the list
            // first draw a white line of max height to cover up previous line
            // then draw a black line of the correct heights
            foreach (int barHeight in barHeights)
            {
                g.DrawLine(whitePen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (maxHeight * y_scaling)));
                g.DrawLine(blackPen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (barHeight * y_scaling)));

                xPosition += x_scaling + 5;
            }            
        }

        private void first_algorithm_picture_box_Paint(object sender, PaintEventArgs e)
        {
            if (firstAlgorithmBarHeights != null)
            {
                drawBars(e.Graphics, firstAlgorithmBarHeights);
            }

        }

        private void second_algorithm_picture_box_Paint(object sender, PaintEventArgs e)
        {
            if (secondAlgorithmBarHeights != null)
            {
                drawBars(e.Graphics, secondAlgorithmBarHeights);
            }
        }


    }
}

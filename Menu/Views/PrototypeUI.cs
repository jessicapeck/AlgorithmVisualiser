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
        private Pen whitePen = new Pen(Color.White, 10);
        private Pen blackPen = new Pen(Color.Black, 10);

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
            int scaling = 30;

            // define starting x and y positions within the picture box
            int xPosition = 10;
            int yPosition = 10 + (maxHeight * scaling);

            // iterate through each data element in the list
            // first draw a white line of max height to cover up previous line
            // then draw a black line of the correct height
            foreach (int barHeight in barHeights)
            {
                g.DrawLine(whitePen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (maxHeight * scaling)));
                g.DrawLine(blackPen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (barHeight * scaling)));

                xPosition += 15;
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

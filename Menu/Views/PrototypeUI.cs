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

            firstAlgorithmPictureBox.Refresh();
            await Task.Delay(this.speed_track_bar.Value);
            Console.WriteLine(stepNumber);
        }

        private void drawBars(Graphics g, List<int> barHeights)
        {
            int maxHeight = barHeights.Max();
            int xPosition = 10;
            int yPosition = 10 + (maxHeight * 30);

            foreach (int barHeight in barHeights)
            {
                g.DrawLine(whitePen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (maxHeight * 30)));
                g.DrawLine(blackPen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (barHeight * 30)));

                xPosition += 15;
            }

            
        }

        private void firstAlgorithmPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (firstAlgorithmBarHeights != null)
            {
                drawBars(e.Graphics, firstAlgorithmBarHeights);
            }
        }
    }
}

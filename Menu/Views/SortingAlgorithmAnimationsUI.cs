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
    public partial class SortingAlgorithmAnimationsUI : Form
    {

        private List<int> firstAlgorithmBarHeights;
        private List<int> secondAlgorithmBarHeights;

        private int barHeight;
        private List<int> specialColourIndexes;
        int specialColourIndex;

        private List<(int, int)> firstAlgorithmSpecialColours;
        private List<(int, int)> secondAlgorithmSpecialColours;

        // declare a light grey pen for drawing covering up previous data bars
        private Pen lightGrayPen = new Pen(Color.LightGray);

        // declare a black pen
        private Pen blackPen = new Pen(Color.Black);

        // declare special colour pen
        private Pen pen2 = new Pen(Color.Black);

        private int colourNum;

        // radio button values
        private string startingOrder;
        private string dataValues;

        // sorting algorithm choices
        private string firstSortingAlgorithm;
        private string secondSortingAlgorithm;

        // controller
        private SortingAlgorithmController controller;

        // to determine if picture box needs to be cleared
        private bool stopAnimations = false;

        private Form helpForm;


        public SortingAlgorithmAnimationsUI()
        {
            InitializeComponent();

            UISetup();
        }

        // setup for initial form UI
        private void UISetup()
        {

            // set default values for radio buttons
            random_radioButton.Checked = true;
            all_different_radioButton.Checked = true;

            // set default values for combo boxes to choose sorting algorithm
            algorithm1_comboBox.SelectedIndex = 0;
            algorithm2_comboBox.SelectedIndex = 0;

            // set up START PAUSE PLAY STOP button controls
            start_button.Enabled = true;
            start_button.BackColor = Color.MediumSeaGreen;

            pause_button.Enabled = false;
            pause_button.BackColor = Color.Gray;

            play_button.Enabled = false;
            play_button.BackColor = Color.Gray;

            stop_button.Enabled = false;
            stop_button.BackColor = Color.Gray;

            // set text for number of elements label
            number_of_elements_counter_label.Text = number_of_elements_trackBar.Value.ToString();
        }

        private void number_of_elements_trackBar_ValueChanged(object sender, EventArgs e)
        {
            // set text for number of elements label
            number_of_elements_counter_label.Text = number_of_elements_trackBar.Value.ToString();
        }

        public void AlgorithmsFinished()
        {
            // set up START PAUSE PLAY STOP button controls
            start_button.Enabled = true;
            start_button.BackColor = Color.MediumSeaGreen;

            pause_button.Enabled = false;
            pause_button.BackColor = Color.Gray;

            play_button.Enabled = false;
            play_button.BackColor = Color.Gray;

            stop_button.Enabled = false;
            stop_button.BackColor = Color.Gray;
        }

        private (string, string) CollectRadioButtonData()
        {
            // get checked option from starting order list
            if (random_radioButton.Checked == true)
            {
                startingOrder = random_radioButton.Text;
            }
            else if (reversed_radioButton.Checked == true)
            {
                startingOrder = reversed_radioButton.Text;
            }
            else if (partially_sorted_radioButton.Checked == true)
            {
                startingOrder = partially_sorted_radioButton.Text;
            }

            // get checked option from data values list
            if (all_different_radioButton.Checked == true)
            {
                dataValues = all_different_radioButton.Text;
            }
            else if (few_unique_radioButton.Checked == true)
            {
                dataValues = few_unique_radioButton.Text;
            }

            return (startingOrder, dataValues);
        }

        private (string, string) CollectSortingAlgorithmChoices()
        {
            // get sorting algorithm choices from combo boxes
            firstSortingAlgorithm = algorithm1_comboBox.Text;
            secondSortingAlgorithm = algorithm2_comboBox.Text;

            return (firstSortingAlgorithm, secondSortingAlgorithm);

        }

        // open help form
        private void help_button_Click(object sender, EventArgs e)
        {
            if ((helpForm == null) || (helpForm.IsDisposed))
            {
                // open help form with instructions on how to use feature
                helpForm = new SortingAlgorithmAnimationsHelpUI();
            }

            helpForm.Show();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            // disable START button, enable PAUSE and STOP button
            start_button.Enabled = false;
            start_button.BackColor = Color.Gray;

            pause_button.Enabled = true;
            pause_button.BackColor = Color.CornflowerBlue;

            play_button.Enabled = false;
            play_button.BackColor = Color.Gray;

            stop_button.Enabled = true;
            stop_button.BackColor = Color.OrangeRed;

            // create new instance of SortingAlgorithmController
            controller = new SortingAlgorithmController();

            // collect data from animation preferences

            int numberOfElements = number_of_elements_trackBar.Value;

            (startingOrder, dataValues) = CollectRadioButtonData();

            (firstSortingAlgorithm, secondSortingAlgorithm) = CollectSortingAlgorithmChoices();

            controller.PlayAnimations();
            controller.SetUpPreferences(numberOfElements, startingOrder, dataValues, firstSortingAlgorithm, secondSortingAlgorithm);
            controller.Sort(this);

        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            // disable PAUSE button, enable PLAY and STOP button
            start_button.Enabled = false;
            start_button.BackColor = Color.Gray;

            pause_button.Enabled = false;
            pause_button.BackColor = Color.Gray;

            play_button.Enabled = true;
            play_button.BackColor = Color.CornflowerBlue;

            stop_button.Enabled = true;
            stop_button.BackColor = Color.OrangeRed;


            controller.PauseAnimations();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            // disable PLAY button, enable PAUSE and STOP button
            start_button.Enabled = false;
            start_button.BackColor = Color.Gray;

            pause_button.Enabled = true;
            pause_button.BackColor = Color.CornflowerBlue;

            play_button.Enabled = false;
            play_button.BackColor = Color.Gray;

            stop_button.Enabled = true;
            stop_button.BackColor = Color.OrangeRed;

            controller.PlayAnimations();
            controller.Sort(this);

        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            // disable PAUSE, PLAY, and STOP button, enable START button
            start_button.Enabled = true;
            start_button.BackColor = Color.MediumSeaGreen;

            pause_button.Enabled = false;
            pause_button.BackColor = Color.Gray;

            play_button.Enabled = false;
            play_button.BackColor = Color.Gray;

            stop_button.Enabled = false;
            stop_button.BackColor = Color.Gray;

            controller.PauseAnimations();

            // set stopAnimations to true
            stopAnimations = true;

            // refresh both picture boxes
            first_algorithm_pictureBox.Refresh();
            second_algorithm_pictureBox.Refresh();

            // set stopAnimations to false
            stopAnimations = false;

            UpdateComparisonSwapCounters(0, 0, 0, 0);
        }

        public async Task UpdateUI(List<int> data1, List<int> data2, int comparisonNum1, int swapNum1, int comparisonNum2, int swapNum2, List<(int, int)> specialColours1, List<(int, int)> specialColours2)
        {

            firstAlgorithmBarHeights = data1;
            secondAlgorithmBarHeights = data2;

            firstAlgorithmSpecialColours = specialColours1;
            secondAlgorithmSpecialColours = specialColours2;

            // refresh both picture boxes
            first_algorithm_pictureBox.Refresh();
            second_algorithm_pictureBox.Refresh();

            // update comparison and swap counters
            UpdateComparisonSwapCounters(comparisonNum1, swapNum1, comparisonNum2, swapNum2);

            // wait time
            await Task.Delay(this.speed_trackBar.Value);

            //Console.WriteLine(stepNumber);
        }

        private void UpdateComparisonSwapCounters(int comparisonNum1, int swapNum1, int comparisonNum2, int swapNum2)
        {
            // change the text on the comparison and swap labels
            algorithm1_num_comparisons_label.Text = $"Number of comparisons : {comparisonNum1}";
            algorithm1_num_swaps_label.Text = $"Number of swaps : {swapNum1}";
            algorithm2_num_comparisons_label.Text = $"Number of comparisons : {comparisonNum2}";
            algorithm2_num_swaps_label.Text = $"Number of swaps : {swapNum2}";
        }

        private void DrawBars(Graphics g, List<int> barHeights, List<(int,int)> specialColours)
        {
            // identify the maximum element in the list
            int maxHeight = barHeights.Max();

            // get special colour indexes from list of tuples
            specialColourIndexes = specialColours.Select(t => t.Item1).ToList();

            // define the scaling of the lines
            int xScaling = ((first_algorithm_pictureBox.Width - 10 - (5 * barHeights.Count)) / barHeights.Count);
            int yScaling = (first_algorithm_pictureBox.Height - 10) / maxHeight;

            // set the width of the pens to the scaling in the x-direction
            lightGrayPen.Width = xScaling;
            pen2.Width = xScaling;

            // define starting x and y positions within the picture box
            int xPosition = 10 + (xScaling / 2);
            int yPosition = first_algorithm_pictureBox.Height - 10;

            // FUTURE MAINTENANCE : uncomment for no special coloured bars, only black
            
            // iterate through each data element in the list
            // first draw a white line of max height to cover up previous line
            // then draw a black line of the correct heights

            //foreach (int barHeight in barHeights)
            //{
            //    g.DrawLine(lightGrayPen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (maxHeight * yScaling)));
            //    g.DrawLine(blackPen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (barHeight * yScaling)));

            //    xPosition += xScaling + 5;

            //}

            for (int barIndex = 0; barIndex < barHeights.Count(); barIndex++)
            {
                barHeight = barHeights[barIndex];

                // check if index of current bar is in specialColourIndexes
                if (specialColourIndexes.Contains(barIndex))
                {
                    // get pen colour corresponding to colourNum
                    specialColourIndex = specialColourIndexes.IndexOf(barIndex);
                    colourNum = specialColours[specialColourIndex].Item2;

                    if (colourNum == 1)
                    {
                        pen2.Color = Color.MediumPurple;
                    }
                    else if (colourNum == 2)
                    {
                        pen2.Color = Color.Teal;
                    }
                }
                else
                {
                    pen2.Color = Color.Black;
                }

                g.DrawLine(lightGrayPen, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (maxHeight * yScaling)));
                g.DrawLine(pen2, new Point(xPosition, yPosition), new Point(xPosition, yPosition - (barHeight * yScaling)));

                xPosition += xScaling + 5;

            }
        }

        private void ClearPictureBoxes(Graphics g)
        {
            // clear picture box with solid background colour
            g.Clear(Color.LightGray);
        }

        private void first_algorithm_picture_box_Paint(object sender, PaintEventArgs e)
        {
            // clear picture boxes if STOP button clicked
            if (stopAnimations)
            {
                ClearPictureBoxes(e.Graphics);
            }
            // call DrawBars if firstAlgorithmBarHeights not null
            else if (firstAlgorithmBarHeights != null)
            {
                DrawBars(e.Graphics, firstAlgorithmBarHeights, firstAlgorithmSpecialColours);
            }
        }

        private void second_algorithm_picture_box_Paint(object sender, PaintEventArgs e)
        {
            // clear picture boxes if STOP button clicked
            if (stopAnimations)
            {
                ClearPictureBoxes(e.Graphics);
            }
            // call DrawBars if secondAlgorithmBarHeights not null
            else if (secondAlgorithmBarHeights != null)
            {
                DrawBars(e.Graphics, secondAlgorithmBarHeights, secondAlgorithmSpecialColours);
            }
        }

        // TODO : FUTURE DEVELOPMENT
        private void shortest_path_button_Click(object sender, EventArgs e)
        {

        }

        private void interactive_algorithms_button_Click(object sender, EventArgs e)
        {

        }

        private void facts_information_button_Click(object sender, EventArgs e)
        {

        }
    }
}

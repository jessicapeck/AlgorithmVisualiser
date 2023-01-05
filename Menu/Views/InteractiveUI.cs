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

namespace Prototype
{
    public partial class InteractiveUI : Form
    {
        // controller
        private InteractiveController controller;

        public InteractiveUI()
        {
            InitializeComponent();
        }

        private void InteractiveUI_Load(object sender, EventArgs e)
        {          
            // disable end test button on form load
            end_test_button.Enabled = false;
            end_test_button.BackColor = Color.Gray;

            // make question label not visible
            question_label.Visible = false;

            // create controller
            controller = new InteractiveController();
        }

        private void bubble_sort_button_Click(object sender, EventArgs e)
        {
            // disable sorting algorithm buttons
            bubble_sort_button.Enabled = false;
            bubble_sort_button.BackColor = Color.Gray;

            // enable end test button
            end_test_button.Enabled = true;
            end_test_button.BackColor = Color.OrangeRed;

            // make question visible
            question_label.Visible = true;

            // send algorithm choice to controller
            controller.SetUpAlgorithmChoices("Bubble Sort");
        }

        private void end_test_button_Click(object sender, EventArgs e)
        {
            // enable mock sorting algorithm button
            bubble_sort_button.Enabled = true;
            bubble_sort_button.BackColor = Color.LightSkyBlue;

            // disable end test button
            end_test_button.Enabled = false;
            end_test_button.BackColor = Color.Gray;

            // make question label not visible
            question_label.Visible = false;
        }

        
    }
}

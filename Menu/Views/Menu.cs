using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype.Views;
using Prototype.Controllers;

namespace Prototype
{
    public partial class Menu : Form
    {
        // declare form object names
        Form sortingAlgorithmAnimationsForm;
        Form interactiveSortingAlgorithmsForm;
        Form factsAndInformationForm;
        Form shortestPathAlgorithmsForm;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // make all feature buttons enabled and visible
            sorting_algorithm_animations_button.Enabled = true;
            sorting_algorithm_animations_button.Visible = true;

            shortest_path_algorithms_button.Enabled = true;
            shortest_path_algorithms_button.Visible = true;

            interactive_algorithms_button.Enabled = true;
            interactive_algorithms_button.Visible = true;

            algorithm_information_button.Enabled = true;
            algorithm_information_button.Visible = true;
        }

        private void sorting_algorithm_animations_button_Click(object sender, EventArgs e)
        {
            if ((sortingAlgorithmAnimationsForm == null) || (sortingAlgorithmAnimationsForm.IsDisposed))
            {
                // open sorting algorithm animations form
                sortingAlgorithmAnimationsForm = new SortingAlgorithmAnimationsUI();
            }

            sortingAlgorithmAnimationsForm.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            // set up initial UI states for menu
            SetUpFormUI();
        }

        private void SetUpFormUI()
        {
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
            //var cheese = new SortingAlgorithmAnimationUI();
            //cheese.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

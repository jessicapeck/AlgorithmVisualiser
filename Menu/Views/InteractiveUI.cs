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
    public partial class InteractiveUI : Form
    {
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
        }

        private void mock_sorting_algorithm_button_Click(object sender, EventArgs e)
        {
            // disable mock sorting algorithm button
            //mock_sorting_algorithm_button.Enabled = false;
            //mock_sorting_algorithm_button.BackColor = Color.Gray;

            // enable end test button
            end_test_button.Enabled = true;
            end_test_button.BackColor = Color.OrangeRed;

            // make question visible
            question_label.Visible = true;
        }

        private void end_test_button_Click(object sender, EventArgs e)
        {
            // enable mock sorting algorithm button
            //mock_sorting_algorithm_button.Enabled = true;
            //mock_sorting_algorithm_button.BackColor = Color.WhiteSmoke;

            // disable end test button
            end_test_button.Enabled = false;
            end_test_button.BackColor = Color.Gray;

            // make question label not visible
            question_label.Visible = false;
        }
    }
}

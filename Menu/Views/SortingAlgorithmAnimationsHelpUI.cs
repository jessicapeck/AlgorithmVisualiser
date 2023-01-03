using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Views
{
    public partial class SortingAlgorithmAnimationsHelpUI : Form
    {
        string text;

        public SortingAlgorithmAnimationsHelpUI()
        {
            InitializeComponent();

            text = System.IO.File.ReadAllText(@"C:\Users\jess\OFFICIAL_PROJECT_WORK\AlgorithmVisualiser\Menu\Views\HelpText\SortingAlgorithmAnimationsHelpText.txt");

            help_text_label.Text = text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Prototype.Views
{
    public partial class SortingAlgorithmAnimationsHelpUI : Form
    {
        string text;

        public SortingAlgorithmAnimationsHelpUI()
        {
            InitializeComponent();

            // load help text from an embedded resource
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Prototype.Views.HelpText.SortingAlgorithmAnimationsHelpText.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            // set label text to be the help text
            help_text_label.Text = text;
        }
    }
}

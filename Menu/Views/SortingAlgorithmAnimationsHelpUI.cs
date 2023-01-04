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
        

        public SortingAlgorithmAnimationsHelpUI()
        {
            InitializeComponent();
        }

        private void SortingAlgorithmAnimationsHelpUI_Load(object sender, EventArgs e)
        {
            string htmlContent;

            //// load help text from an embedded resource
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Prototype.Views.HelpText.sortingalgorithmanimationshelptext.html";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                htmlContent = reader.ReadToEnd();
            }

            // set label text to be the help text
            help_text_webBrowser.DocumentText = htmlContent;

        }
    }
}

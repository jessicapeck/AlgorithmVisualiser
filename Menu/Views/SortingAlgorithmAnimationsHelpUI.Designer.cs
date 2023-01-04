
namespace Prototype.Views
{
    partial class SortingAlgorithmAnimationsHelpUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.help_text_webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // help_text_webBrowser
            // 
            this.help_text_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.help_text_webBrowser.Location = new System.Drawing.Point(0, 0);
            this.help_text_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.help_text_webBrowser.Name = "help_text_webBrowser";
            this.help_text_webBrowser.Size = new System.Drawing.Size(647, 1027);
            this.help_text_webBrowser.TabIndex = 0;
            // 
            // SortingAlgorithmAnimationsHelpUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 1027);
            this.Controls.Add(this.help_text_webBrowser);
            this.Name = "SortingAlgorithmAnimationsHelpUI";
            this.Text = "SortingAlgorithmAnimationsHelp";
            this.Load += new System.EventHandler(this.SortingAlgorithmAnimationsHelpUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser help_text_webBrowser;
    }
}
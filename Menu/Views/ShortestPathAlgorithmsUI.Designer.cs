
namespace Prototype
{
    partial class ShortestPathAlgorithmsUI
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
            this.shortest_path_button = new System.Windows.Forms.Button();
            this.facts_information_button = new System.Windows.Forms.Button();
            this.interactive_algorithms_button = new System.Windows.Forms.Button();
            this.sorting_algorithms_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // shortest_path_button
            // 
            this.shortest_path_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shortest_path_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.shortest_path_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortest_path_button.ForeColor = System.Drawing.Color.White;
            this.shortest_path_button.Location = new System.Drawing.Point(898, 12);
            this.shortest_path_button.Name = "shortest_path_button";
            this.shortest_path_button.Size = new System.Drawing.Size(306, 41);
            this.shortest_path_button.TabIndex = 15;
            this.shortest_path_button.Text = "Shortest Path Algorithm";
            this.shortest_path_button.UseVisualStyleBackColor = false;
            // 
            // facts_information_button
            // 
            this.facts_information_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facts_information_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.facts_information_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facts_information_button.ForeColor = System.Drawing.Color.White;
            this.facts_information_button.Location = new System.Drawing.Point(582, 12);
            this.facts_information_button.Name = "facts_information_button";
            this.facts_information_button.Size = new System.Drawing.Size(310, 41);
            this.facts_information_button.TabIndex = 14;
            this.facts_information_button.Text = "Facts and Information";
            this.facts_information_button.UseVisualStyleBackColor = false;
            this.facts_information_button.Click += new System.EventHandler(this.facts_information_button_Click);
            // 
            // interactive_algorithms_button
            // 
            this.interactive_algorithms_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interactive_algorithms_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.interactive_algorithms_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactive_algorithms_button.ForeColor = System.Drawing.Color.White;
            this.interactive_algorithms_button.Location = new System.Drawing.Point(383, 12);
            this.interactive_algorithms_button.Name = "interactive_algorithms_button";
            this.interactive_algorithms_button.Size = new System.Drawing.Size(193, 41);
            this.interactive_algorithms_button.TabIndex = 13;
            this.interactive_algorithms_button.Text = "InteractiveUI";
            this.interactive_algorithms_button.UseVisualStyleBackColor = false;
            this.interactive_algorithms_button.Click += new System.EventHandler(this.interactive_algorithms_button_Click);
            // 
            // sorting_algorithms_button
            // 
            this.sorting_algorithms_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sorting_algorithms_button.AutoSize = true;
            this.sorting_algorithms_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.sorting_algorithms_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorting_algorithms_button.ForeColor = System.Drawing.Color.White;
            this.sorting_algorithms_button.Location = new System.Drawing.Point(16, 12);
            this.sorting_algorithms_button.Name = "sorting_algorithms_button";
            this.sorting_algorithms_button.Size = new System.Drawing.Size(361, 41);
            this.sorting_algorithms_button.TabIndex = 12;
            this.sorting_algorithms_button.Text = "Sorting Algorithm Animations";
            this.sorting_algorithms_button.UseVisualStyleBackColor = false;
            this.sorting_algorithms_button.Click += new System.EventHandler(this.sorting_algorithms_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(7, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 74);
            this.panel1.TabIndex = 16;
            // 
            // ShortestPathAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 890);
            this.Controls.Add(this.shortest_path_button);
            this.Controls.Add(this.facts_information_button);
            this.Controls.Add(this.interactive_algorithms_button);
            this.Controls.Add(this.sorting_algorithms_button);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1234, 890);
            this.Name = "ShortestPathAlgorithms";
            this.Text = "ShortestPathAlgorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shortest_path_button;
        private System.Windows.Forms.Button facts_information_button;
        private System.Windows.Forms.Button interactive_algorithms_button;
        private System.Windows.Forms.Button sorting_algorithms_button;
        private System.Windows.Forms.Panel panel1;
    }
}
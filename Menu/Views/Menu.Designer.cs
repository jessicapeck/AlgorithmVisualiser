
namespace Prototype
{
    partial class Menu
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.sorting_algorithm_animations_button = new System.Windows.Forms.Button();
            this.shortest_path_algorithms_button = new System.Windows.Forms.Button();
            this.algorithm_information_button = new System.Windows.Forms.Button();
            this.interactive_algorithms_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.welcome_label.Location = new System.Drawing.Point(43, 36);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(773, 52);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome to the Algorithm Visualiser!";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sorting_algorithm_animations_button
            // 
            this.sorting_algorithm_animations_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sorting_algorithm_animations_button.AutoSize = true;
            this.sorting_algorithm_animations_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sorting_algorithm_animations_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorting_algorithm_animations_button.Location = new System.Drawing.Point(22, 178);
            this.sorting_algorithm_animations_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sorting_algorithm_animations_button.Name = "sorting_algorithm_animations_button";
            this.sorting_algorithm_animations_button.Size = new System.Drawing.Size(352, 102);
            this.sorting_algorithm_animations_button.TabIndex = 1;
            this.sorting_algorithm_animations_button.Text = "Sorting Algorithm Animations";
            this.sorting_algorithm_animations_button.UseVisualStyleBackColor = false;
            this.sorting_algorithm_animations_button.Click += new System.EventHandler(this.sorting_algorithm_animations_button_Click);
            // 
            // shortest_path_algorithms_button
            // 
            this.shortest_path_algorithms_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shortest_path_algorithms_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.shortest_path_algorithms_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortest_path_algorithms_button.Location = new System.Drawing.Point(452, 178);
            this.shortest_path_algorithms_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shortest_path_algorithms_button.Name = "shortest_path_algorithms_button";
            this.shortest_path_algorithms_button.Size = new System.Drawing.Size(352, 102);
            this.shortest_path_algorithms_button.TabIndex = 2;
            this.shortest_path_algorithms_button.Text = "Shortest Path Algorithms";
            this.shortest_path_algorithms_button.UseVisualStyleBackColor = false;
            this.shortest_path_algorithms_button.Click += new System.EventHandler(this.shortest_path_algorithms_button_Click);
            // 
            // algorithm_information_button
            // 
            this.algorithm_information_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algorithm_information_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.algorithm_information_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm_information_button.Location = new System.Drawing.Point(464, 305);
            this.algorithm_information_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.algorithm_information_button.Name = "algorithm_information_button";
            this.algorithm_information_button.Size = new System.Drawing.Size(352, 102);
            this.algorithm_information_button.TabIndex = 3;
            this.algorithm_information_button.Text = "Algorithm Information";
            this.algorithm_information_button.UseVisualStyleBackColor = false;
            this.algorithm_information_button.Click += new System.EventHandler(this.algorithm_information_button_Click);
            // 
            // interactive_algorithms_button
            // 
            this.interactive_algorithms_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.interactive_algorithms_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.interactive_algorithms_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactive_algorithms_button.Location = new System.Drawing.Point(22, 305);
            this.interactive_algorithms_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interactive_algorithms_button.Name = "interactive_algorithms_button";
            this.interactive_algorithms_button.Size = new System.Drawing.Size(352, 102);
            this.interactive_algorithms_button.TabIndex = 4;
            this.interactive_algorithms_button.Text = "Interactive Algorithms";
            this.interactive_algorithms_button.UseVisualStyleBackColor = false;
            this.interactive_algorithms_button.Click += new System.EventHandler(this.interactive_algorithms_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(876, 867);
            this.Controls.Add(this.interactive_algorithms_button);
            this.Controls.Add(this.algorithm_information_button);
            this.Controls.Add(this.shortest_path_algorithms_button);
            this.Controls.Add(this.sorting_algorithm_animations_button);
            this.Controls.Add(this.welcome_label);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(886, 741);
            this.Name = "Menu";
            this.Text = "Algorithm Visualiser";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button sorting_algorithm_animations_button;
        private System.Windows.Forms.Button shortest_path_algorithms_button;
        private System.Windows.Forms.Button algorithm_information_button;
        private System.Windows.Forms.Button interactive_algorithms_button;
    }
}


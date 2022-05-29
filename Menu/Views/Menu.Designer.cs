
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
            this.need_help_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.welcome_label.Location = new System.Drawing.Point(36, 82);
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
            this.sorting_algorithm_animations_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorting_algorithm_animations_button.Location = new System.Drawing.Point(255, 235);
            this.sorting_algorithm_animations_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sorting_algorithm_animations_button.Name = "sorting_algorithm_animations_button";
            this.sorting_algorithm_animations_button.Size = new System.Drawing.Size(352, 102);
            this.sorting_algorithm_animations_button.TabIndex = 1;
            this.sorting_algorithm_animations_button.Text = "Sorting Algorithm Animations";
            this.sorting_algorithm_animations_button.UseVisualStyleBackColor = true;
            this.sorting_algorithm_animations_button.Click += new System.EventHandler(this.sorting_algorithm_animations_button_Click);
            // 
            // shortest_path_algorithms_button
            // 
            this.shortest_path_algorithms_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shortest_path_algorithms_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortest_path_algorithms_button.Location = new System.Drawing.Point(255, 346);
            this.shortest_path_algorithms_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shortest_path_algorithms_button.Name = "shortest_path_algorithms_button";
            this.shortest_path_algorithms_button.Size = new System.Drawing.Size(352, 102);
            this.shortest_path_algorithms_button.TabIndex = 2;
            this.shortest_path_algorithms_button.Text = "Shortest Path Algorithms";
            this.shortest_path_algorithms_button.UseVisualStyleBackColor = true;
            this.shortest_path_algorithms_button.Click += new System.EventHandler(this.shortest_path_algorithms_button_Click);
            // 
            // algorithm_information_button
            // 
            this.algorithm_information_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algorithm_information_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm_information_button.Location = new System.Drawing.Point(255, 568);
            this.algorithm_information_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.algorithm_information_button.Name = "algorithm_information_button";
            this.algorithm_information_button.Size = new System.Drawing.Size(352, 102);
            this.algorithm_information_button.TabIndex = 3;
            this.algorithm_information_button.Text = "Algorithm Information";
            this.algorithm_information_button.UseVisualStyleBackColor = true;
            this.algorithm_information_button.Click += new System.EventHandler(this.algorithm_information_button_Click);
            // 
            // interactive_algorithms_button
            // 
            this.interactive_algorithms_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.interactive_algorithms_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactive_algorithms_button.Location = new System.Drawing.Point(255, 457);
            this.interactive_algorithms_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interactive_algorithms_button.Name = "interactive_algorithms_button";
            this.interactive_algorithms_button.Size = new System.Drawing.Size(352, 102);
            this.interactive_algorithms_button.TabIndex = 4;
            this.interactive_algorithms_button.Text = "Interactive Algorithms";
            this.interactive_algorithms_button.UseVisualStyleBackColor = true;
            this.interactive_algorithms_button.Click += new System.EventHandler(this.interactive_algorithms_button_Click);
            // 
            // need_help_button
            // 
            this.need_help_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.need_help_button.Location = new System.Drawing.Point(726, 809);
            this.need_help_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.need_help_button.Name = "need_help_button";
            this.need_help_button.Size = new System.Drawing.Size(132, 35);
            this.need_help_button.TabIndex = 5;
            this.need_help_button.Text = "Need help?";
            this.need_help_button.UseVisualStyleBackColor = true;
            this.need_help_button.Click += new System.EventHandler(this.need_help_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 35);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 863);
            this.Controls.Add(this.need_help_button);
            this.Controls.Add(this.interactive_algorithms_button);
            this.Controls.Add(this.algorithm_information_button);
            this.Controls.Add(this.shortest_path_algorithms_button);
            this.Controls.Add(this.sorting_algorithm_animations_button);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(886, 741);
            this.Name = "Menu";
            this.Text = "Algorithm Visualiser";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button sorting_algorithm_animations_button;
        private System.Windows.Forms.Button shortest_path_algorithms_button;
        private System.Windows.Forms.Button algorithm_information_button;
        private System.Windows.Forms.Button interactive_algorithms_button;
        private System.Windows.Forms.Button need_help_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}


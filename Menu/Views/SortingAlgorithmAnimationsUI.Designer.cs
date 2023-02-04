
namespace Prototype.Views
{
    partial class SortingAlgorithmAnimationsUI
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
            this.second_algorithm_pictureBox = new System.Windows.Forms.PictureBox();
            this.first_algorithm_pictureBox = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.speed_trackBar = new System.Windows.Forms.TrackBar();
            this.pause_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.help_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.number_of_elements_counter_label = new System.Windows.Forms.Label();
            this.data_values_groupBox = new System.Windows.Forms.GroupBox();
            this.few_unique_radioButton = new System.Windows.Forms.RadioButton();
            this.all_different_radioButton = new System.Windows.Forms.RadioButton();
            this.starting_order_groupBox = new System.Windows.Forms.GroupBox();
            this.reversed_radioButton = new System.Windows.Forms.RadioButton();
            this.partially_sorted_radioButton = new System.Windows.Forms.RadioButton();
            this.random_radioButton = new System.Windows.Forms.RadioButton();
            this.speed_label = new System.Windows.Forms.Label();
            this.number_of_elements_trackBar = new System.Windows.Forms.TrackBar();
            this.number_of_elements_label = new System.Windows.Forms.Label();
            this.animation_preferences_label = new System.Windows.Forms.Label();
            this.algorithm1_comboBox = new System.Windows.Forms.ComboBox();
            this.algorithm2_comboBox = new System.Windows.Forms.ComboBox();
            this.algorithm1_num_comparisons_label = new System.Windows.Forms.Label();
            this.algorithm1_num_swaps_label = new System.Windows.Forms.Label();
            this.algorithm2_num_comparisons_label = new System.Windows.Forms.Label();
            this.algorithm2_num_swaps_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.second_algorithm_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_algorithm_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.data_values_groupBox.SuspendLayout();
            this.starting_order_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_elements_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // second_algorithm_pictureBox
            // 
            this.second_algorithm_pictureBox.BackColor = System.Drawing.Color.LightGray;
            this.second_algorithm_pictureBox.Location = new System.Drawing.Point(838, 152);
            this.second_algorithm_pictureBox.Name = "second_algorithm_pictureBox";
            this.second_algorithm_pictureBox.Size = new System.Drawing.Size(350, 400);
            this.second_algorithm_pictureBox.TabIndex = 0;
            this.second_algorithm_pictureBox.TabStop = false;
            this.second_algorithm_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.second_algorithm_picture_box_Paint);
            // 
            // first_algorithm_pictureBox
            // 
            this.first_algorithm_pictureBox.BackColor = System.Drawing.Color.LightGray;
            this.first_algorithm_pictureBox.Location = new System.Drawing.Point(405, 152);
            this.first_algorithm_pictureBox.Name = "first_algorithm_pictureBox";
            this.first_algorithm_pictureBox.Size = new System.Drawing.Size(350, 400);
            this.first_algorithm_pictureBox.TabIndex = 1;
            this.first_algorithm_pictureBox.TabStop = false;
            this.first_algorithm_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.first_algorithm_picture_box_Paint);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(405, 724);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(165, 74);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // speed_trackBar
            // 
            this.speed_trackBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.speed_trackBar.Location = new System.Drawing.Point(10, 663);
            this.speed_trackBar.Maximum = 995;
            this.speed_trackBar.Minimum = 5;
            this.speed_trackBar.Name = "speed_trackBar";
            this.speed_trackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speed_trackBar.Size = new System.Drawing.Size(330, 69);
            this.speed_trackBar.TabIndex = 3;
            this.speed_trackBar.Value = 500;
            // 
            // pause_button
            // 
            this.pause_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pause_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_button.Location = new System.Drawing.Point(612, 724);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(165, 74);
            this.pause_button.TabIndex = 8;
            this.pause_button.Text = "PAUSE";
            this.pause_button.UseVisualStyleBackColor = false;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.Location = new System.Drawing.Point(811, 724);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(165, 74);
            this.play_button.TabIndex = 9;
            this.play_button.Text = "PLAY";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.OrangeRed;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_button.Location = new System.Drawing.Point(1023, 724);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(165, 74);
            this.stop_button.TabIndex = 10;
            this.stop_button.Text = "STOP";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.help_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 74);
            this.panel1.TabIndex = 11;
            // 
            // help_button
            // 
            this.help_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_button.ForeColor = System.Drawing.Color.Black;
            this.help_button.Location = new System.Drawing.Point(1143, 13);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(54, 50);
            this.help_button.TabIndex = 18;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 55);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sorting Algorithm Visualiser";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.number_of_elements_counter_label);
            this.panel2.Controls.Add(this.data_values_groupBox);
            this.panel2.Controls.Add(this.starting_order_groupBox);
            this.panel2.Controls.Add(this.speed_label);
            this.panel2.Controls.Add(this.number_of_elements_trackBar);
            this.panel2.Controls.Add(this.number_of_elements_label);
            this.panel2.Controls.Add(this.animation_preferences_label);
            this.panel2.Controls.Add(this.speed_trackBar);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 804);
            this.panel2.TabIndex = 6;
            // 
            // number_of_elements_counter_label
            // 
            this.number_of_elements_counter_label.AutoSize = true;
            this.number_of_elements_counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_elements_counter_label.ForeColor = System.Drawing.Color.MediumBlue;
            this.number_of_elements_counter_label.Location = new System.Drawing.Point(271, 78);
            this.number_of_elements_counter_label.Name = "number_of_elements_counter_label";
            this.number_of_elements_counter_label.Size = new System.Drawing.Size(39, 29);
            this.number_of_elements_counter_label.TabIndex = 23;
            this.number_of_elements_counter_label.Text = "12";
            // 
            // data_values_groupBox
            // 
            this.data_values_groupBox.Controls.Add(this.few_unique_radioButton);
            this.data_values_groupBox.Controls.Add(this.all_different_radioButton);
            this.data_values_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_values_groupBox.Location = new System.Drawing.Point(11, 394);
            this.data_values_groupBox.Name = "data_values_groupBox";
            this.data_values_groupBox.Size = new System.Drawing.Size(329, 164);
            this.data_values_groupBox.TabIndex = 2;
            this.data_values_groupBox.TabStop = false;
            this.data_values_groupBox.Text = "Data values :";
            // 
            // few_unique_radioButton
            // 
            this.few_unique_radioButton.AutoSize = true;
            this.few_unique_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.few_unique_radioButton.Location = new System.Drawing.Point(13, 70);
            this.few_unique_radioButton.Name = "few_unique_radioButton";
            this.few_unique_radioButton.Size = new System.Drawing.Size(138, 29);
            this.few_unique_radioButton.TabIndex = 1;
            this.few_unique_radioButton.Text = "Few unique";
            this.few_unique_radioButton.UseVisualStyleBackColor = true;
            // 
            // all_different_radioButton
            // 
            this.all_different_radioButton.AutoSize = true;
            this.all_different_radioButton.Checked = true;
            this.all_different_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_different_radioButton.Location = new System.Drawing.Point(13, 34);
            this.all_different_radioButton.Name = "all_different_radioButton";
            this.all_different_radioButton.Size = new System.Drawing.Size(133, 29);
            this.all_different_radioButton.TabIndex = 0;
            this.all_different_radioButton.TabStop = true;
            this.all_different_radioButton.Text = "All different";
            this.all_different_radioButton.UseVisualStyleBackColor = true;
            // 
            // starting_order_groupBox
            // 
            this.starting_order_groupBox.Controls.Add(this.reversed_radioButton);
            this.starting_order_groupBox.Controls.Add(this.partially_sorted_radioButton);
            this.starting_order_groupBox.Controls.Add(this.random_radioButton);
            this.starting_order_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starting_order_groupBox.Location = new System.Drawing.Point(11, 224);
            this.starting_order_groupBox.Name = "starting_order_groupBox";
            this.starting_order_groupBox.Size = new System.Drawing.Size(329, 164);
            this.starting_order_groupBox.TabIndex = 1;
            this.starting_order_groupBox.TabStop = false;
            this.starting_order_groupBox.Text = "Starting order : ";
            // 
            // reversed_radioButton
            // 
            this.reversed_radioButton.AutoSize = true;
            this.reversed_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversed_radioButton.Location = new System.Drawing.Point(13, 70);
            this.reversed_radioButton.Name = "reversed_radioButton";
            this.reversed_radioButton.Size = new System.Drawing.Size(120, 29);
            this.reversed_radioButton.TabIndex = 1;
            this.reversed_radioButton.Text = "Reversed";
            this.reversed_radioButton.UseVisualStyleBackColor = true;
            // 
            // partially_sorted_radioButton
            // 
            this.partially_sorted_radioButton.AutoSize = true;
            this.partially_sorted_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partially_sorted_radioButton.Location = new System.Drawing.Point(13, 106);
            this.partially_sorted_radioButton.Name = "partially_sorted_radioButton";
            this.partially_sorted_radioButton.Size = new System.Drawing.Size(164, 29);
            this.partially_sorted_radioButton.TabIndex = 2;
            this.partially_sorted_radioButton.Text = "Partially sorted";
            this.partially_sorted_radioButton.UseVisualStyleBackColor = true;
            // 
            // random_radioButton
            // 
            this.random_radioButton.AutoSize = true;
            this.random_radioButton.Checked = true;
            this.random_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_radioButton.Location = new System.Drawing.Point(13, 34);
            this.random_radioButton.Name = "random_radioButton";
            this.random_radioButton.Size = new System.Drawing.Size(110, 29);
            this.random_radioButton.TabIndex = 0;
            this.random_radioButton.TabStop = true;
            this.random_radioButton.Text = "Random";
            this.random_radioButton.UseVisualStyleBackColor = true;
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_label.Location = new System.Drawing.Point(19, 616);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(91, 29);
            this.speed_label.TabIndex = 22;
            this.speed_label.Text = "Speed:";
            // 
            // number_of_elements_trackBar
            // 
            this.number_of_elements_trackBar.Location = new System.Drawing.Point(23, 139);
            this.number_of_elements_trackBar.Maximum = 20;
            this.number_of_elements_trackBar.Minimum = 5;
            this.number_of_elements_trackBar.Name = "number_of_elements_trackBar";
            this.number_of_elements_trackBar.Size = new System.Drawing.Size(317, 69);
            this.number_of_elements_trackBar.TabIndex = 0;
            this.number_of_elements_trackBar.Value = 12;
            this.number_of_elements_trackBar.ValueChanged += new System.EventHandler(this.number_of_elements_trackBar_ValueChanged);
            // 
            // number_of_elements_label
            // 
            this.number_of_elements_label.AutoSize = true;
            this.number_of_elements_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_elements_label.Location = new System.Drawing.Point(19, 78);
            this.number_of_elements_label.Name = "number_of_elements_label";
            this.number_of_elements_label.Size = new System.Drawing.Size(237, 29);
            this.number_of_elements_label.TabIndex = 13;
            this.number_of_elements_label.Text = "Number of elements:";
            // 
            // animation_preferences_label
            // 
            this.animation_preferences_label.AutoSize = true;
            this.animation_preferences_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animation_preferences_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.animation_preferences_label.Location = new System.Drawing.Point(17, 15);
            this.animation_preferences_label.Name = "animation_preferences_label";
            this.animation_preferences_label.Size = new System.Drawing.Size(324, 32);
            this.animation_preferences_label.TabIndex = 4;
            this.animation_preferences_label.Text = "Animation Preferences";
            // 
            // algorithm1_comboBox
            // 
            this.algorithm1_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithm1_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm1_comboBox.FormattingEnabled = true;
            this.algorithm1_comboBox.Items.AddRange(new object[] {
            "Bubble Sort",
            "Insertion Sort",
            "Merge Sort",
            "Quick Sort",
            "Heap Sort"});
            this.algorithm1_comboBox.Location = new System.Drawing.Point(405, 106);
            this.algorithm1_comboBox.Name = "algorithm1_comboBox";
            this.algorithm1_comboBox.Size = new System.Drawing.Size(350, 37);
            this.algorithm1_comboBox.TabIndex = 4;
            // 
            // algorithm2_comboBox
            // 
            this.algorithm2_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Bubble Sort"});
            this.algorithm2_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithm2_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm2_comboBox.FormattingEnabled = true;
            this.algorithm2_comboBox.Items.AddRange(new object[] {
            "Bubble Sort",
            "Insertion Sort",
            "Merge Sort",
            "Quick Sort",
            "Heap Sort"});
            this.algorithm2_comboBox.Location = new System.Drawing.Point(838, 106);
            this.algorithm2_comboBox.Name = "algorithm2_comboBox";
            this.algorithm2_comboBox.Size = new System.Drawing.Size(350, 37);
            this.algorithm2_comboBox.TabIndex = 5;
            // 
            // algorithm1_num_comparisons_label
            // 
            this.algorithm1_num_comparisons_label.AutoSize = true;
            this.algorithm1_num_comparisons_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm1_num_comparisons_label.Location = new System.Drawing.Point(400, 586);
            this.algorithm1_num_comparisons_label.Name = "algorithm1_num_comparisons_label";
            this.algorithm1_num_comparisons_label.Size = new System.Drawing.Size(288, 29);
            this.algorithm1_num_comparisons_label.TabIndex = 15;
            this.algorithm1_num_comparisons_label.Text = "Number of comparisons : ";
            // 
            // algorithm1_num_swaps_label
            // 
            this.algorithm1_num_swaps_label.AutoSize = true;
            this.algorithm1_num_swaps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm1_num_swaps_label.Location = new System.Drawing.Point(400, 640);
            this.algorithm1_num_swaps_label.Name = "algorithm1_num_swaps_label";
            this.algorithm1_num_swaps_label.Size = new System.Drawing.Size(213, 29);
            this.algorithm1_num_swaps_label.TabIndex = 16;
            this.algorithm1_num_swaps_label.Text = "Number of swaps :";
            // 
            // algorithm2_num_comparisons_label
            // 
            this.algorithm2_num_comparisons_label.AutoSize = true;
            this.algorithm2_num_comparisons_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm2_num_comparisons_label.Location = new System.Drawing.Point(833, 587);
            this.algorithm2_num_comparisons_label.Name = "algorithm2_num_comparisons_label";
            this.algorithm2_num_comparisons_label.Size = new System.Drawing.Size(288, 29);
            this.algorithm2_num_comparisons_label.TabIndex = 17;
            this.algorithm2_num_comparisons_label.Text = "Number of comparisons : ";
            // 
            // algorithm2_num_swaps_label
            // 
            this.algorithm2_num_swaps_label.AutoSize = true;
            this.algorithm2_num_swaps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm2_num_swaps_label.Location = new System.Drawing.Point(833, 640);
            this.algorithm2_num_swaps_label.Name = "algorithm2_num_swaps_label";
            this.algorithm2_num_swaps_label.Size = new System.Drawing.Size(213, 29);
            this.algorithm2_num_swaps_label.TabIndex = 11;
            this.algorithm2_num_swaps_label.Text = "Number of swaps :";
            // 
            // SortingAlgorithmAnimationsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1234, 890);
            this.Controls.Add(this.algorithm2_num_swaps_label);
            this.Controls.Add(this.algorithm2_num_comparisons_label);
            this.Controls.Add(this.algorithm1_num_swaps_label);
            this.Controls.Add(this.algorithm1_num_comparisons_label);
            this.Controls.Add(this.algorithm2_comboBox);
            this.Controls.Add(this.algorithm1_comboBox);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.first_algorithm_pictureBox);
            this.Controls.Add(this.second_algorithm_pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1234, 890);
            this.Name = "SortingAlgorithmAnimationsUI";
            this.Text = "PrototypeUI";
            ((System.ComponentModel.ISupportInitialize)(this.second_algorithm_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_algorithm_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.data_values_groupBox.ResumeLayout(false);
            this.data_values_groupBox.PerformLayout();
            this.starting_order_groupBox.ResumeLayout(false);
            this.starting_order_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_elements_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox second_algorithm_pictureBox;
        private System.Windows.Forms.PictureBox first_algorithm_pictureBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TrackBar speed_trackBar;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label animation_preferences_label;
        private System.Windows.Forms.Label number_of_elements_label;
        private System.Windows.Forms.TrackBar number_of_elements_trackBar;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.ComboBox algorithm1_comboBox;
        private System.Windows.Forms.ComboBox algorithm2_comboBox;
        private System.Windows.Forms.Label algorithm1_num_comparisons_label;
        private System.Windows.Forms.Label algorithm1_num_swaps_label;
        private System.Windows.Forms.Label algorithm2_num_comparisons_label;
        private System.Windows.Forms.Label algorithm2_num_swaps_label;
        private System.Windows.Forms.GroupBox starting_order_groupBox;
        private System.Windows.Forms.RadioButton random_radioButton;
        private System.Windows.Forms.RadioButton reversed_radioButton;
        private System.Windows.Forms.RadioButton partially_sorted_radioButton;
        private System.Windows.Forms.GroupBox data_values_groupBox;
        private System.Windows.Forms.RadioButton few_unique_radioButton;
        private System.Windows.Forms.RadioButton all_different_radioButton;
        private System.Windows.Forms.Label number_of_elements_counter_label;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Label label1;
    }
}
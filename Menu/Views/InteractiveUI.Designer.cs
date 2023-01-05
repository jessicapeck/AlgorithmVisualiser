
namespace Prototype
{
    partial class InteractiveUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.end_test_button = new System.Windows.Forms.Button();
            this.question_label = new System.Windows.Forms.Label();
            this.bubble_sort_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(14, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 74);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 55);
            this.label1.TabIndex = 19;
            this.label1.Text = "Interactive Sorting Algorithms";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.bubble_sort_button);
            this.panel2.Controls.Add(this.end_test_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 804);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.MaximumSize = new System.Drawing.Size(340, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 96);
            this.label2.TabIndex = 15;
            this.label2.Text = "Which sorting algorithm would you like to be tested on?";
            // 
            // end_test_button
            // 
            this.end_test_button.BackColor = System.Drawing.Color.OrangeRed;
            this.end_test_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_test_button.Location = new System.Drawing.Point(62, 705);
            this.end_test_button.Name = "end_test_button";
            this.end_test_button.Size = new System.Drawing.Size(220, 74);
            this.end_test_button.TabIndex = 15;
            this.end_test_button.Text = "END TEST";
            this.end_test_button.UseVisualStyleBackColor = false;
            this.end_test_button.Click += new System.EventHandler(this.end_test_button_Click);
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label.Location = new System.Drawing.Point(593, 183);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(283, 32);
            this.question_label.TabIndex = 15;
            this.question_label.Text = "(insert question here)";
            // 
            // bubble_sort_button
            // 
            this.bubble_sort_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bubble_sort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubble_sort_button.Location = new System.Drawing.Point(19, 270);
            this.bubble_sort_button.Name = "bubble_sort_button";
            this.bubble_sort_button.Size = new System.Drawing.Size(313, 66);
            this.bubble_sort_button.TabIndex = 16;
            this.bubble_sort_button.Text = "Bubble Sort";
            this.bubble_sort_button.UseVisualStyleBackColor = false;
            this.bubble_sort_button.Click += new System.EventHandler(this.bubble_sort_button_Click);
            // 
            // InteractiveUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1234, 890);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InteractiveUI";
            this.Text = "InteractiveUI";
            this.Load += new System.EventHandler(this.InteractiveUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button end_test_button;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Button bubble_sort_button;
    }
}
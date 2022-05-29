
namespace Prototype.Views
{
    partial class PrototypeUI
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
            this.secondAlgorithmPictureBox = new System.Windows.Forms.PictureBox();
            this.firstAlgorithmPictureBox = new System.Windows.Forms.PictureBox();
            this.go_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.secondAlgorithmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAlgorithmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // secondAlgorithmPictureBox
            // 
            this.secondAlgorithmPictureBox.Location = new System.Drawing.Point(465, 12);
            this.secondAlgorithmPictureBox.Name = "secondAlgorithmPictureBox";
            this.secondAlgorithmPictureBox.Size = new System.Drawing.Size(427, 581);
            this.secondAlgorithmPictureBox.TabIndex = 0;
            this.secondAlgorithmPictureBox.TabStop = false;
            // 
            // firstAlgorithmPictureBox
            // 
            this.firstAlgorithmPictureBox.Location = new System.Drawing.Point(12, 12);
            this.firstAlgorithmPictureBox.Name = "firstAlgorithmPictureBox";
            this.firstAlgorithmPictureBox.Size = new System.Drawing.Size(427, 581);
            this.firstAlgorithmPictureBox.TabIndex = 1;
            this.firstAlgorithmPictureBox.TabStop = false;
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(248, 632);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(416, 121);
            this.go_button.TabIndex = 2;
            this.go_button.Text = "GO!";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // PrototypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 785);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.firstAlgorithmPictureBox);
            this.Controls.Add(this.secondAlgorithmPictureBox);
            this.Name = "PrototypeUI";
            this.Text = "PrototypeUI";
            ((System.ComponentModel.ISupportInitialize)(this.secondAlgorithmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAlgorithmPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox secondAlgorithmPictureBox;
        private System.Windows.Forms.PictureBox firstAlgorithmPictureBox;
        private System.Windows.Forms.Button go_button;
    }
}
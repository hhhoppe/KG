namespace WORK_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_rgb = new Button();
            button_hsv = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // button_rgb
            // 
            button_rgb.Location = new Point(12, 12);
            button_rgb.Name = "button_rgb";
            button_rgb.Size = new Size(211, 45);
            button_rgb.TabIndex = 0;
            button_rgb.Text = "RGB";
            button_rgb.UseVisualStyleBackColor = true;
            button_rgb.Click += button_rgb_Click;
            // 
            // button_hsv
            // 
            button_hsv.Location = new Point(577, 12);
            button_hsv.Name = "button_hsv";
            button_hsv.Size = new Size(211, 45);
            button_hsv.TabIndex = 1;
            button_hsv.Text = "HSV";
            button_hsv.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 63);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(776, 375);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(button_hsv);
            Controls.Add(button_rgb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_rgb;
        private Button button_hsv;
        private PictureBox pictureBox;
    }
}

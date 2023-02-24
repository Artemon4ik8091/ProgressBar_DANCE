namespace ProgressBar_DANCE_
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
            progressBar1 = new ProgressBar();
            progressBar5 = new ProgressBar();
            progressBar6 = new ProgressBar();
            progressBar7 = new ProgressBar();
            progressBar8 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 23);
            progressBar1.TabIndex = 0;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(12, 128);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(776, 23);
            progressBar5.TabIndex = 4;
            // 
            // progressBar6
            // 
            progressBar6.Location = new Point(12, 99);
            progressBar6.Name = "progressBar6";
            progressBar6.Size = new Size(776, 23);
            progressBar6.TabIndex = 5;
            // 
            // progressBar7
            // 
            progressBar7.Location = new Point(12, 70);
            progressBar7.Name = "progressBar7";
            progressBar7.Size = new Size(776, 23);
            progressBar7.TabIndex = 6;
            // 
            // progressBar8
            // 
            progressBar8.Location = new Point(12, 41);
            progressBar8.Name = "progressBar8";
            progressBar8.Size = new Size(776, 23);
            progressBar8.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 169);
            Controls.Add(progressBar8);
            Controls.Add(progressBar7);
            Controls.Add(progressBar6);
            Controls.Add(progressBar5);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar5;
        private ProgressBar progressBar6;
        private ProgressBar progressBar7;
        private ProgressBar progressBar8;
    }
}
namespace File_Organizer
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
            WelcomeLabel = new Label();
            ChooseDirBtn = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            PathLabel = new Label();
            StartBtn = new Button();
            CopyrightLabel = new Label();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(49, 65);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(489, 92);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome!\r\nThis program will help you organize\r\nyour files in a given folder, pls select the folder\r\ndown below:";
            WelcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseDirBtn
            // 
            ChooseDirBtn.BackColor = Color.Cyan;
            ChooseDirBtn.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic);
            ChooseDirBtn.Location = new Point(167, 183);
            ChooseDirBtn.Name = "ChooseDirBtn";
            ChooseDirBtn.Size = new Size(276, 34);
            ChooseDirBtn.TabIndex = 1;
            ChooseDirBtn.Text = "Choose the directory";
            ChooseDirBtn.UseVisualStyleBackColor = false;
            ChooseDirBtn.Click += ChooseDirBtn_Click;
            // 
            // PathLabel
            // 
            PathLabel.AutoSize = true;
            PathLabel.Font = new Font("Segoe UI Historic", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PathLabel.Location = new Point(49, 243);
            PathLabel.MaximumSize = new Size(500, 0);
            PathLabel.Name = "PathLabel";
            PathLabel.Size = new Size(125, 28);
            PathLabel.TabIndex = 2;
            PathLabel.Text = "Current Path:";
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.FromArgb(128, 255, 255);
            StartBtn.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StartBtn.Location = new Point(412, 382);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(112, 34);
            StartBtn.TabIndex = 3;
            StartBtn.Text = "START";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // CopyrightLabel
            // 
            CopyrightLabel.AutoSize = true;
            CopyrightLabel.Font = new Font("Showcard Gothic", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CopyrightLabel.ForeColor = SystemColors.ActiveCaption;
            CopyrightLabel.Location = new Point(31, 396);
            CopyrightLabel.Name = "CopyrightLabel";
            CopyrightLabel.Size = new Size(159, 20);
            CopyrightLabel.TabIndex = 4;
            CopyrightLabel.Text = "Made by Vladd_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(595, 468);
            Controls.Add(CopyrightLabel);
            Controls.Add(StartBtn);
            Controls.Add(PathLabel);
            Controls.Add(ChooseDirBtn);
            Controls.Add(WelcomeLabel);
            Name = "Form1";
            Text = "File Organizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Button ChooseDirBtn;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label PathLabel;
        private Button StartBtn;
        private Label CopyrightLabel;
    }
}

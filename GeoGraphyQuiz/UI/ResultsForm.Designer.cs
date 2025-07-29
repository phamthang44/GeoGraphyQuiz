namespace GeoGraphyQuiz.UI
{
    partial class ResultsForm
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
            listBoxAnswers = new ListBox();
            exitBtn = new Button();
            labelScore = new Label();
            labelTimeUsed = new Label();
            SuspendLayout();
            // 
            // listBoxAnswers
            // 
            listBoxAnswers.FormattingEnabled = true;
            listBoxAnswers.ItemHeight = 25;
            listBoxAnswers.Location = new Point(191, 45);
            listBoxAnswers.Name = "listBoxAnswers";
            listBoxAnswers.Size = new Size(812, 579);
            listBoxAnswers.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Red;
            exitBtn.Font = new Font("Segoe UI", 11F);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(191, 681);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(147, 48);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(539, 642);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(93, 25);
            labelScore.TabIndex = 2;
            labelScore.Text = "labelScore";
            // 
            // labelTimeUsed
            // 
            labelTimeUsed.AutoSize = true;
            labelTimeUsed.Location = new Point(1037, 113);
            labelTimeUsed.Name = "labelTimeUsed";
            labelTimeUsed.Size = new Size(59, 25);
            labelTimeUsed.TabIndex = 3;
            labelTimeUsed.Text = "label1";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 776);
            Controls.Add(labelTimeUsed);
            Controls.Add(labelScore);
            Controls.Add(exitBtn);
            Controls.Add(listBoxAnswers);
            Name = "ResultsForm";
            Text = "ResultsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAnswers;
        private Button exitBtn;
        private Label labelScore;
        private Label labelTimeUsed;
    }
}
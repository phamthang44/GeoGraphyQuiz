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
            exitBtn = new Button();
            labelScore = new Label();
            labelTimeUsed = new Label();
            showCorrectAnswerBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
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
            // showCorrectAnswerBtn
            // 
            showCorrectAnswerBtn.Location = new Point(820, 642);
            showCorrectAnswerBtn.Name = "showCorrectAnswerBtn";
            showCorrectAnswerBtn.Size = new Size(183, 87);
            showCorrectAnswerBtn.TabIndex = 4;
            showCorrectAnswerBtn.Text = "Show correct answers";
            showCorrectAnswerBtn.UseVisualStyleBackColor = true;
            showCorrectAnswerBtn.Click += showCorrectAnswerBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(109, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(922, 56);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 776);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(showCorrectAnswerBtn);
            Controls.Add(labelTimeUsed);
            Controls.Add(labelScore);
            Controls.Add(exitBtn);
            Name = "ResultsForm";
            Text = "ResultsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitBtn;
        private Label labelScore;
        private Label labelTimeUsed;
        private Button showCorrectAnswerBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
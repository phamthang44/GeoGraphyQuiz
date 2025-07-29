namespace GeoGraphyQuiz.UI
{
    partial class PlayGameForm
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
            parenPanel = new Panel();
            mainPanelAnswer = new Panel();
            numberOfQuestion = new Label();
            QuestionTextLabel = new Label();
            listBoxQuestion = new ListBox();
            nextBtn = new Button();
            button3 = new Button();
            exitAndBackToHome = new Button();
            parenPanel.SuspendLayout();
            SuspendLayout();
            // 
            // parenPanel
            // 
            parenPanel.Controls.Add(mainPanelAnswer);
            parenPanel.Controls.Add(numberOfQuestion);
            parenPanel.Controls.Add(QuestionTextLabel);
            parenPanel.Location = new Point(281, 29);
            parenPanel.Name = "parenPanel";
            parenPanel.Size = new Size(844, 581);
            parenPanel.TabIndex = 0;
            // 
            // mainPanelAnswer
            // 
            mainPanelAnswer.Location = new Point(38, 69);
            mainPanelAnswer.Name = "mainPanelAnswer";
            mainPanelAnswer.Size = new Size(780, 491);
            mainPanelAnswer.TabIndex = 3;
            // 
            // numberOfQuestion
            // 
            numberOfQuestion.AutoSize = true;
            numberOfQuestion.Font = new Font("Segoe UI", 15F);
            numberOfQuestion.Location = new Point(435, 9);
            numberOfQuestion.Name = "numberOfQuestion";
            numberOfQuestion.Size = new Size(78, 41);
            numberOfQuestion.TabIndex = 2;
            numberOfQuestion.Text = "1/10";
            // 
            // QuestionTextLabel
            // 
            QuestionTextLabel.AutoSize = true;
            QuestionTextLabel.Location = new Point(38, 25);
            QuestionTextLabel.Name = "QuestionTextLabel";
            QuestionTextLabel.Size = new Size(126, 25);
            QuestionTextLabel.TabIndex = 1;
            QuestionTextLabel.Text = "Question title?";
            QuestionTextLabel.Click += QuestionTextLabel_Click;
            // 
            // listBoxQuestion
            // 
            listBoxQuestion.Font = new Font("Segoe UI", 11F);
            listBoxQuestion.FormattingEnabled = true;
            listBoxQuestion.ItemHeight = 30;
            listBoxQuestion.Location = new Point(12, 29);
            listBoxQuestion.Name = "listBoxQuestion";
            listBoxQuestion.Size = new Size(243, 574);
            listBoxQuestion.TabIndex = 1;
            listBoxQuestion.SelectedIndexChanged += listBoxQuestion_SelectedIndexChanged;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(1176, 29);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(140, 50);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next Question";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1176, 576);
            button3.Name = "button3";
            button3.Size = new Size(140, 55);
            button3.TabIndex = 4;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // exitAndBackToHome
            // 
            exitAndBackToHome.Font = new Font("Segoe UI", 14F);
            exitAndBackToHome.Location = new Point(13, 642);
            exitAndBackToHome.Name = "exitAndBackToHome";
            exitAndBackToHome.Size = new Size(112, 53);
            exitAndBackToHome.TabIndex = 5;
            exitAndBackToHome.Text = "Exit";
            exitAndBackToHome.UseVisualStyleBackColor = true;
            exitAndBackToHome.Click += exitAndBackToHome_Click;
            // 
            // PlayGameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 707);
            Controls.Add(exitAndBackToHome);
            Controls.Add(button3);
            Controls.Add(nextBtn);
            Controls.Add(listBoxQuestion);
            Controls.Add(parenPanel);
            Name = "PlayGameForm";
            Text = "PlayGameForm";
            parenPanel.ResumeLayout(false);
            parenPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel parenPanel;
        private Label numberOfQuestion;
        private Label QuestionTextLabel;
        private ListBox listBoxQuestion;
        private Button nextBtn;
        private Button button3;
        private Button exitAndBackToHome;
        private Panel mainPanelAnswer;
    }
}
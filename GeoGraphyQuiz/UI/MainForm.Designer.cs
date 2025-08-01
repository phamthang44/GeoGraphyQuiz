namespace GeoGraphyQuiz.UI
{
    partial class MainForm
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
            CreateQuestionBtn = new Button();
            PlayGameBtn = new Button();
            GameHeading = new Label();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // CreateQuestionBtn
            // 
            CreateQuestionBtn.Font = new Font("Segoe UI", 14F);
            CreateQuestionBtn.Location = new Point(563, 335);
            CreateQuestionBtn.Name = "CreateQuestionBtn";
            CreateQuestionBtn.Size = new Size(233, 65);
            CreateQuestionBtn.TabIndex = 0;
            CreateQuestionBtn.Text = "Create Question";
            CreateQuestionBtn.UseVisualStyleBackColor = true;
            CreateQuestionBtn.Click += CreateQuestionBtn_Click;
            // 
            // PlayGameBtn
            // 
            PlayGameBtn.Font = new Font("Segoe UI", 14F);
            PlayGameBtn.Location = new Point(563, 434);
            PlayGameBtn.Name = "PlayGameBtn";
            PlayGameBtn.Size = new Size(233, 65);
            PlayGameBtn.TabIndex = 1;
            PlayGameBtn.Text = "Play Game";
            PlayGameBtn.UseVisualStyleBackColor = true;
            PlayGameBtn.Click += PlayGameBtn_Click_1;
            // 
            // GameHeading
            // 
            GameHeading.AutoSize = true;
            GameHeading.Font = new Font("Segoe UI", 24F);
            GameHeading.ForeColor = Color.Teal;
            GameHeading.Location = new Point(301, 193);
            GameHeading.Name = "GameHeading";
            GameHeading.Size = new Size(773, 65);
            GameHeading.TabIndex = 2;
            GameHeading.Text = "Welcome to Geography Quiz Game";
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 15F);
            exitBtn.Location = new Point(563, 527);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(233, 57);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 837);
            Controls.Add(exitBtn);
            Controls.Add(GameHeading);
            Controls.Add(PlayGameBtn);
            Controls.Add(CreateQuestionBtn);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateQuestionBtn;
        private Button PlayGameBtn;
        private Label GameHeading;
        private Button exitBtn;
    }
}
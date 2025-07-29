namespace GeoGraphyQuiz.UI.PlayGameControls
{
    partial class OpenEndPlayGameControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputAnswerText = new TextBox();
            saveAnsBtn = new Button();
            SuspendLayout();
            // 
            // inputAnswerText
            // 
            inputAnswerText.Font = new Font("Segoe UI", 15F);
            inputAnswerText.Location = new Point(113, 176);
            inputAnswerText.Name = "inputAnswerText";
            inputAnswerText.Size = new Size(516, 47);
            inputAnswerText.TabIndex = 0;
            // 
            // saveAnsBtn
            // 
            saveAnsBtn.Location = new Point(113, 261);
            saveAnsBtn.Name = "saveAnsBtn";
            saveAnsBtn.Size = new Size(112, 34);
            saveAnsBtn.TabIndex = 1;
            saveAnsBtn.Text = "Save";
            saveAnsBtn.UseVisualStyleBackColor = true;
            saveAnsBtn.Click += saveAnsBtn_Click;
            // 
            // OpenEndPlayGameControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(saveAnsBtn);
            Controls.Add(inputAnswerText);
            Name = "OpenEndPlayGameControl";
            Size = new Size(780, 491);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputAnswerText;
        private Button saveAnsBtn;
    }
}

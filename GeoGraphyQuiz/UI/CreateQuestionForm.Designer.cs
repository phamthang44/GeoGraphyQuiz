using GeoGraphyQuiz.Model;

namespace GeoGraphyQuiz.UI
{
    partial class CreateQuestionForm
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
            parentPanel = new Panel();
            SuspendLayout();
            // 
            // parentPanel
            // 
            parentPanel.Location = new Point(3, 5);
            parentPanel.Name = "parentPanel";
            parentPanel.Size = new Size(1726, 839);
            parentPanel.TabIndex = 0;
            // 
            // CreateQuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1727, 843);
            Controls.Add(parentPanel);
            Name = "CreateQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateQuestionForm";
            Load += CreateQuestionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel parentPanel;
    }
}
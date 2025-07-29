namespace GeoGraphyQuiz.UI.PlayGameControls
{
    partial class MultipleChoicePlayGameControl
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
            radioButtonAOpt = new RadioButton();
            radioButtonBOpt = new RadioButton();
            radioButtonCOpt = new RadioButton();
            radioButtonDOpt = new RadioButton();
            SuspendLayout();
            // 
            // radioButtonAOpt
            // 
            radioButtonAOpt.AutoSize = true;
            radioButtonAOpt.Font = new Font("Segoe UI", 15F);
            radioButtonAOpt.Location = new Point(58, 81);
            radioButtonAOpt.Name = "radioButtonAOpt";
            radioButtonAOpt.Size = new Size(69, 45);
            radioButtonAOpt.TabIndex = 1;
            radioButtonAOpt.TabStop = true;
            radioButtonAOpt.Text = "A.";
            radioButtonAOpt.UseVisualStyleBackColor = true;
            // 
            // radioButtonBOpt
            // 
            radioButtonBOpt.AutoSize = true;
            radioButtonBOpt.Font = new Font("Segoe UI", 15F);
            radioButtonBOpt.Location = new Point(58, 173);
            radioButtonBOpt.Name = "radioButtonBOpt";
            radioButtonBOpt.Size = new Size(67, 45);
            radioButtonBOpt.TabIndex = 2;
            radioButtonBOpt.TabStop = true;
            radioButtonBOpt.Text = "B.";
            radioButtonBOpt.UseVisualStyleBackColor = true;
            // 
            // radioButtonCOpt
            // 
            radioButtonCOpt.AutoSize = true;
            radioButtonCOpt.Font = new Font("Segoe UI", 15F);
            radioButtonCOpt.Location = new Point(58, 264);
            radioButtonCOpt.Name = "radioButtonCOpt";
            radioButtonCOpt.Size = new Size(69, 45);
            radioButtonCOpt.TabIndex = 3;
            radioButtonCOpt.TabStop = true;
            radioButtonCOpt.Text = "C.";
            radioButtonCOpt.UseVisualStyleBackColor = true;
            // 
            // radioButtonDOpt
            // 
            radioButtonDOpt.AutoSize = true;
            radioButtonDOpt.Font = new Font("Segoe UI", 15F);
            radioButtonDOpt.Location = new Point(58, 349);
            radioButtonDOpt.Name = "radioButtonDOpt";
            radioButtonDOpt.Size = new Size(71, 45);
            radioButtonDOpt.TabIndex = 4;
            radioButtonDOpt.TabStop = true;
            radioButtonDOpt.Text = "D.";
            radioButtonDOpt.UseVisualStyleBackColor = true;
            // 
            // MultipleChoicePlayGameControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioButtonDOpt);
            Controls.Add(radioButtonCOpt);
            Controls.Add(radioButtonBOpt);
            Controls.Add(radioButtonAOpt);
            Name = "MultipleChoicePlayGameControl";
            Size = new Size(780, 491);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButtonAOpt;
        private RadioButton radioButtonBOpt;
        private RadioButton radioButtonCOpt;
        private RadioButton radioButtonDOpt;
    }
}

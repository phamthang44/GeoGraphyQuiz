namespace GeoGraphyQuiz.UI.PlayGameControls
{
    partial class TrueFalsePlayGameControl
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
            radioButtonTrue = new RadioButton();
            radioButtonFalse = new RadioButton();
            SuspendLayout();
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Font = new Font("Segoe UI", 15F);
            radioButtonTrue.Location = new Point(59, 69);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new Size(99, 45);
            radioButtonTrue.TabIndex = 0;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "True";
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Font = new Font("Segoe UI", 15F);
            radioButtonFalse.Location = new Point(59, 167);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new Size(108, 45);
            radioButtonFalse.TabIndex = 1;
            radioButtonFalse.TabStop = true;
            radioButtonFalse.Text = "False";
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // TrueFalsePlayGameControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioButtonFalse);
            Controls.Add(radioButtonTrue);
            Name = "TrueFalsePlayGameControl";
            Size = new Size(780, 491);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonTrue;
        private RadioButton radioButtonFalse;
    }
}

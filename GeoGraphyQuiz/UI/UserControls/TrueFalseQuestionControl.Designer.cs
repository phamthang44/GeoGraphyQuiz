namespace GeoGraphyQuiz.UI.UserControls
{
    partial class TrueFalseQuestionControl
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
            groupBoxTrueFalseQuestion = new GroupBox();
            comboBoxUpdateCreateMode = new ComboBox();
            backToPreviousPageBtn = new Button();
            saveTFQuestion = new Button();
            radioButtonFalse = new RadioButton();
            radioButtonTrue = new RadioButton();
            listTFQuestions = new ListBox();
            inputTFQuestionText = new TextBox();
            lblQuestionText = new Label();
            groupBoxTrueFalseQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTrueFalseQuestion
            // 
            groupBoxTrueFalseQuestion.Controls.Add(comboBoxUpdateCreateMode);
            groupBoxTrueFalseQuestion.Controls.Add(backToPreviousPageBtn);
            groupBoxTrueFalseQuestion.Controls.Add(saveTFQuestion);
            groupBoxTrueFalseQuestion.Controls.Add(radioButtonFalse);
            groupBoxTrueFalseQuestion.Controls.Add(radioButtonTrue);
            groupBoxTrueFalseQuestion.Controls.Add(listTFQuestions);
            groupBoxTrueFalseQuestion.Controls.Add(inputTFQuestionText);
            groupBoxTrueFalseQuestion.Controls.Add(lblQuestionText);
            groupBoxTrueFalseQuestion.Location = new Point(0, 0);
            groupBoxTrueFalseQuestion.Name = "groupBoxTrueFalseQuestion";
            groupBoxTrueFalseQuestion.Size = new Size(1738, 834);
            groupBoxTrueFalseQuestion.TabIndex = 0;
            groupBoxTrueFalseQuestion.TabStop = false;
            groupBoxTrueFalseQuestion.Text = "True / False Question";
            // 
            // comboBoxUpdateCreateMode
            // 
            comboBoxUpdateCreateMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdateCreateMode.FormattingEnabled = true;
            comboBoxUpdateCreateMode.Items.AddRange(new object[] { "Update Mode", "Create Mode" });
            comboBoxUpdateCreateMode.Location = new Point(635, 361);
            comboBoxUpdateCreateMode.Name = "comboBoxUpdateCreateMode";
            comboBoxUpdateCreateMode.Size = new Size(182, 33);
            comboBoxUpdateCreateMode.TabIndex = 7;
            comboBoxUpdateCreateMode.SelectedIndexChanged += comboBoxUpdateCreateMode_SelectedIndexChanged;
            // 
            // backToPreviousPageBtn
            // 
            backToPreviousPageBtn.BackColor = Color.Red;
            backToPreviousPageBtn.Font = new Font("Segoe UI", 12F);
            backToPreviousPageBtn.ForeColor = Color.White;
            backToPreviousPageBtn.Location = new Point(54, 733);
            backToPreviousPageBtn.Name = "backToPreviousPageBtn";
            backToPreviousPageBtn.Size = new Size(126, 64);
            backToPreviousPageBtn.TabIndex = 6;
            backToPreviousPageBtn.Text = "Exit";
            backToPreviousPageBtn.UseVisualStyleBackColor = false;
            backToPreviousPageBtn.Click += backToPreviousPageBtn_Click;
            // 
            // saveTFQuestion
            // 
            saveTFQuestion.Location = new Point(225, 347);
            saveTFQuestion.Name = "saveTFQuestion";
            saveTFQuestion.Size = new Size(142, 59);
            saveTFQuestion.TabIndex = 5;
            saveTFQuestion.Text = "Save";
            saveTFQuestion.UseVisualStyleBackColor = true;
            saveTFQuestion.Click += saveTFQuestion_Click;
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Location = new Point(236, 264);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new Size(75, 29);
            radioButtonFalse.TabIndex = 4;
            radioButtonFalse.TabStop = true;
            radioButtonFalse.Text = "False";
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Location = new Point(236, 212);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new Size(69, 29);
            radioButtonTrue.TabIndex = 3;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "True";
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // listTFQuestions
            // 
            listTFQuestions.FormattingEnabled = true;
            listTFQuestions.ItemHeight = 25;
            listTFQuestions.Location = new Point(1273, 77);
            listTFQuestions.Name = "listTFQuestions";
            listTFQuestions.Size = new Size(422, 629);
            listTFQuestions.TabIndex = 2;
            listTFQuestions.SelectedIndexChanged += listTFQuestions_SelectedIndexChanged;
            // 
            // inputTFQuestionText
            // 
            inputTFQuestionText.Font = new Font("Segoe UI", 15F);
            inputTFQuestionText.Location = new Point(225, 124);
            inputTFQuestionText.Name = "inputTFQuestionText";
            inputTFQuestionText.Size = new Size(592, 47);
            inputTFQuestionText.TabIndex = 1;
            // 
            // lblQuestionText
            // 
            lblQuestionText.AutoSize = true;
            lblQuestionText.Font = new Font("Segoe UI", 14F);
            lblQuestionText.Location = new Point(225, 69);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(266, 38);
            lblQuestionText.TabIndex = 0;
            lblQuestionText.Text = "Input your question:";
            // 
            // TrueFalseQuestionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxTrueFalseQuestion);
            Name = "TrueFalseQuestionControl";
            Size = new Size(1738, 834);
            groupBoxTrueFalseQuestion.ResumeLayout(false);
            groupBoxTrueFalseQuestion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTrueFalseQuestion;
        private Button saveTFQuestion;
        private RadioButton radioButtonFalse;
        private RadioButton radioButtonTrue;
        private ListBox listTFQuestions;
        private TextBox inputTFQuestionText;
        private Label lblQuestionText;
        private Button backToPreviousPageBtn;
        private ComboBox comboBoxUpdateCreateMode;
    }
}

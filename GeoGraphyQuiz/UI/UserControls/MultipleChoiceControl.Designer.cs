namespace GeoGraphyQuiz.UI.UserControls
{
    partial class MultipleChoiceControl
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
            questionControl = new TabControl();
            multipleChoiceTab = new TabPage();
            comboBoxCreateUpdateMode = new ComboBox();
            button1 = new Button();
            indexOfQuestion = new Label();
            previousQuestionBtn = new Button();
            nextQuestionBtn = new Button();
            listMCQuestions = new ListBox();
            radioButtonD = new RadioButton();
            radioButtonC = new RadioButton();
            radioButtonB = new RadioButton();
            radioButtonA = new RadioButton();
            saveMCquestionBtn = new Button();
            optionDInput = new TextBox();
            optionCInput = new TextBox();
            optionBInput = new TextBox();
            optionAInput = new TextBox();
            correctAnswerLabel = new Label();
            questionTextLabel = new Label();
            inputQuestionText = new TextBox();
            questionControl.SuspendLayout();
            multipleChoiceTab.SuspendLayout();
            SuspendLayout();
            // 
            // questionControl
            // 
            questionControl.Controls.Add(multipleChoiceTab);
            questionControl.Location = new Point(19, 26);
            questionControl.Name = "questionControl";
            questionControl.SelectedIndex = 0;
            questionControl.Size = new Size(1694, 782);
            questionControl.TabIndex = 1;
            // 
            // multipleChoiceTab
            // 
            multipleChoiceTab.Controls.Add(comboBoxCreateUpdateMode);
            multipleChoiceTab.Controls.Add(button1);
            multipleChoiceTab.Controls.Add(indexOfQuestion);
            multipleChoiceTab.Controls.Add(previousQuestionBtn);
            multipleChoiceTab.Controls.Add(nextQuestionBtn);
            multipleChoiceTab.Controls.Add(listMCQuestions);
            multipleChoiceTab.Controls.Add(radioButtonD);
            multipleChoiceTab.Controls.Add(radioButtonC);
            multipleChoiceTab.Controls.Add(radioButtonB);
            multipleChoiceTab.Controls.Add(radioButtonA);
            multipleChoiceTab.Controls.Add(saveMCquestionBtn);
            multipleChoiceTab.Controls.Add(optionDInput);
            multipleChoiceTab.Controls.Add(optionCInput);
            multipleChoiceTab.Controls.Add(optionBInput);
            multipleChoiceTab.Controls.Add(optionAInput);
            multipleChoiceTab.Controls.Add(correctAnswerLabel);
            multipleChoiceTab.Controls.Add(questionTextLabel);
            multipleChoiceTab.Controls.Add(inputQuestionText);
            multipleChoiceTab.Location = new Point(4, 34);
            multipleChoiceTab.Name = "multipleChoiceTab";
            multipleChoiceTab.Padding = new Padding(3);
            multipleChoiceTab.Size = new Size(1686, 744);
            multipleChoiceTab.TabIndex = 1;
            multipleChoiceTab.Text = "Multiple Question";
            multipleChoiceTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxCreateUpdateMode
            // 
            comboBoxCreateUpdateMode.FormattingEnabled = true;
            comboBoxCreateUpdateMode.Items.AddRange(new object[] { "Create question mode", "Update question mode" });
            comboBoxCreateUpdateMode.Location = new Point(587, 415);
            comboBoxCreateUpdateMode.Name = "comboBoxCreateUpdateMode";
            comboBoxCreateUpdateMode.Size = new Size(221, 33);
            comboBoxCreateUpdateMode.TabIndex = 23;
            comboBoxCreateUpdateMode.Text = "Create question mode";
            comboBoxCreateUpdateMode.SelectedIndexChanged += comboBoxCreateUpdateMode_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(40, 654);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 22;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // indexOfQuestion
            // 
            indexOfQuestion.AutoSize = true;
            indexOfQuestion.BorderStyle = BorderStyle.FixedSingle;
            indexOfQuestion.Font = new Font("Segoe UI", 14F);
            indexOfQuestion.Location = new Point(1295, 374);
            indexOfQuestion.Name = "indexOfQuestion";
            indexOfQuestion.Size = new Size(34, 40);
            indexOfQuestion.TabIndex = 21;
            indexOfQuestion.Text = "1";
            // 
            // previousQuestionBtn
            // 
            previousQuestionBtn.Location = new Point(1144, 377);
            previousQuestionBtn.Name = "previousQuestionBtn";
            previousQuestionBtn.Size = new Size(112, 34);
            previousQuestionBtn.TabIndex = 20;
            previousQuestionBtn.Text = "Previous";
            previousQuestionBtn.UseVisualStyleBackColor = true;
            previousQuestionBtn.Click += previousQuestionBtn_Click;
            // 
            // nextQuestionBtn
            // 
            nextQuestionBtn.Location = new Point(1360, 377);
            nextQuestionBtn.Name = "nextQuestionBtn";
            nextQuestionBtn.Size = new Size(112, 34);
            nextQuestionBtn.TabIndex = 19;
            nextQuestionBtn.Text = "Next";
            nextQuestionBtn.UseVisualStyleBackColor = true;
            nextQuestionBtn.Click += nextQuestionBtn_Click;
            // 
            // listMCQuestions
            // 
            listMCQuestions.Font = new Font("Segoe UI", 12F);
            listMCQuestions.FormattingEnabled = true;
            listMCQuestions.ItemHeight = 32;
            listMCQuestions.Location = new Point(988, 47);
            listMCQuestions.Name = "listMCQuestions";
            listMCQuestions.Size = new Size(657, 324);
            listMCQuestions.TabIndex = 17;
            listMCQuestions.SelectedIndexChanged += listMCQuestions_SelectedIndexChanged;
            // 
            // radioButtonD
            // 
            radioButtonD.AutoSize = true;
            radioButtonD.Location = new Point(218, 335);
            radioButtonD.Name = "radioButtonD";
            radioButtonD.Size = new Size(54, 29);
            radioButtonD.TabIndex = 16;
            radioButtonD.TabStop = true;
            radioButtonD.Text = "D.";
            radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            radioButtonC.AutoSize = true;
            radioButtonC.Location = new Point(218, 281);
            radioButtonC.Name = "radioButtonC";
            radioButtonC.Size = new Size(52, 29);
            radioButtonC.TabIndex = 15;
            radioButtonC.TabStop = true;
            radioButtonC.Text = "C.";
            radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            radioButtonB.AutoSize = true;
            radioButtonB.Location = new Point(218, 224);
            radioButtonB.Name = "radioButtonB";
            radioButtonB.Size = new Size(51, 29);
            radioButtonB.TabIndex = 14;
            radioButtonB.TabStop = true;
            radioButtonB.Text = "B.";
            radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            radioButtonA.AutoSize = true;
            radioButtonA.Location = new Point(218, 165);
            radioButtonA.Name = "radioButtonA";
            radioButtonA.Size = new Size(53, 29);
            radioButtonA.TabIndex = 13;
            radioButtonA.TabStop = true;
            radioButtonA.Text = "A.";
            radioButtonA.UseVisualStyleBackColor = true;
            // 
            // saveMCquestionBtn
            // 
            saveMCquestionBtn.Location = new Point(213, 402);
            saveMCquestionBtn.Name = "saveMCquestionBtn";
            saveMCquestionBtn.Size = new Size(177, 57);
            saveMCquestionBtn.TabIndex = 11;
            saveMCquestionBtn.Text = "Save";
            saveMCquestionBtn.UseVisualStyleBackColor = true;
            saveMCquestionBtn.Click += saveMCquestionBtn_Click;
            // 
            // optionDInput
            // 
            optionDInput.Location = new Point(285, 330);
            optionDInput.Name = "optionDInput";
            optionDInput.Size = new Size(624, 31);
            optionDInput.TabIndex = 10;
            // 
            // optionCInput
            // 
            optionCInput.Location = new Point(285, 276);
            optionCInput.Name = "optionCInput";
            optionCInput.Size = new Size(624, 31);
            optionCInput.TabIndex = 9;
            // 
            // optionBInput
            // 
            optionBInput.Location = new Point(285, 219);
            optionBInput.Name = "optionBInput";
            optionBInput.Size = new Size(624, 31);
            optionBInput.TabIndex = 8;
            // 
            // optionAInput
            // 
            optionAInput.Location = new Point(285, 162);
            optionAInput.Name = "optionAInput";
            optionAInput.Size = new Size(623, 31);
            optionAInput.TabIndex = 7;
            // 
            // correctAnswerLabel
            // 
            correctAnswerLabel.AutoSize = true;
            correctAnswerLabel.Location = new Point(218, 131);
            correctAnswerLabel.Name = "correctAnswerLabel";
            correctAnswerLabel.Size = new Size(172, 25);
            correctAnswerLabel.TabIndex = 2;
            correctAnswerLabel.Text = "Your Correct Answer";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI", 12F);
            questionTextLabel.Location = new Point(221, 16);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(230, 32);
            questionTextLabel.TabIndex = 1;
            questionTextLabel.Text = "Input your question:";
            // 
            // inputQuestionText
            // 
            inputQuestionText.Font = new Font("Segoe UI", 13F);
            inputQuestionText.Location = new Point(218, 52);
            inputQuestionText.Name = "inputQuestionText";
            inputQuestionText.Size = new Size(697, 42);
            inputQuestionText.TabIndex = 0;
            inputQuestionText.TextChanged += inputQuestionText_TextChanged;
            // 
            // MultipleChoiceControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(questionControl);
            Name = "MultipleChoiceControl";
            Size = new Size(1738, 834);
            Load += MultipleChoiceControl_Load;
            questionControl.ResumeLayout(false);
            multipleChoiceTab.ResumeLayout(false);
            multipleChoiceTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl questionControl;
        private TabPage multipleChoiceTab;
        private Label indexOfQuestion;
        private Button previousQuestionBtn;
        private Button nextQuestionBtn;
        private ListBox listMCQuestions;
        private RadioButton radioButtonD;
        private RadioButton radioButtonC;
        private RadioButton radioButtonB;
        private RadioButton radioButtonA;
        private Button saveMCquestionBtn;
        private TextBox optionDInput;
        private TextBox optionCInput;
        private TextBox optionBInput;
        private TextBox optionAInput;
        private Label correctAnswerLabel;
        private Label questionTextLabel;
        private TextBox inputQuestionText;
        private Button button1;
        private ComboBox comboBoxCreateUpdateMode;
    }
}

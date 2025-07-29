namespace GeoGraphyQuiz.UI.UserControls
{
    partial class MainMenuCreateQuestionControl
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
            button1 = new Button();
            listQuestions = new ListBox();
            listQuestionLabel = new Label();
            tabAnswerControl = new TabControl();
            tabPageMCAnswers = new TabPage();
            deleteMCQuestionBtn = new Button();
            editMCQuestionBtn = new Button();
            labelMCQuestionText = new Label();
            lblAnswerD = new Label();
            lblAnswerC = new Label();
            lblAnswerB = new Label();
            lblAnswerA = new Label();
            radioButtonD = new RadioButton();
            radioButtonC = new RadioButton();
            radioButtonB = new RadioButton();
            radioButtonA = new RadioButton();
            tabPageTFAnswers = new TabPage();
            labelAnswerFalse = new Label();
            labelAnswerTrue = new Label();
            deleteTFQuestion = new Button();
            editTFQuestion = new Button();
            labelTrueFalseQuestionText = new Label();
            radioButtonFalse = new RadioButton();
            radioButtonTrue = new RadioButton();
            tabPageOEAnswers = new TabPage();
            deleteOpenQuestion = new Button();
            editOpenQuestion = new Button();
            labelOpenQuestionText = new Label();
            listBoxOpenAns = new ListBox();
            nextBtnQuestion = new Button();
            previousBtnQuestion = new Button();
            labelIndexOfQuestion = new Label();
            groupBoxCreateQuestion = new GroupBox();
            createQuestionBtn = new Button();
            comboBoxTypeQuestion = new ComboBox();
            mainPanel = new Panel();
            tabAnswerControl.SuspendLayout();
            tabPageMCAnswers.SuspendLayout();
            tabPageTFAnswers.SuspendLayout();
            tabPageOEAnswers.SuspendLayout();
            groupBoxCreateQuestion.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(42, 666);
            button1.Name = "button1";
            button1.Size = new Size(165, 61);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listQuestions
            // 
            listQuestions.Font = new Font("Segoe UI", 13F);
            listQuestions.FormattingEnabled = true;
            listQuestions.ItemHeight = 36;
            listQuestions.Location = new Point(378, 75);
            listQuestions.Name = "listQuestions";
            listQuestions.Size = new Size(769, 652);
            listQuestions.TabIndex = 12;
            listQuestions.SelectedIndexChanged += listQuestsions_SelectedIndexChanged;
            // 
            // listQuestionLabel
            // 
            listQuestionLabel.AutoSize = true;
            listQuestionLabel.Font = new Font("Segoe UI", 14F);
            listQuestionLabel.Location = new Point(348, 16);
            listQuestionLabel.Name = "listQuestionLabel";
            listQuestionLabel.Size = new Size(218, 38);
            listQuestionLabel.TabIndex = 13;
            listQuestionLabel.Text = "List of questions";
            // 
            // tabAnswerControl
            // 
            tabAnswerControl.Controls.Add(tabPageMCAnswers);
            tabAnswerControl.Controls.Add(tabPageTFAnswers);
            tabAnswerControl.Controls.Add(tabPageOEAnswers);
            tabAnswerControl.Location = new Point(1221, 41);
            tabAnswerControl.Name = "tabAnswerControl";
            tabAnswerControl.SelectedIndex = 0;
            tabAnswerControl.Size = new Size(436, 759);
            tabAnswerControl.TabIndex = 14;
            // 
            // tabPageMCAnswers
            // 
            tabPageMCAnswers.Controls.Add(deleteMCQuestionBtn);
            tabPageMCAnswers.Controls.Add(editMCQuestionBtn);
            tabPageMCAnswers.Controls.Add(labelMCQuestionText);
            tabPageMCAnswers.Controls.Add(lblAnswerD);
            tabPageMCAnswers.Controls.Add(lblAnswerC);
            tabPageMCAnswers.Controls.Add(lblAnswerB);
            tabPageMCAnswers.Controls.Add(lblAnswerA);
            tabPageMCAnswers.Controls.Add(radioButtonD);
            tabPageMCAnswers.Controls.Add(radioButtonC);
            tabPageMCAnswers.Controls.Add(radioButtonB);
            tabPageMCAnswers.Controls.Add(radioButtonA);
            tabPageMCAnswers.Location = new Point(4, 34);
            tabPageMCAnswers.Name = "tabPageMCAnswers";
            tabPageMCAnswers.Padding = new Padding(3);
            tabPageMCAnswers.Size = new Size(428, 721);
            tabPageMCAnswers.TabIndex = 0;
            tabPageMCAnswers.Text = "MCA";
            tabPageMCAnswers.UseVisualStyleBackColor = true;
            // 
            // deleteMCQuestionBtn
            // 
            deleteMCQuestionBtn.BackColor = Color.Red;
            deleteMCQuestionBtn.Font = new Font("Segoe UI", 14F);
            deleteMCQuestionBtn.ForeColor = Color.White;
            deleteMCQuestionBtn.Location = new Point(243, 520);
            deleteMCQuestionBtn.Name = "deleteMCQuestionBtn";
            deleteMCQuestionBtn.Size = new Size(139, 54);
            deleteMCQuestionBtn.TabIndex = 10;
            deleteMCQuestionBtn.Text = "Delete";
            deleteMCQuestionBtn.UseVisualStyleBackColor = false;
            deleteMCQuestionBtn.Click += deleteQuestionBtn_Click;
            // 
            // editMCQuestionBtn
            // 
            editMCQuestionBtn.BackColor = Color.Cyan;
            editMCQuestionBtn.Font = new Font("Segoe UI", 14F);
            editMCQuestionBtn.Location = new Point(18, 520);
            editMCQuestionBtn.Name = "editMCQuestionBtn";
            editMCQuestionBtn.Size = new Size(132, 54);
            editMCQuestionBtn.TabIndex = 9;
            editMCQuestionBtn.Text = "Edit";
            editMCQuestionBtn.UseVisualStyleBackColor = false;
            editMCQuestionBtn.Click += editMCQuestionBtn_Click;
            // 
            // labelMCQuestionText
            // 
            labelMCQuestionText.AutoSize = true;
            labelMCQuestionText.Font = new Font("Segoe UI", 13F);
            labelMCQuestionText.Location = new Point(18, 37);
            labelMCQuestionText.Name = "labelMCQuestionText";
            labelMCQuestionText.Size = new Size(83, 36);
            labelMCQuestionText.TabIndex = 8;
            labelMCQuestionText.Text = "label5";
            // 
            // lblAnswerD
            // 
            lblAnswerD.AutoSize = true;
            lblAnswerD.Font = new Font("Segoe UI", 15F);
            lblAnswerD.Location = new Point(90, 365);
            lblAnswerD.Name = "lblAnswerD";
            lblAnswerD.Size = new Size(97, 41);
            lblAnswerD.TabIndex = 7;
            lblAnswerD.Text = "label4";
            // 
            // lblAnswerC
            // 
            lblAnswerC.AutoSize = true;
            lblAnswerC.Font = new Font("Segoe UI", 15F);
            lblAnswerC.Location = new Point(90, 297);
            lblAnswerC.Name = "lblAnswerC";
            lblAnswerC.Size = new Size(97, 41);
            lblAnswerC.TabIndex = 6;
            lblAnswerC.Text = "label3";
            // 
            // lblAnswerB
            // 
            lblAnswerB.AutoSize = true;
            lblAnswerB.Font = new Font("Segoe UI", 15F);
            lblAnswerB.Location = new Point(90, 222);
            lblAnswerB.Name = "lblAnswerB";
            lblAnswerB.Size = new Size(97, 41);
            lblAnswerB.TabIndex = 5;
            lblAnswerB.Text = "label2";
            // 
            // lblAnswerA
            // 
            lblAnswerA.AutoSize = true;
            lblAnswerA.Font = new Font("Segoe UI", 15F);
            lblAnswerA.Location = new Point(90, 154);
            lblAnswerA.Name = "lblAnswerA";
            lblAnswerA.Size = new Size(97, 41);
            lblAnswerA.TabIndex = 4;
            lblAnswerA.Text = "label1";
            // 
            // radioButtonD
            // 
            radioButtonD.AutoSize = true;
            radioButtonD.Location = new Point(18, 370);
            radioButtonD.Name = "radioButtonD";
            radioButtonD.Size = new Size(54, 29);
            radioButtonD.TabIndex = 3;
            radioButtonD.TabStop = true;
            radioButtonD.Text = "D.";
            radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            radioButtonC.AutoSize = true;
            radioButtonC.Location = new Point(16, 303);
            radioButtonC.Name = "radioButtonC";
            radioButtonC.Size = new Size(52, 29);
            radioButtonC.TabIndex = 2;
            radioButtonC.TabStop = true;
            radioButtonC.Text = "C.";
            radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            radioButtonB.AutoSize = true;
            radioButtonB.Location = new Point(16, 229);
            radioButtonB.Name = "radioButtonB";
            radioButtonB.Size = new Size(51, 29);
            radioButtonB.TabIndex = 1;
            radioButtonB.TabStop = true;
            radioButtonB.Text = "B.";
            radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            radioButtonA.AutoSize = true;
            radioButtonA.Location = new Point(18, 164);
            radioButtonA.Name = "radioButtonA";
            radioButtonA.Size = new Size(53, 29);
            radioButtonA.TabIndex = 0;
            radioButtonA.TabStop = true;
            radioButtonA.Text = "A.";
            radioButtonA.UseVisualStyleBackColor = true;
            // 
            // tabPageTFAnswers
            // 
            tabPageTFAnswers.Controls.Add(labelAnswerFalse);
            tabPageTFAnswers.Controls.Add(labelAnswerTrue);
            tabPageTFAnswers.Controls.Add(deleteTFQuestion);
            tabPageTFAnswers.Controls.Add(editTFQuestion);
            tabPageTFAnswers.Controls.Add(labelTrueFalseQuestionText);
            tabPageTFAnswers.Controls.Add(radioButtonFalse);
            tabPageTFAnswers.Controls.Add(radioButtonTrue);
            tabPageTFAnswers.Location = new Point(4, 34);
            tabPageTFAnswers.Name = "tabPageTFAnswers";
            tabPageTFAnswers.Padding = new Padding(3);
            tabPageTFAnswers.Size = new Size(428, 721);
            tabPageTFAnswers.TabIndex = 1;
            tabPageTFAnswers.Text = "TFA";
            tabPageTFAnswers.UseVisualStyleBackColor = true;
            // 
            // labelAnswerFalse
            // 
            labelAnswerFalse.AutoSize = true;
            labelAnswerFalse.Font = new Font("Segoe UI", 14F);
            labelAnswerFalse.Location = new Point(50, 162);
            labelAnswerFalse.Name = "labelAnswerFalse";
            labelAnswerFalse.Size = new Size(78, 38);
            labelAnswerFalse.TabIndex = 14;
            labelAnswerFalse.Text = "False";
            // 
            // labelAnswerTrue
            // 
            labelAnswerTrue.AutoSize = true;
            labelAnswerTrue.Font = new Font("Segoe UI", 14F);
            labelAnswerTrue.Location = new Point(50, 104);
            labelAnswerTrue.Name = "labelAnswerTrue";
            labelAnswerTrue.Size = new Size(71, 38);
            labelAnswerTrue.TabIndex = 13;
            labelAnswerTrue.Text = "True";
            // 
            // deleteTFQuestion
            // 
            deleteTFQuestion.BackColor = Color.Red;
            deleteTFQuestion.Font = new Font("Segoe UI", 14F);
            deleteTFQuestion.ForeColor = Color.White;
            deleteTFQuestion.Location = new Point(269, 488);
            deleteTFQuestion.Name = "deleteTFQuestion";
            deleteTFQuestion.Size = new Size(139, 54);
            deleteTFQuestion.TabIndex = 12;
            deleteTFQuestion.Text = "Delete";
            deleteTFQuestion.UseVisualStyleBackColor = false;
            deleteTFQuestion.Click += deleteTFQuestion_Click;
            // 
            // editTFQuestion
            // 
            editTFQuestion.BackColor = Color.Cyan;
            editTFQuestion.Font = new Font("Segoe UI", 14F);
            editTFQuestion.Location = new Point(21, 488);
            editTFQuestion.Name = "editTFQuestion";
            editTFQuestion.Size = new Size(132, 54);
            editTFQuestion.TabIndex = 11;
            editTFQuestion.Text = "Edit";
            editTFQuestion.UseVisualStyleBackColor = false;
            editTFQuestion.Click += editTFQuestion_Click;
            // 
            // labelTrueFalseQuestionText
            // 
            labelTrueFalseQuestionText.AutoSize = true;
            labelTrueFalseQuestionText.Font = new Font("Segoe UI", 15F);
            labelTrueFalseQuestionText.Location = new Point(24, 14);
            labelTrueFalseQuestionText.Name = "labelTrueFalseQuestionText";
            labelTrueFalseQuestionText.Size = new Size(97, 41);
            labelTrueFalseQuestionText.TabIndex = 2;
            labelTrueFalseQuestionText.Text = "label5";
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Location = new Point(21, 175);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new Size(21, 20);
            radioButtonFalse.TabIndex = 1;
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Checked = true;
            radioButtonTrue.Location = new Point(21, 113);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new Size(21, 20);
            radioButtonTrue.TabIndex = 0;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // tabPageOEAnswers
            // 
            tabPageOEAnswers.Controls.Add(deleteOpenQuestion);
            tabPageOEAnswers.Controls.Add(editOpenQuestion);
            tabPageOEAnswers.Controls.Add(labelOpenQuestionText);
            tabPageOEAnswers.Controls.Add(listBoxOpenAns);
            tabPageOEAnswers.Location = new Point(4, 34);
            tabPageOEAnswers.Name = "tabPageOEAnswers";
            tabPageOEAnswers.Padding = new Padding(3);
            tabPageOEAnswers.Size = new Size(428, 721);
            tabPageOEAnswers.TabIndex = 2;
            tabPageOEAnswers.Text = "OpenA";
            tabPageOEAnswers.UseVisualStyleBackColor = true;
            // 
            // deleteOpenQuestion
            // 
            deleteOpenQuestion.BackColor = Color.Red;
            deleteOpenQuestion.Font = new Font("Segoe UI", 14F);
            deleteOpenQuestion.ForeColor = Color.White;
            deleteOpenQuestion.Location = new Point(274, 548);
            deleteOpenQuestion.Name = "deleteOpenQuestion";
            deleteOpenQuestion.Size = new Size(139, 54);
            deleteOpenQuestion.TabIndex = 12;
            deleteOpenQuestion.Text = "Delete";
            deleteOpenQuestion.UseVisualStyleBackColor = false;
            deleteOpenQuestion.Click += deleteOpenQuestion_Click;
            // 
            // editOpenQuestion
            // 
            editOpenQuestion.BackColor = Color.Cyan;
            editOpenQuestion.Font = new Font("Segoe UI", 14F);
            editOpenQuestion.Location = new Point(26, 548);
            editOpenQuestion.Name = "editOpenQuestion";
            editOpenQuestion.Size = new Size(132, 54);
            editOpenQuestion.TabIndex = 11;
            editOpenQuestion.Text = "Edit";
            editOpenQuestion.UseVisualStyleBackColor = false;
            editOpenQuestion.Click += editOpenQuestion_Click;
            // 
            // labelOpenQuestionText
            // 
            labelOpenQuestionText.AutoSize = true;
            labelOpenQuestionText.Font = new Font("Segoe UI", 12F);
            labelOpenQuestionText.Location = new Point(9, 32);
            labelOpenQuestionText.Name = "labelOpenQuestionText";
            labelOpenQuestionText.Size = new Size(78, 32);
            labelOpenQuestionText.TabIndex = 1;
            labelOpenQuestionText.Text = "label5";
            // 
            // listBoxOpenAns
            // 
            listBoxOpenAns.Font = new Font("Segoe UI", 11F);
            listBoxOpenAns.FormattingEnabled = true;
            listBoxOpenAns.ItemHeight = 30;
            listBoxOpenAns.Location = new Point(6, 115);
            listBoxOpenAns.Name = "listBoxOpenAns";
            listBoxOpenAns.Size = new Size(416, 304);
            listBoxOpenAns.TabIndex = 0;
            // 
            // nextBtnQuestion
            // 
            nextBtnQuestion.Location = new Point(869, 750);
            nextBtnQuestion.Name = "nextBtnQuestion";
            nextBtnQuestion.Size = new Size(112, 34);
            nextBtnQuestion.TabIndex = 15;
            nextBtnQuestion.Text = "Next";
            nextBtnQuestion.UseVisualStyleBackColor = true;
            nextBtnQuestion.Click += nextBtnQuestion_Click;
            // 
            // previousBtnQuestion
            // 
            previousBtnQuestion.Location = new Point(567, 750);
            previousBtnQuestion.Name = "previousBtnQuestion";
            previousBtnQuestion.Size = new Size(112, 34);
            previousBtnQuestion.TabIndex = 16;
            previousBtnQuestion.Text = "Previous";
            previousBtnQuestion.UseVisualStyleBackColor = true;
            previousBtnQuestion.Click += previousBtnQuestion_Click;
            // 
            // labelIndexOfQuestion
            // 
            labelIndexOfQuestion.AutoSize = true;
            labelIndexOfQuestion.Font = new Font("Segoe UI", 15F);
            labelIndexOfQuestion.Location = new Point(742, 742);
            labelIndexOfQuestion.Name = "labelIndexOfQuestion";
            labelIndexOfQuestion.Size = new Size(52, 41);
            labelIndexOfQuestion.TabIndex = 17;
            labelIndexOfQuestion.Text = "#1";
            // 
            // groupBoxCreateQuestion
            // 
            groupBoxCreateQuestion.BackColor = Color.Red;
            groupBoxCreateQuestion.Controls.Add(createQuestionBtn);
            groupBoxCreateQuestion.Controls.Add(comboBoxTypeQuestion);
            groupBoxCreateQuestion.Font = new Font("Segoe UI", 15F);
            groupBoxCreateQuestion.ForeColor = Color.Yellow;
            groupBoxCreateQuestion.Location = new Point(32, 112);
            groupBoxCreateQuestion.Name = "groupBoxCreateQuestion";
            groupBoxCreateQuestion.Size = new Size(328, 329);
            groupBoxCreateQuestion.TabIndex = 18;
            groupBoxCreateQuestion.TabStop = false;
            groupBoxCreateQuestion.Text = "Create Question";
            // 
            // createQuestionBtn
            // 
            createQuestionBtn.BackColor = Color.Red;
            createQuestionBtn.Font = new Font("Segoe UI", 12F);
            createQuestionBtn.ForeColor = Color.Yellow;
            createQuestionBtn.Location = new Point(25, 198);
            createQuestionBtn.Name = "createQuestionBtn";
            createQuestionBtn.Size = new Size(229, 85);
            createQuestionBtn.TabIndex = 1;
            createQuestionBtn.Text = "Create New Question";
            createQuestionBtn.UseVisualStyleBackColor = false;
            createQuestionBtn.Click += createQuestionBtn_Click;
            // 
            // comboBoxTypeQuestion
            // 
            comboBoxTypeQuestion.BackColor = Color.Red;
            comboBoxTypeQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeQuestion.Font = new Font("Segoe UI", 14F);
            comboBoxTypeQuestion.ForeColor = Color.Yellow;
            comboBoxTypeQuestion.FormattingEnabled = true;
            comboBoxTypeQuestion.Items.AddRange(new object[] { "Multiple Choice", "True False", "Open-ended" });
            comboBoxTypeQuestion.Location = new Point(25, 59);
            comboBoxTypeQuestion.Name = "comboBoxTypeQuestion";
            comboBoxTypeQuestion.Size = new Size(229, 46);
            comboBoxTypeQuestion.TabIndex = 0;
            comboBoxTypeQuestion.SelectedIndexChanged += comboBoxTypeQuestion_SelectedIndexChanged;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(nextBtnQuestion);
            mainPanel.Controls.Add(labelIndexOfQuestion);
            mainPanel.Controls.Add(groupBoxCreateQuestion);
            mainPanel.Controls.Add(previousBtnQuestion);
            mainPanel.Controls.Add(tabAnswerControl);
            mainPanel.Controls.Add(listQuestionLabel);
            mainPanel.Controls.Add(listQuestions);
            mainPanel.ImeMode = ImeMode.NoControl;
            mainPanel.Location = new Point(8, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1707, 819);
            mainPanel.TabIndex = 19;
            // 
            // MainMenuCreateQuestionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Name = "MainMenuCreateQuestionControl";
            Size = new Size(1727, 843);
            Load += CreateQuestionForm_Load;
            tabAnswerControl.ResumeLayout(false);
            tabPageMCAnswers.ResumeLayout(false);
            tabPageMCAnswers.PerformLayout();
            tabPageTFAnswers.ResumeLayout(false);
            tabPageTFAnswers.PerformLayout();
            tabPageOEAnswers.ResumeLayout(false);
            tabPageOEAnswers.PerformLayout();
            groupBoxCreateQuestion.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListBox listQuestions;
        private Label listQuestionLabel;
        private TabControl tabAnswerControl;
        private TabPage tabPageMCAnswers;
        private Label labelMCQuestionText;
        private Label lblAnswerD;
        private Label lblAnswerC;
        private Label lblAnswerB;
        private Label lblAnswerA;
        private RadioButton radioButtonD;
        private RadioButton radioButtonC;
        private RadioButton radioButtonB;
        private RadioButton radioButtonA;
        private TabPage tabPageTFAnswers;
        private Label labelTrueFalseQuestionText;
        private RadioButton radioButtonFalse;
        private RadioButton radioButtonTrue;
        private TabPage tabPageOEAnswers;
        private Label labelOpenQuestionText;
        private ListBox listBoxOpenAns;
        private Button nextBtnQuestion;
        private Button previousBtnQuestion;
        private Label labelIndexOfQuestion;
        private GroupBox groupBoxCreateQuestion;
        private ComboBox comboBoxTypeQuestion;
        private Button createQuestionBtn;
        private Button deleteMCQuestionBtn;
        private Button editMCQuestionBtn;
        private Button deleteTFQuestion;
        private Button editTFQuestion;
        private Button deleteOpenQuestion;
        private Button editOpenQuestion;
        private Panel mainPanel;
        private Label labelAnswerFalse;
        private Label labelAnswerTrue;
    }
}

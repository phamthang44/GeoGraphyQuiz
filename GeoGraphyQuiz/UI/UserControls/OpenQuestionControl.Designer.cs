namespace GeoGraphyQuiz.UI.UserControls
{
    partial class OpenQuestionControl
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
            button1 = new Button();
            buttonSave = new Button();
            listBoxQuestions = new ListBox();
            labelListQuestions = new Label();
            comboBoxCreateUpdateMode = new ComboBox();
            inputQuestionText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            buttonAddAnswer = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(60, 707);
            button1.Name = "button1";
            button1.Size = new Size(126, 68);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Red;
            buttonSave.Font = new Font("Segoe UI", 12F);
            buttonSave.ForeColor = Color.Yellow;
            buttonSave.Location = new Point(267, 580);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 46);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 25;
            listBoxQuestions.Location = new Point(1045, 59);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(472, 529);
            listBoxQuestions.TabIndex = 4;
            listBoxQuestions.SelectedIndexChanged += listBoxQuestions_SelectedIndexChanged;
            // 
            // labelListQuestions
            // 
            labelListQuestions.AutoSize = true;
            labelListQuestions.Location = new Point(1207, 601);
            labelListQuestions.Name = "labelListQuestions";
            labelListQuestions.Size = new Size(142, 25);
            labelListQuestions.TabIndex = 5;
            labelListQuestions.Text = "List of questions";
            // 
            // comboBoxCreateUpdateMode
            // 
            comboBoxCreateUpdateMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCreateUpdateMode.FormattingEnabled = true;
            comboBoxCreateUpdateMode.Items.AddRange(new object[] { "Create mode", "Update mode" });
            comboBoxCreateUpdateMode.Location = new Point(60, 588);
            comboBoxCreateUpdateMode.Name = "comboBoxCreateUpdateMode";
            comboBoxCreateUpdateMode.Size = new Size(182, 33);
            comboBoxCreateUpdateMode.TabIndex = 6;
            comboBoxCreateUpdateMode.SelectedIndexChanged += comboBoxCreateUpdateMode_SelectedIndexChanged;
            // 
            // inputQuestionText
            // 
            inputQuestionText.Font = new Font("Segoe UI", 11F);
            inputQuestionText.Location = new Point(60, 59);
            inputQuestionText.Name = "inputQuestionText";
            inputQuestionText.Size = new Size(487, 37);
            inputQuestionText.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 22);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 9;
            label3.Text = "Input your question:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 131);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 10;
            label4.Text = "Input your answer:";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.AutoScrollMargin = new Size(3, 3);
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.BackColor = Color.LightGreen;
            flowLayoutPanel.Location = new Point(60, 159);
            flowLayoutPanel.Margin = new Padding(0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(737, 401);
            flowLayoutPanel.TabIndex = 12;
            // 
            // buttonAddAnswer
            // 
            buttonAddAnswer.BackColor = Color.Blue;
            buttonAddAnswer.ForeColor = Color.FromArgb(128, 255, 255);
            buttonAddAnswer.Location = new Point(612, 109);
            buttonAddAnswer.Name = "buttonAddAnswer";
            buttonAddAnswer.Size = new Size(136, 44);
            buttonAddAnswer.TabIndex = 13;
            buttonAddAnswer.Text = "Add answer";
            buttonAddAnswer.UseVisualStyleBackColor = false;
            buttonAddAnswer.Click += buttonAddAnswer_Click;
            // 
            // OpenQuestionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddAnswer);
            Controls.Add(flowLayoutPanel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(inputQuestionText);
            Controls.Add(comboBoxCreateUpdateMode);
            Controls.Add(labelListQuestions);
            Controls.Add(listBoxQuestions);
            Controls.Add(buttonSave);
            Controls.Add(button1);
            Name = "OpenQuestionControl";
            Size = new Size(1738, 834);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonSave;
        private ListBox listBoxQuestions;
        private Label labelListQuestions;
        private ComboBox comboBoxCreateUpdateMode;
        private TextBox inputQuestionText;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonAddAnswer;
    }
}

using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoGraphyQuiz.UI
{
    public partial class ResultsForm : Form
    {
        private List<UserAnswer> userAnswers;
        private List<Question> correctAnswers;
        private TimeSpan elapsedTime;
        private IServiceProvider _provider;
        public ResultsForm(List<UserAnswer> tempAnswers, List<Question> questions, TimeSpan usedTime, IServiceProvider provider)
        {
            userAnswers = tempAnswers;
            correctAnswers = questions;
            InitializeComponent();
            LoadListAnswers();
            this.elapsedTime = usedTime;

            labelTimeUsed.Text = $"Time used: {elapsedTime:mm\\:ss}";
            _provider = provider;
        }

        private void LoadListAnswers()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            int correctCount = 0;
            foreach (var userAnswer in userAnswers)
            {
                var question = correctAnswers.FirstOrDefault(q => q.Id == userAnswer.Id);
                if (question != null)
                {
                    bool isCorrect = false;
                    string correctAnswerText = "";
                    if (question is MultipleChoiceQuestion mcq)
                    {
                        isCorrect = mcq.CheckAnswer((MultipleChoiceAnswer)userAnswer.Answer);
                        correctAnswerText = string.Join(", ",
                        mcq.Options
                            .Where(a => a.IsCorrect)
                            .Select(a => a.OptionText));
                    }
                    else if (question is OpenQuestion opq)
                    {
                        isCorrect = opq.CheckAnswer(userAnswer.Answer.ToString());
                        correctAnswerText = string.Join(" / ",
                        opq.Answers
                            .Where(a => a.IsMainAnswer)
                            .Select(a => a.AnswerText));
                    }
                    else if (question is TrueFalseQuestion tfq)
                    {
                        isCorrect = tfq.CheckAnswer(bool.Parse(userAnswer.Answer.ToString()));
                        correctAnswerText = tfq.Answer.IsTrue ? "True" : "False";
                    }
                    if (isCorrect) correctCount++;

                    string result = isCorrect ? "✅ Correct" : "❌ Incorrect";

                    var lblUserAnswer = new Label
                    {
                        AutoSize = true,
                        Text = $"Q{question.Id}: Your Answer = {userAnswer.Answer} → {result}",
                        ForeColor = isCorrect ? Color.Green : Color.Red,
                        Margin = new Padding(5)
                    };

                    var lblCorrectAnswer = new Label
                    {
                        AutoSize = true,
                        Text = $"→ Correct Answer: {correctAnswerText}",
                        ForeColor = Color.Blue,
                        Visible = false,
                        Margin = new Padding(5)
                    };


                    // Label store correct answer (hide initially)
                    int currentRow = tableLayoutPanel1.RowCount++;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel1.Controls.Add(lblUserAnswer, 0, currentRow);
                    tableLayoutPanel1.Controls.Add(lblCorrectAnswer, 1, currentRow);
                }

            }
            labelScore.Text = $"Score: {correctCount}/{correctAnswers.Count}";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm(_provider);
            mainForm.Show();
        }

        private void showCorrectAnswerBtn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is Label lbl && lbl.Text.StartsWith("→ Correct Answer"))
                {
                    lbl.Visible = true;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

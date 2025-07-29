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
            LoadListBox();
            this.elapsedTime = usedTime;

            labelTimeUsed.Text = $"Time used: {elapsedTime:mm\\:ss}";
            _provider = provider;
        }

        private void LoadListBox()
        {
            int correctCount = 0;
            foreach (var userAnswer in userAnswers)
            {
                var question = correctAnswers.FirstOrDefault(q => q.Id == userAnswer.Id);
                if (question != null)
                {
                    bool isCorrect = false;
                    if (question is MultipleChoiceQuestion mcq)
                    {
                        isCorrect = mcq.CheckAnswer((MultipleChoiceAnswer)userAnswer.Answer);
                    }
                    else if (question is OpenQuestion opq)
                    {
                        isCorrect = opq.CheckAnswer(userAnswer.Answer.ToString());
                    }
                    else if (question is TrueFalseQuestion tfq)
                    {
                        isCorrect = tfq.CheckAnswer(bool.Parse(userAnswer.Answer.ToString()));
                    }
                    if (isCorrect) correctCount++;

                    string result = isCorrect ? "✅ Correct" : "❌ Incorrect";

                    listBoxAnswers.Items.Add(
                        $"Q{question.Id}: Your Answer = {userAnswer.Answer} → {result}");
                }
                else
                {
                    listBoxAnswers.Items.Add($"Question {userAnswer.Id} not found");
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
    }
}

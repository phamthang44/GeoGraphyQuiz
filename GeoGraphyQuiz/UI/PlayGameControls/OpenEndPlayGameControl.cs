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

namespace GeoGraphyQuiz.UI.PlayGameControls
{
    public partial class OpenEndPlayGameControl : UserControl, IPlayableControl
    {
        private OpenQuestion _question;
        private List<UserAnswer> userAnswers;
        private OpenAnswer selectedAnswer;
        public OpenEndPlayGameControl(OpenQuestion question, List<UserAnswer> tempAnswers)
        {
            _question = question;
            userAnswers = tempAnswers;
            InitializeComponent();
        }

        public UserAnswer? GetUserAnswer()
        {
            if (selectedAnswer == null) return null;

            return new UserAnswer
            {
                Id = _question.Id,
                Answer = selectedAnswer
            };
        }

        private void saveAnsBtn_Click(object sender, EventArgs e)
        {
            if (inputAnswerText.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input the answer before clicking save");
                return;
            }
            string answerText = inputAnswerText.Text.Trim();
            OpenAnswer userAnswer = new OpenAnswer
            {
                QuestionId = _question.Id,
                AnswerText = answerText,
                OpenQuestion = _question,
            };
            selectedAnswer = userAnswer;
            SaveOrUpdateUserAnswer(new UserAnswer
            {
                Id = _question.Id,
                Answer = userAnswer
            });
            inputAnswerText.Enabled = false;
            saveAnsBtn.Enabled = false;
        }
        private void SaveOrUpdateUserAnswer(UserAnswer newAnswer)
        {
            var existing = userAnswers.FirstOrDefault(a => a.Id == newAnswer.Id);
            if (existing != null)
            {
                existing.Answer = newAnswer.Answer;
            }
            else
            {
                userAnswers.Add(newAnswer);
            }

        }
    }
}

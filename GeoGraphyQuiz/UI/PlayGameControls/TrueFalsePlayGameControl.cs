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
    public partial class TrueFalsePlayGameControl : UserControl, IPlayableControl
    {
        private TrueFalseQuestion _question;
        private List<UserAnswer> userAnswers;
        private TrueFalseAnswer selectedAnswer;
        public TrueFalsePlayGameControl(TrueFalseQuestion question, List<UserAnswer> tempUserAnswers)
        {
            _question = question;
            userAnswers = tempUserAnswers;
            InitializeComponent();
            AssignRadioButtonUserAnswer();
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

        private void AssignRadioButtonUserAnswer()
        {
            var trueAnswer = new TrueFalseAnswer { IsTrue = true };
            var falseAnswer = new TrueFalseAnswer { IsTrue = false };

            radioButtonTrue.Tag = trueAnswer;
            radioButtonFalse.Tag = falseAnswer;

            radioButtonFalse.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonTrue.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio != null && radio.Checked)
            {
                selectedAnswer = radio.Tag as TrueFalseAnswer;
                if (selectedAnswer != null)
                {
                    SaveOrUpdateUserAnswer(new UserAnswer
                    {
                        Id = _question.Id,
                        Answer = selectedAnswer
                    });
                }
            }
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

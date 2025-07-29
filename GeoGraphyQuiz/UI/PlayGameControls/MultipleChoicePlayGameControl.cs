using GeoGraphyQuiz.Model;
using Microsoft.VisualBasic.Devices;
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
    public partial class MultipleChoicePlayGameControl : UserControl, IPlayableControl
    {
        private MultipleChoiceQuestion _question;
        private List<UserAnswer> userAnswers;
        private MultipleChoiceAnswer? selectedAnswer;
        public MultipleChoicePlayGameControl(MultipleChoiceQuestion question, List<UserAnswer> tempUserAnswers)
        {
            _question = question;
            userAnswers = tempUserAnswers;
            InitializeComponent();

            radioButtonAOpt.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonBOpt.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonCOpt.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonDOpt.CheckedChanged += RadioButton_CheckedChanged;
            LoadAnswer();
        }

        private void LoadAnswer()
        {
            radioButtonAOpt.Text = "A. " + _question.Options[0].OptionText;
            radioButtonAOpt.Tag = _question.Options[0];
            radioButtonAOpt.Checked = false;

            radioButtonBOpt.Text = "B. " + _question.Options[1].OptionText;
            radioButtonBOpt.Tag = _question.Options[1];
            radioButtonBOpt.Checked = false;

            radioButtonCOpt.Text = "C. " + _question.Options[2].OptionText;
            radioButtonCOpt.Tag = _question.Options[2];
            radioButtonCOpt.Checked = false;

            radioButtonDOpt.Text = "D. " + _question.Options[3].OptionText;
            radioButtonDOpt.Tag = _question.Options[3];
            radioButtonDOpt.Checked = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio != null && radio.Checked)
            {
                selectedAnswer = radio.Tag as MultipleChoiceAnswer;
                if (selectedAnswer != null)
                {
                    SaveOrUpdateUserAnswer(new UserAnswer()
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
        public UserAnswer? GetUserAnswer()
        {
            if (selectedAnswer == null) return null;

            return new UserAnswer
            {
                Id = _question.Id,
                Answer = selectedAnswer
            };
        }
    }
}

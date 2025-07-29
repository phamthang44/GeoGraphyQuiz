using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoGraphyQuiz.UI.UserControls
{
    public partial class TrueFalseQuestionControl : UserControl
    {
        private readonly TrueFalseQuestionService _trueFalseQuestionService;
        private readonly TrueFalseAnswerService _trueFalseAnswerService;
        private readonly IServiceProvider _provider;
        private TrueFalseQuestion _question;
        private readonly Action _goBackCallback;
        private bool _isCreatingNew = false;
        public TrueFalseQuestionControl(TrueFalseQuestionService trueFalseQuestionService, TrueFalseAnswerService trueFalseAnswerService, IServiceProvider serviceProvider, TrueFalseQuestion question, Action goBackCallback, bool isCreatingNew)
        {
            InitializeComponent();
            _trueFalseQuestionService = trueFalseQuestionService;
            _trueFalseAnswerService = trueFalseAnswerService;
            _provider = serviceProvider;
            _question = question;
            _goBackCallback = goBackCallback;
            _isCreatingNew = isCreatingNew;

            HandleListQuestionLoad();
            HandleLoadSelectedQuestionToEditFromMain();

            if (_isCreatingNew)
            {
                comboBoxUpdateCreateMode.SelectedIndex = 1;
            } else
            {
                comboBoxUpdateCreateMode.SelectedIndex = 0;
            }
        }

        private void HandleLoadSelectedQuestionToEditFromMain()
        {
            if (_question != null)
            {
                inputTFQuestionText.Text = _question.QuestionText;
                if (_question.Answer.IsTrue)
                {
                    radioButtonTrue.Checked = true;
                }
                else
                {
                    radioButtonFalse.Checked = true;
                }
            }
        }

        private void HandleListQuestionLoad()
        {
            foreach (var item in _trueFalseQuestionService.GetAllQuestions())
            {
                listTFQuestions.Items.Add(item);
            }
            if (_isCreatingNew)
            {
                HandleCreateQuestionMode();
            }
        }

        private void HandleCreateQuestionMode()
        {
            listTFQuestions.Hide();
            inputTFQuestionText.Text = "";
            HandleResetRadioButton();
        }

        private void HandleResetRadioButton()
        {
            RadioButton[] radioButtons = new RadioButton[]{ radioButtonFalse, radioButtonTrue };
            foreach (var rb in radioButtons) 
            {
                rb.Checked = false;
            }
        }

        private void HandleUpdateQuestionMode()
        {
            listTFQuestions.Show();
        }

        private void saveTFQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = inputTFQuestionText.Text.Trim();
                if (questionText.Length == 0)
                {
                    MessageBox.Show("You haven't input question yet!");
                    return;
                }

                if (!radioButtonTrue.Checked && !radioButtonFalse.Checked)
                {
                    MessageBox.Show("You did't choose the answer true or false for this question!");
                    return;
                }

                if (_isCreatingNew)
                {
                    var question = new TrueFalseQuestion
                    {
                        QuestionText = questionText,
                        Answer = new TrueFalseAnswer
                        {
                            IsTrue = radioButtonTrue.Checked
                        },
                    };

                    _trueFalseQuestionService.CreateQuestion(question);

                    MessageBox.Show("New true false question has been created successfully!");

                    _isCreatingNew = false;
                    HandleResetRadioButton();
                    HandleUpdateQuestionMode();
                    comboBoxUpdateCreateMode.SelectedIndex = 1;
                }
                else
                {
                    var question = GetSelectedQuestion<TrueFalseQuestion>() != null ? GetSelectedQuestion<TrueFalseQuestion>() : _question;
                    if (_question != null)
                    {
                        question.QuestionText = questionText;
                        question.Answer.IsTrue = radioButtonTrue.Checked;
                        _trueFalseQuestionService.UpdateQuestion(question);
                        MessageBox.Show("This question has been updated successfully!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetUIForUpdateOrCreate();
        }

        private void ResetUIForUpdateOrCreate()
        {
            _isCreatingNew = false;
            listTFQuestions.Items.Clear();
            foreach (var item in _trueFalseQuestionService.GetAllQuestions())
            {
                listTFQuestions.Items.Add(item);
            }

        }

        private void listTFQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var question = GetSelectedQuestion<TrueFalseQuestion>();
            if (question != null)
            {
                inputTFQuestionText.Text = question.QuestionText;
                if (question.Answer.IsTrue)
                {
                    radioButtonTrue.Checked = true;
                }
                else
                {
                    radioButtonFalse.Checked = true;
                }
            }
        }

        private T GetSelectedQuestion<T>() where T : class
        {
            return listTFQuestions.SelectedItem as T;
        }

        private void backToPreviousPageBtn_Click(object sender, EventArgs e)
        {
            _goBackCallback?.Invoke();
        }

        private void comboBoxUpdateCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateCreateMode.SelectedIndex == 1)
            {
                HandleCreateQuestionMode();
            } else
            {
                HandleUpdateQuestionMode();
            }
        }
    }
}

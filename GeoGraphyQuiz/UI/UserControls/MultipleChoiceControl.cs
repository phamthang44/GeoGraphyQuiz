using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
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
    public partial class MultipleChoiceControl : UserControl
    {
        private readonly MultipleChoiceAnswerService _answerSerivce;
        private readonly MultipleChoiceQuestionService _questionService;
        private readonly IServiceProvider _provider;
        private MultipleChoiceQuestion _question;
        private readonly Action _goBackCallback;
        private bool _isCreatingNew = false;

        public MultipleChoiceControl(MultipleChoiceAnswerService answerSerivce, MultipleChoiceQuestionService questionService, IServiceProvider serviceProvider, MultipleChoiceQuestion question, Action goBackCallback, bool isCreatingNew)
        {
            InitializeComponent();
            _answerSerivce = answerSerivce;
            _questionService = questionService;
            _provider = serviceProvider;
            _question = question;
            _goBackCallback = goBackCallback;
            _isCreatingNew = isCreatingNew;

            foreach (var item in _questionService.GetAllQuestions())
            {
                listMCQuestions.Items.Add(item);
            }
            _isCreatingNew = isCreatingNew;
            if (_isCreatingNew)
            {
                HandleCreateQuestionMode();
            } else
            {
                HandleUpdateQuestionMode();
                comboBoxCreateUpdateMode.SelectedIndex = 1;
            }
            //LoadCurrentQuestionFromHomePage();
        }

        private void HandleCreateQuestionMode()
        {
            listMCQuestions.Hide();
            previousQuestionBtn.Hide();
            nextQuestionBtn.Hide();
            indexOfQuestion.Hide();
        }

        private void HandleUpdateQuestionMode()
        {
           
            listMCQuestions.Show();
            previousQuestionBtn.Show();
            nextQuestionBtn.Show();
            indexOfQuestion.Show();
        }

        private void MultipleChoiceControl_Load(object sender, EventArgs e)
        {

        }

        private T GetSelectedQuestion<T>() where T : class
        {
            return listMCQuestions.SelectedItem as T;
        }


        private void saveMCquestionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = inputQuestionText.Text.Trim();
                string optA = optionAInput.Text.Trim();
                string optB = optionBInput.Text.Trim();
                string optC = optionCInput.Text.Trim();
                string optD = optionDInput.Text.Trim();

                char correctOption = radioButtonA.Checked ? 'A' :
                             radioButtonB.Checked ? 'B' :
                             radioButtonC.Checked ? 'C' :
                             radioButtonD.Checked ? 'D' : '\0';

                if (string.IsNullOrEmpty(questionText) || correctOption == '\0')
                {
                    MessageBox.Show("Please fill in all fields and select the correct answer.");
                    return;
                }

                var selectedQuestion = GetSelectedQuestion<MultipleChoiceQuestion>();

                if (_isCreatingNew && selectedQuestion == null)
                {
                    var newQuestion = new MultipleChoiceQuestion
                    {
                        QuestionText = questionText,
                        Options = new List<MultipleChoiceAnswer>
                        {
                            new MultipleChoiceAnswer { OptionLabel = 'A', OptionText = optA, IsCorrect = (correctOption == 'A') },
                            new MultipleChoiceAnswer { OptionLabel = 'B', OptionText = optB, IsCorrect = (correctOption == 'B') },
                            new MultipleChoiceAnswer { OptionLabel = 'C', OptionText = optC, IsCorrect = (correctOption == 'C') },
                            new MultipleChoiceAnswer { OptionLabel = 'D', OptionText = optD, IsCorrect = (correctOption == 'D') },
                        }
                    };
                    _questionService.CreateQuestion(newQuestion);
                    MessageBox.Show("New question added successfully!");
                    _isCreatingNew = false;
                    comboBoxCreateUpdateMode.SelectedIndex = 1;
                    HandleUpdateQuestionMode();
                }
                else
                {
                    //=============== update question =======================
                    var question = _questionService.GetQuestionById(selectedQuestion.Id);
                    if (question == null)
                    {
                        MessageBox.Show("Question not found in database.");
                        return;
                    }

                    // Update content question
                    question.QuestionText = questionText;

                    foreach (var answer in question.Options)
                    {
                        switch (answer.OptionLabel)
                        {
                            case 'A':
                                answer.OptionText = optA;
                                answer.IsCorrect = radioButtonA.Checked;
                                break;
                            case 'B':
                                answer.OptionText = optB;
                                answer.IsCorrect = radioButtonB.Checked;
                                break;
                            case 'C':
                                answer.OptionText = optC;
                                answer.IsCorrect = radioButtonC.Checked;
                                break;
                            case 'D':
                                answer.OptionText = optD;
                                answer.IsCorrect = radioButtonD.Checked;
                                break;
                            default:
                                break;
                        }
                    }

                    // Update question
                    _questionService.UpdateQuestion(question);

                    MessageBox.Show("Question updated successfully!");
                }
                // Refresh UI
                RefreshListQuestion();
                LoadSelectedQuestion();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshListQuestion()
        {
            listMCQuestions.Items.Clear();
            var updatedQuestions = _questionService.GetAllQuestions();
            foreach (var q in updatedQuestions)
            {
                listMCQuestions.Items.Add(q);
            }
        }

        private void previousQuestionBtn_Click(object sender, EventArgs e)
        {
            int index = listMCQuestions.SelectedIndex;

            // decrease index
            index -= 1;

            // if less than 0 back to the end of list
            if (index < 0)
            {
                index = listMCQuestions.Items.Count - 1;
            }

            listMCQuestions.SetSelected(index, true);
            indexOfQuestion.Text = (index += 1).ToString();
        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            int index = listMCQuestions.SelectedIndex;

            // increase index
            index += 1;

            // if more than the total of question, reset into 0
            if (index >= listMCQuestions.Items.Count)
            {
                index = 0;
            }

            listMCQuestions.SetSelected(index, true);
            indexOfQuestion.Text = (index += 1).ToString();
        }

        private void listMCQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedQuestion();
        }

        private void HandleResetStyle()
        {
            foreach (var rb in new[] { radioButtonA, radioButtonB, radioButtonC, radioButtonD })
            {
                rb.ForeColor = SystemColors.ControlText;
            }

            foreach (var rb in new[] { optionAInput, optionBInput, optionCInput, optionDInput })
            {
                rb.ForeColor = SystemColors.ControlText;
            }
        }

        private void LoadSelectedQuestion()
        {
            HandleResetStyle();
            try
            {
                var question = GetSelectedQuestion<MultipleChoiceQuestion>() != null ? GetSelectedQuestion<MultipleChoiceQuestion>() : _questionService.GetAllQuestions()[0];
                inputQuestionText.Text = question.QuestionText;
                List<MultipleChoiceAnswer> ansList = _answerSerivce.GetMultipleChoiceAnswersByQuestionId(question.Id);
                if (ansList != null)
                {
                    optionAInput.Text = ansList[0].OptionText;
                    optionBInput.Text = ansList[1].OptionText;
                    optionCInput.Text = ansList[2].OptionText;
                    optionDInput.Text = ansList[3].OptionText;
                    foreach (MultipleChoiceAnswer answer in ansList)
                    {
                        if (answer.IsCorrect)
                        {
                            switch (answer.OptionLabel)
                            {
                                case 'A':
                                    radioButtonA.Checked = true;
                                    if (radioButtonA.Checked)
                                    {
                                        optionAInput.ForeColor = Color.Green;
                                        radioButtonA.ForeColor = Color.Green;
                                    }
                                    break;
                                case 'B':
                                    radioButtonB.Checked = true;
                                    if (radioButtonB.Checked)
                                    {
                                        optionBInput.ForeColor = Color.Green;
                                        radioButtonB.ForeColor = Color.Green;
                                    }
                                    break;
                                case 'C':
                                    radioButtonC.Checked = true;
                                    if (radioButtonC.Checked)
                                    {
                                        optionCInput.ForeColor = Color.Green;
                                        radioButtonC.ForeColor = Color.Green;
                                    }
                                    break;
                                case 'D':
                                    radioButtonD.Checked = true;
                                    if (radioButtonD.Checked)
                                    {
                                        optionDInput.ForeColor = Color.Green;
                                        radioButtonD.ForeColor = Color.Green;
                                    }
                                    break;
                                default:
                                    radioButtonA.Checked = false;
                                    radioButtonB.Checked = false;
                                    radioButtonC.Checked = false;
                                    radioButtonD.Checked = false;
                                    MessageBox.Show("Nothing selected");
                                    break;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inputQuestionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadCurrentQuestionFromHomePage()
        {
            inputQuestionText.Text = _question.QuestionText;
            List<MultipleChoiceAnswer> ans = _answerSerivce.GetMultipleChoiceAnswersByQuestionId(_question.Id);
            optionAInput.Text = ans[0].OptionText;
            optionBInput.Text = ans[1].OptionText;
            optionCInput.Text = ans[2].OptionText;
            optionDInput.Text = ans[3].OptionText;


            foreach (MultipleChoiceAnswer answer in ans)
            {
                if (answer.IsCorrect)
                {
                    switch (answer.OptionLabel)
                    {
                        case 'A':
                            radioButtonA.Checked = true;
                            break;
                        case 'B':
                            radioButtonB.Checked = true;
                            break;
                        case 'C':
                            radioButtonC.Checked = true;
                            break;
                        case 'D':
                            radioButtonD.Checked = true;
                            break;
                        default:
                            radioButtonA.Checked = false;
                            radioButtonB.Checked = false;
                            radioButtonC.Checked = false;
                            radioButtonD.Checked = false;
                            break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _goBackCallback?.Invoke();
        }

        private void comboBoxCreateUpdateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCreateUpdateMode.SelectedIndex == 0)
            {
                inputQuestionText.Text = "";
                optionAInput.Text = "";
                optionBInput.Text = "";
                optionCInput.Text = "";
                optionDInput.Text = "";

                radioButtonA.Checked = false;
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
                radioButtonD.Checked = false;

                HandleCreateQuestionMode();
                HandleResetStyle();
                _isCreatingNew = true;
            } else
            {
                HandleUpdateQuestionMode();
                HandleResetStyle();
                _isCreatingNew = false;
            }
        }
    }
}

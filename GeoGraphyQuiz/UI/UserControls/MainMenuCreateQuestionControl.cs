using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Service;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class MainMenuCreateQuestionControl : UserControl
    {
        private readonly MultipleChoiceAnswerService _answerSerivce;
        private readonly MultipleChoiceQuestionService _questionService;
        private readonly TrueFalseQuestionService _trueFalseQuestionService;
        private readonly TrueFalseAnswerService _trueFalseAnswerService;
        private readonly OpenQuestionService _openQuestionService;
        private readonly OpenAnswerService _openAnswerService;
        private readonly IServiceProvider _provider;
        private readonly CreateQuestionForm _parentForm;
        public MainMenuCreateQuestionControl(IServiceProvider serviceProvider, CreateQuestionForm questionForm)
        {
            InitializeComponent();
            _provider = serviceProvider;
            _answerSerivce = serviceProvider.GetRequiredService<MultipleChoiceAnswerService>();
            _questionService = serviceProvider.GetRequiredService<MultipleChoiceQuestionService>();
            _trueFalseQuestionService = serviceProvider.GetRequiredService<TrueFalseQuestionService>();
            _trueFalseAnswerService = serviceProvider.GetRequiredService<TrueFalseAnswerService>();
            _openQuestionService = serviceProvider.GetRequiredService<OpenQuestionService>();
            _openAnswerService = serviceProvider.GetRequiredService<OpenAnswerService>();
            _parentForm = questionForm;
            LoadQuestions();
            LoadQuestionZero();
            comboBoxTypeQuestion.SelectedIndex = 0;
        }

        private void questionTypeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parentForm.Hide();
            var mainForm = _provider.GetRequiredService<MainForm>();
            mainForm.Show();
        }

        private void comboBoxTypeQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createQuestionBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxTypeQuestion.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // Multiple Choice
                    var mcQuestion = GetSelectedQuestion<MultipleChoiceQuestion>();
                    var mcControl = new MultipleChoiceControl(_answerSerivce, _questionService, _provider, mcQuestion, _parentForm.GoBack, true);
                    _parentForm.LoadControl(mcControl);
                    break;

                case 1: // True/False
                    var tfQuestion = GetSelectedQuestion<TrueFalseQuestion>();
                    var tfControl = new TrueFalseQuestionControl(_trueFalseQuestionService, _trueFalseAnswerService, _provider, tfQuestion, _parentForm.GoBack, true);
                    _parentForm.LoadControl(tfControl);
                    break;

                case 2: // Open question
                    var openQuestion = GetSelectedQuestion<OpenQuestion>();
                    var openQuestionControl = new OpenQuestionControl(_openQuestionService, _openAnswerService, _provider, openQuestion, _parentForm.GoBack, true);
                    _parentForm.LoadControl(openQuestionControl);
                    break;
                default:
                    MessageBox.Show("Please select a question type.");
                    break;
            }
        }

        private void deleteQuestionBtn_Click(object sender, EventArgs e)
        {
            var selectedQuestion = GetSelectedQuestion<MultipleChoiceQuestion>(); //
            if (selectedQuestion == null) return;

            if (selectedQuestion != null && selectedQuestion is MultipleChoiceQuestion)
            {
                var confirmDialog = new ConfirmMessageBox(selectedQuestion.QuestionText);
                confirmDialog.ShowDialog();

                if (confirmDialog.IsConfirmed)
                {
                    try
                    {
                        _questionService.DeleteQuestion(selectedQuestion.Id);
                        MessageBox.Show("Deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    LoadQuestions(); // Refresh UI
                    LoadQuestionZero();
                }
            }
        }

        public void ReloadQuestions()
        {
            listQuestions.Items.Clear();
            var mc = _questionService.GetAllQuestions();
            var tf = _trueFalseQuestionService.GetAllQuestions();
            var oq = _openQuestionService.GetAllQuestions();
            // Gộp và add vào list
            var allQuestions = mc.Cast<Question>().Concat(tf).Concat(oq).ToList(); 
            foreach (var q in allQuestions)
            {
                listQuestions.Items.Add(q);
            }
        }

        private void LoadQuestions()
        {
            listQuestions.Items.Clear(); //remove all items before loading again

            try
            {
                List<MultipleChoiceQuestion> mcQuestions = _questionService.GetAllQuestions();
                List<TrueFalseQuestion> tfQuestions = _trueFalseQuestionService.GetAllQuestions();
                List<OpenQuestion> openQuestions = _openQuestionService.GetAllQuestions();
                List<Question> questions = tfQuestions.Cast<Question>()
                                                      .Concat(mcQuestions.Cast<Question>())
                                                      .Concat(openQuestions.Cast<Question>())
                                                      .ToList();
                foreach (var question in questions)
                {
                    listQuestions.Items.Add(question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ResetRadioCheckAndColorStyle()
        {
            foreach (var rb in new[] { radioButtonA, radioButtonB, radioButtonC, radioButtonD })
            {
                rb.ForeColor = SystemColors.ControlText;
                rb.Checked = false;
                rb.Enabled = false;
            }

            foreach (var rb in new[] { lblAnswerA, lblAnswerB, lblAnswerC, lblAnswerD })
            {
                rb.ForeColor = SystemColors.ControlText;
            }
        }

        private void LoadQuestionZero()
        {
            if (listQuestions.Items.Count != 0)
            {
                if (listQuestions.Items[0] is MultipleChoiceQuestion)
                {
                    listQuestions.SetSelected(0, true);
                    LoadMultipleChoiceQuestionZero();
                }
                else if (listQuestions.Items[0] is TrueFalseQuestion)
                {
                    listQuestions.SetSelected(0, true);
                    LoadTrueFalseQuestionZero();
                }
                else
                {
                    listQuestions.SetSelected(0, true);
                    LoadOpenEndQuestionZero();
                }
            }

        }

        private void LoadOpenEndQuestionZero()
        {
            OpenQuestion question = _openQuestionService.GetAllQuestions()[0];
            labelOpenQuestionText.Text = question.QuestionText;
            LoadOpenEndedQuestionAndAnswer(question);
        }

        private void LoadMultipleChoiceQuestionZero()
        {
            ResetRadioCheckAndColorStyle();
            MultipleChoiceQuestion question = _questionService.GetAllQuestions()[0];
            labelMCQuestionText.Text = question.QuestionText;
            List<MultipleChoiceAnswer> ans = _answerSerivce.GetMultipleChoiceAnswersByQuestionId(question.Id);
            lblAnswerA.Text = ans[0].OptionText;
            lblAnswerB.Text = ans[1].OptionText;
            lblAnswerC.Text = ans[2].OptionText;
            lblAnswerD.Text = ans[3].OptionText;
            foreach (var answer in ans)
            {
                if (answer.IsCorrect)
                {
                    switch (answer.OptionLabel)
                    {
                        case 'A':
                            radioButtonA.Checked = true;
                            radioButtonA.ForeColor = Color.Green;
                            lblAnswerA.ForeColor = Color.Green;
                            radioButtonA.AutoCheck = false;
                            break;
                        case 'B':
                            radioButtonB.Checked = true;
                            radioButtonB.ForeColor = Color.Green;
                            lblAnswerB.ForeColor = Color.Green;
                            radioButtonB.AutoCheck = false;
                            break;
                        case 'C':
                            radioButtonC.Checked = true;
                            radioButtonC.ForeColor = Color.Green;
                            lblAnswerC.ForeColor = Color.Green;
                            radioButtonC.AutoCheck = false;
                            break;
                        case 'D':
                            radioButtonD.Checked = true;
                            radioButtonD.ForeColor = Color.Green;
                            lblAnswerD.ForeColor = Color.Green;
                            radioButtonD.AutoCheck = false;
                            break;
                        default:
                            MessageBox.Show("There is some error here! no Selection Question");
                            break;
                    }

                }
            }
        }

        private void LoadTrueFalseQuestionZero()
        {
            DisableRadioButtonTrueFalse();
            ResetLabelColorForTrueFalse();
            TrueFalseQuestion question = _trueFalseQuestionService.GetAllQuestions()[0];
            labelTrueFalseQuestionText.Text = question.QuestionText;
            if (question.Answer.IsTrue)
            {
                radioButtonTrue.Checked = true;
                labelAnswerTrue.ForeColor = Color.Green;
            }
            else
            {
                radioButtonFalse.Checked = true;
                labelAnswerFalse.ForeColor = Color.Green;
            }
        }

        private T GetSelectedQuestion<T>() where T : class
        {
            return listQuestions.SelectedItem as T;
        }

        private void deleteTFQuestion_Click(object sender, EventArgs e)
        {
            var selectedQuestion = GetSelectedQuestion<TrueFalseQuestion>();
            if (selectedQuestion == null) return;

            if (selectedQuestion != null && selectedQuestion is TrueFalseQuestion)
            {
                var confirmDialog = new ConfirmMessageBox(selectedQuestion.QuestionText);
                confirmDialog.ShowDialog();

                if (confirmDialog.IsConfirmed)
                {
                    try
                    {
                        _trueFalseQuestionService.DeleteQuestion(selectedQuestion.Id);
                        MessageBox.Show("Deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    LoadQuestions(); // Refresh UI
                    LoadQuestionZero();
                }
            }
        }

        private void deleteOpenQuestion_Click(object sender, EventArgs e)
        {
            var selectedQuestion = GetSelectedQuestion<OpenQuestion>();
            if (selectedQuestion == null) return;

            if (selectedQuestion != null && selectedQuestion is OpenQuestion)
            {
                var confirmDialog = new ConfirmMessageBox(selectedQuestion.QuestionText);
                confirmDialog.ShowDialog();

                if (confirmDialog.IsConfirmed)
                {
                    try
                    {
                        _openQuestionService.DeleteQuestion(selectedQuestion.Id);
                        MessageBox.Show("Deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    LoadQuestions(); // Refresh UI
                    LoadQuestionZero();
                }
            }
        }

        private void LoadMultipleChoiceQuestionAndAnswer(MultipleChoiceQuestion question)
        {
            ResetRadioCheckAndColorStyle();
            if (question != null && question is MultipleChoiceQuestion)
            {
                labelMCQuestionText.Text = question.QuestionText;
                List<MultipleChoiceAnswer> ans = _answerSerivce.GetMultipleChoiceAnswersByQuestionId(question.Id);
                lblAnswerA.Text = ans[0].OptionText;
                lblAnswerB.Text = ans[1].OptionText;
                lblAnswerC.Text = ans[2].OptionText;
                lblAnswerD.Text = ans[3].OptionText;

                foreach (var answer in ans)
                {
                    if (answer.IsCorrect)
                    {
                        switch (answer.OptionLabel)
                        {
                            case 'A':
                                radioButtonA.Checked = true;
                                radioButtonA.ForeColor = Color.Green;
                                lblAnswerA.ForeColor = Color.Green;
                                break;
                            case 'B':
                                radioButtonB.Checked = true;
                                radioButtonB.ForeColor = Color.Green;
                                lblAnswerB.ForeColor = Color.Green;
                                break;
                            case 'C':
                                radioButtonC.Checked = true;
                                radioButtonC.ForeColor = Color.Green;
                                lblAnswerC.ForeColor = Color.Green;
                                break;
                            case 'D':
                                radioButtonD.Checked = true;
                                radioButtonD.ForeColor = Color.Green;
                                lblAnswerD.ForeColor = Color.Green;
                                break;
                            default:
                                MessageBox.Show("There is some error here! no Selection Question");
                                break;
                        }

                    }
                }
            }
        }

        private void LoadAnswerWithSuitableQuestion(int questionId)
        {
            if (questionId <= 0)
            {
                MessageBox.Show("Error ID! with ID less than or equal zero is not a suitable ID");
            }

        }

        private void LoadTrueFalseQuestionAndAnswer(TrueFalseQuestion question)
        {
            DisableRadioButtonTrueFalse();
            ResetLabelColorForTrueFalse();
            if (question != null & question is TrueFalseQuestion)
            {
                labelTrueFalseQuestionText.Text = question.QuestionText;
                TrueFalseAnswer ans = question.Answer;
                if (ans.IsTrue)
                {
                    radioButtonTrue.Checked = true;
                    labelAnswerTrue.ForeColor = Color.Green;
                }
                else
                {
                    radioButtonFalse.Checked = true;
                    labelAnswerFalse.ForeColor = Color.Green;
                }
            }
        }

        private void DisableRadioButtonTrueFalse()
        {
            radioButtonFalse.Enabled = false;
            radioButtonTrue.Enabled = false;
        }

        private void ResetLabelColorForTrueFalse()
        {
            foreach (var rb in new[] { labelAnswerFalse, labelAnswerTrue })
            {
                rb.ForeColor = SystemColors.ControlText;
            }
        }

        private void LoadOpenEndedQuestionAndAnswer(OpenQuestion question)
        {
            labelOpenQuestionText.Text = question.QuestionText;
            listBoxOpenAns.Items.Clear();
            for (int i = 0; i < question.Answers.Count; i++)
            {
                OpenAnswer ans = question.Answers[i];
                listBoxOpenAns.Items.Add("#" + (i + 1) + " : " + ans.AnswerText);
            }
        }

        private void HandleTabAnswerControl()
        {

        }
        private void listQuestsions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var question = GetSelectedQuestion<Question>();
            if (question == null) return;
            switch (question)
            {
                case MultipleChoiceQuestion mcq:
                    tabAnswerControl.SelectedTab = tabPageMCAnswers;
                    LoadMultipleChoiceQuestionAndAnswer(mcq);
                    break;

                case OpenQuestion openQ:
                    tabAnswerControl.SelectedTab = tabPageOEAnswers;
                    LoadOpenEndedQuestionAndAnswer(openQ);
                    break;

                case TrueFalseQuestion tfq:
                    tabAnswerControl.SelectedTab = tabPageTFAnswers;
                    LoadTrueFalseQuestionAndAnswer(tfq);
                    break;

                default:
                    MessageBox.Show("Unsupported question type.");
                    break;
            }

        }

        private void editMCQuestionBtn_Click(object sender, EventArgs e)
        {
            var question = GetSelectedQuestion<MultipleChoiceQuestion>();
            if (question != null)
            {
                var multipleChoiceControl = new MultipleChoiceControl(_answerSerivce, _questionService, _provider, question, _parentForm.GoBack, false);
                _parentForm.LoadControl(multipleChoiceControl);
            }
            else
            {
                MessageBox.Show("Please choose a question to edit!");
            }
        }

        private void CreateQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void editTFQuestion_Click(object sender, EventArgs e)
        {
            var question = GetSelectedQuestion<TrueFalseQuestion>();
            if (question != null)
            {
                var trueFalseQuestionControl = new TrueFalseQuestionControl(_trueFalseQuestionService, _trueFalseAnswerService, _provider, question, _parentForm.GoBack, false);
                _parentForm.LoadControl(trueFalseQuestionControl);
            }
            else
            {
                MessageBox.Show("Please choose a question to edit!");
            }
        }

        private void editOpenQuestion_Click(object sender, EventArgs e)
        {
            var question = GetSelectedQuestion<OpenQuestion>();
            if (question != null)
            {
                var openQuestionControl = new OpenQuestionControl(_openQuestionService, _openAnswerService, _provider, question, _parentForm.GoBack, false);
                _parentForm.LoadControl(openQuestionControl);
            }
            else
            {
                MessageBox.Show("Please choose a question to edit!");
            }
        }

        private void nextBtnQuestion_Click(object sender, EventArgs e)
        {
            int index = listQuestions.SelectedIndex;

            // increase index
            index += 1;

            // if more than the total of question, reset into 0
            if (index >= listQuestions.Items.Count)
            {
                index = 0;
            }

            listQuestions.SetSelected(index, true);
            labelIndexOfQuestion.Text = "#" + (index += 1).ToString();
        }

        private void previousBtnQuestion_Click(object sender, EventArgs e)
        {
            int index = listQuestions.SelectedIndex;


            index -= 1;


            if (index < 0)
            {
                index = listQuestions.Items.Count - 1;
            }

            listQuestions.SetSelected(index, true);
            labelIndexOfQuestion.Text = "#" + (index += 1).ToString();
        }
    }
}

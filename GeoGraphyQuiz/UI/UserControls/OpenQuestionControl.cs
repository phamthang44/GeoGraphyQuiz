using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Service;
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
    public partial class OpenQuestionControl : UserControl
    {
        private readonly OpenQuestionService _openQuestionService;
        private readonly OpenAnswerService _openAnswerService;
        private readonly IServiceProvider _provider;
        private OpenQuestion _question;
        private readonly Action _goBackCallback;
        private bool _isCreatingNew = false;

        public OpenQuestionControl(OpenQuestionService openQuestionService, OpenAnswerService openAnswerService, IServiceProvider serviceProvider, OpenQuestion question, Action goCallBack, bool isCreatingNew)
        {
            _openQuestionService = openQuestionService;
            _openAnswerService = openAnswerService;
            _provider = serviceProvider;
            _question = question;
            _goBackCallback = goCallBack;
            _isCreatingNew = isCreatingNew;
            InitializeComponent();
            ResetUIListQuestion();

            HandleQuestionLoadFromOtherPage();
        }

        private void HandleQuestionLoadFromOtherPage()
        {
            if (_isCreatingNew)
            {
                comboBoxCreateUpdateMode.SelectedIndex = 0;
                labelListQuestions.Visible = false;
                HandleCreateMode();
            }
            else
            {
                if (_question != null)
                {
                    labelListQuestions.Visible = true;
                    comboBoxCreateUpdateMode.SelectedIndex = 1;
                    HandleUpdateMode();
                    for (int i = 0; i < listBoxQuestions.Items.Count; i++)
                    {
                        if (listBoxQuestions.Items[i].Equals(_question))
                        {
                            listBoxQuestions.SelectedIndex = i;
                        }
                    }

                }
            }
        }

        private void HandleUpdateMode()
        {
            _isCreatingNew = false;
            ResetUIListQuestion();
            labelListQuestions.Visible = true;
            listBoxQuestions.Show();
        }

        private void HandleCreateMode()
        {
            _isCreatingNew = true;
            inputQuestionText.Text = string.Empty;
            flowLayoutPanel.Controls.Clear();
            labelListQuestions.Visible = false;
            listBoxQuestions.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = inputQuestionText.Text.Trim();
                if (string.IsNullOrWhiteSpace(questionText))
                {
                    MessageBox.Show("Please enter a question.");
                    return;
                }
                if (_isCreatingNew)
                {
                    _question = null;
                    var question = new OpenQuestion
                    {
                        QuestionText = questionText,
                        Answers = new List<OpenAnswer> { }
                    };
                    bool hasMainAnswer = false;
                    foreach (Control item in flowLayoutPanel.Controls)
                    {
                        if (item is Panel panel)
                        {
                            var txt = panel.Controls.OfType<TextBox>().FirstOrDefault();
                            var rdo = panel.Controls.OfType<RadioButton>().FirstOrDefault();

                            string answerText = txt?.Text.Trim();
                            bool isMain = rdo?.Checked ?? false;

                            if (!string.IsNullOrWhiteSpace(answerText))
                            {
                                question.Answers.Add(new OpenAnswer
                                {
                                    AnswerText = answerText,
                                    IsMainAnswer = isMain
                                });

                                if (isMain) hasMainAnswer = true;
                            }
                            else
                            {
                                MessageBox.Show("There is an empty answer input");
                                return;
                            }
                        }
                    }
                    if (question.Answers.Count == 0)
                    {
                        MessageBox.Show("Please add at least one answer.");
                        return;
                    }

                    if (!hasMainAnswer)
                    {
                        MessageBox.Show("Please select one main answer.");
                        return;
                    }

                    _openQuestionService.CreateQuestion(question);
                    MessageBox.Show("Saved successfully.");
                    ResetUIListQuestion();
                    SwitchModeUpdateAfterCreate();
                }
                else
                {
                    _question = GetSelectedQuestion<OpenQuestion>();
                    if (_question == null)
                    {
                        MessageBox.Show("You didn't choose any question yet!");
                        return;
                    }
                    _question.QuestionText = questionText;
                    bool hasMainAnswer = false;
                    var newAnswerList = new List<OpenAnswer>(); //new list from UI

                    foreach (Control item in flowLayoutPanel.Controls)
                    {
                        if (item is Panel panel)
                        {
                            var txt = panel.Controls.OfType<TextBox>().FirstOrDefault();
                            var rdo = panel.Controls.OfType<RadioButton>().FirstOrDefault();

                            string answerText = txt?.Text.Trim();
                            bool isMain = rdo?.Checked ?? false;

                            if (string.IsNullOrWhiteSpace(answerText))
                            {
                                MessageBox.Show("There is an empty answer input");
                                return;
                            }

                            if (panel.Tag is OpenAnswer existingAnswer)
                            {
                                // Update the data of existing answer
                                existingAnswer.AnswerText = answerText;
                                existingAnswer.IsMainAnswer = isMain;
                                newAnswerList.Add(existingAnswer);
                            }
                            else
                            {
                                // Here is new answer (because Tag == null)
                                var newAnswer = new OpenAnswer
                                {
                                    AnswerText = answerText,
                                    IsMainAnswer = isMain
                                };
                                newAnswerList.Add(newAnswer);
                            }

                            if (isMain) hasMainAnswer = true;
                        }
                    }

                    if (!newAnswerList.Any())
                    {
                        MessageBox.Show("Please add at least one answer.");
                        return;
                    }

                    if (!hasMainAnswer)
                    {
                        MessageBox.Show("Please select one main answer.");
                        return;
                    }

                    // compare to old list to find which answer is removed
                    var removedAnswers = _question.Answers
                        .Where(oldAnswer => !newAnswerList.Any(newAns => newAns.AnswerUID == oldAnswer.AnswerUID))
                        .ToList();

                    foreach (var removed in removedAnswers)
                    {
                        _question.Answers.Remove(removed);
                        _openAnswerService.DeleteAnswerById(removed.Id);
                    }

                    // update the list with new one
                    _question.Answers = newAnswerList;

                    // Call the update
                    _openQuestionService.UpdateQuestion(_question);
                    MessageBox.Show("Updated successfully.");
                    ResetUIListQuestion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SwitchModeUpdateAfterCreate()
        {
            inputQuestionText.Text = string.Empty;
            flowLayoutPanel.Controls.Clear();
            _isCreatingNew = false;
            listBoxQuestions.Show();
            comboBoxCreateUpdateMode.SelectedIndex = 1;
        }

        private void ResetUIListQuestion()
        {
            listBoxQuestions.Items.Clear();

            List<OpenQuestion> opens = _openQuestionService.GetAllQuestions();
            if (opens.IsNullOrEmpty())
            {
                MessageBox.Show("No question exists in the database!");
            }

            foreach (var question in opens)
            {
                listBoxQuestions.Items.Add(question);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _goBackCallback?.Invoke();
        }
        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            if (inputQuestionText.Text.Trim().Length == 0)
            {
                MessageBox.Show("You haven't enter the question yet!");
                return;
            }

            Panel answerPanel = new Panel();
            answerPanel.Size = new Size(710, 52);
            answerPanel.BackColor = Color.Cyan;
            answerPanel.Location = new Point(3, 3);

            TextBox txtAnswer = new TextBox();
            txtAnswer.Width = 464;
            txtAnswer.Height = 37;
            txtAnswer.Font = new Font("Segoe UI", 11F);


            RadioButton rdoMain = new RadioButton();
            rdoMain.Text = "Main answer";
            rdoMain.AutoSize = true;
            rdoMain.CheckedChanged += (s, args) =>
            {
                // Logic: Nếu checked, uncheck tất cả các RadioButton khác
                if (rdoMain.Checked)
                {
                    foreach (Control item in flowLayoutPanel.Controls)
                    {
                        if (item is Panel p)
                        {
                            foreach (var radio in p.Controls.OfType<RadioButton>())
                            {
                                if (radio != rdoMain)
                                    radio.Checked = false;
                            }
                        }
                    }
                }
            };

            // Nút X để xóa đáp án
            Button btnDelete = new Button();
            btnDelete.Text = "X";
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Width = 40;
            btnDelete.Height = 40;
            btnDelete.Click += (s, args) =>
            {
                flowLayoutPanel.Controls.Remove(answerPanel);
            };

            // Add các control vào panel
            answerPanel.Controls.Add(txtAnswer);
            answerPanel.Controls.Add(rdoMain);
            answerPanel.Controls.Add(btnDelete);

            // Set vị trí cho đẹp
            txtAnswer.Location = new Point(0, 3);
            rdoMain.Location = new Point(txtAnswer.Right + 10, 6);
            btnDelete.Location = new Point(rdoMain.Right + 10, 3);

            // Thêm panel vào FlowLayoutPanel
            flowLayoutPanel.Controls.Add(answerPanel);
        }

        private T GetSelectedQuestion<T>() where T : class
        {
            return listBoxQuestions.SelectedItem as T;
        }


        private void LoadAnswersOfSelectedQuestion(OpenQuestion question)
        {
            flowLayoutPanel.Controls.Clear();
            if (question != null)
            {
                foreach (var answer in question.Answers)
                {
                    Panel answerPanel = new Panel();
                    answerPanel.Size = new Size(710, 52);
                    answerPanel.BackColor = Color.Cyan;
                    answerPanel.Location = new Point(3, 3);
                    answerPanel.Tag = answer;

                    TextBox txtAnswer = new TextBox();
                    txtAnswer.Width = 464;
                    txtAnswer.Height = 37;
                    txtAnswer.Font = new Font("Segoe UI", 11F);
                    txtAnswer.Text = answer.AnswerText;

                    RadioButton rdoMain = new RadioButton();
                    rdoMain.Text = "Main answer";
                    rdoMain.AutoSize = true;
                    rdoMain.Checked = answer.IsMainAnswer;
                    rdoMain.CheckedChanged += (s, args) =>
                    {
                        if (rdoMain.Checked)
                        {
                            foreach (Control item in flowLayoutPanel.Controls)
                            {
                                if (item is Panel p)
                                {
                                    foreach (var radio in p.Controls.OfType<RadioButton>())
                                    {
                                        if (radio != rdoMain)
                                            radio.Checked = false;
                                    }
                                }
                            }
                        }
                    };
                    Button btnDelete = new Button();
                    btnDelete.Text = "X";
                    btnDelete.BackColor = Color.Red;
                    btnDelete.ForeColor = Color.White;
                    btnDelete.Width = 40;
                    btnDelete.Height = 40;
                    btnDelete.Click += (s, args) =>
                    {
                        flowLayoutPanel.Controls.Remove(answerPanel);
                    };
                    answerPanel.Controls.Add(txtAnswer);
                    answerPanel.Controls.Add(rdoMain);
                    answerPanel.Controls.Add(btnDelete);

                    txtAnswer.Location = new Point(0, 3);
                    rdoMain.Location = new Point(txtAnswer.Right + 10, 6);
                    btnDelete.Location = new Point(rdoMain.Right + 10, 3);

                    flowLayoutPanel.Controls.Add(answerPanel);
                }
            }
        }
        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

            _question = GetSelectedQuestion<OpenQuestion>();
            if (_question != null) 
            {
                LoadAnswersOfSelectedQuestion(_question);
                inputQuestionText.Text = _question.QuestionText;
            }
        }

        private void comboBoxCreateUpdateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCreateUpdateMode.SelectedIndex == 0)
            {
                HandleCreateMode();
            } else
            {
                HandleUpdateMode();
            }
        }
    }
}

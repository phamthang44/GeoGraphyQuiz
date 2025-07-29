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
using GeoGraphyQuiz.Model;
using System.Reflection.Metadata.Ecma335;
using GeoGraphyQuiz.UI.PlayGameControls;

namespace GeoGraphyQuiz.UI
{
    public partial class PlayGameForm : Form
    {
        private readonly IServiceProvider _provider;
        private readonly MultipleChoiceQuestionService _multipleChoiceQuestionService;
        private readonly TrueFalseQuestionService _trueFalseQuestionService;
        private readonly OpenQuestionService _openQuestionService;
        private List<Question> correctQuestions;
        private List<UserAnswer> tempUserAnswers = new List<UserAnswer>();
        private UserControl currentControl;
        private System.Windows.Forms.Timer quizTimer;
        private TimeSpan elapsedTime;
        public PlayGameForm(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
            _multipleChoiceQuestionService = _provider.GetRequiredService<MultipleChoiceQuestionService>();
            _trueFalseQuestionService = _provider.GetRequiredService<TrueFalseQuestionService>();
            _openQuestionService = _provider.GetRequiredService<OpenQuestionService>();
            LoadAllQuestions();
            listBoxQuestion.SelectedIndex = 0;
            InitializeTimer();
            listBoxQuestion.Enabled = false;
        }

        private void exitAndBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = _provider.GetRequiredService<MainForm>();
            mainForm.Show();
        }

        private void listBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentControl is IPlayableControl playable)
            {
                var answer = playable.GetUserAnswer();
                if (answer != null)
                {
                    SaveOrUpdateUserAnswer(answer);
                }
            }

            var question = GetSelectedQuestion<Question>();
            if (question != null)
            {
                QuestionTextLabel.Text = question.QuestionText;
                string indexOfQuestion = "#" + (listBoxQuestion.SelectedIndex + 1) + " /" + listBoxQuestion.Items.Count;
                numberOfQuestion.Text = indexOfQuestion;
                if (question != null)
                {

                    UserControl newControl = null;
                    switch (question)
                    {
                        case MultipleChoiceQuestion mcq:
                            newControl = new MultipleChoicePlayGameControl(mcq, tempUserAnswers);
                            break;
                        case TrueFalseQuestion tfq:
                            newControl = new TrueFalsePlayGameControl(tfq, tempUserAnswers);
                            break;
                        case OpenQuestion opq:
                            newControl = new OpenEndPlayGameControl(opq, tempUserAnswers);
                            break;
                    }
                    if (newControl != null)
                    {
                        mainPanelAnswer.Controls.Clear();
                        mainPanelAnswer.Controls.Add(newControl);
                        currentControl = newControl;
                    }
                }
            }
        }

        private void SaveOrUpdateUserAnswer(UserAnswer newAnswer)
        {
            var existing = tempUserAnswers.FirstOrDefault(a => a.Id == newAnswer.Id);
            if (existing != null)
                existing.Answer = newAnswer.Answer;
            else
                tempUserAnswers.Add(newAnswer);
        }

        private T GetSelectedQuestion<T>() where T : class
        {
            return listBoxQuestion.SelectedItem as T;
        }

        private void LoadAllQuestions()
        {
            listBoxQuestion.Items.Clear();
            var mq = _multipleChoiceQuestionService.GetAllQuestions();
            var tf = _trueFalseQuestionService.GetAllQuestions();
            var oq = _openQuestionService.GetAllQuestions();
            List<Question> questions = mq.Cast<Question>().Concat(tf).Concat(oq).ToList();
            correctQuestions = questions;
            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                listBoxQuestion.Items.Add(question);
            }
        }

        private void QuestionTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int index = listBoxQuestion.SelectedIndex;
       
            index++;

            if (index >= listBoxQuestion.Items.Count - 1)
            {
                index = listBoxQuestion.Items.Count - 1;
                nextBtn.Enabled = false; // Disable 
            }

            listBoxQuestion.SetSelected(index, true);
            string indexOfQuestion = "#" + (index + 1) + " /" + listBoxQuestion.Items.Count;
            numberOfQuestion.Text = indexOfQuestion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizTimer.Stop();
            var resultForm = new ResultsForm(tempUserAnswers, correctQuestions, elapsedTime, _provider);
            resultForm.Show();
        }

        private void InitializeTimer()
        {
            elapsedTime = TimeSpan.Zero;

            quizTimer = new System.Windows.Forms.Timer();
            quizTimer.Interval = 1000; 
            quizTimer.Tick += QuizTimer_Tick;
            quizTimer.Start();
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
        }
    }
}

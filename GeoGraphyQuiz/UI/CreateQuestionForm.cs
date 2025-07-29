using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Service;
using GeoGraphyQuiz.UI.UserControls;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GeoGraphyQuiz.UI
{
    public partial class CreateQuestionForm : Form
    {

        private readonly IServiceProvider _provider;
        private Stack<UserControl> navigationHistory = new Stack<UserControl>();
        public CreateQuestionForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _provider = serviceProvider;
            LoadControl(new MainMenuCreateQuestionControl(_provider, this));
        }

        public void LoadControl(UserControl control)
        {
            if (parentPanel.Controls.Count > 0)
            {
                navigationHistory.Push((UserControl)parentPanel.Controls[0]);
            }

            parentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(control);
        }

        public void GoBack()
        {
            if (navigationHistory.Count > 0)
            {
                var previous = navigationHistory.Pop();
                parentPanel.Controls.Clear();
                previous.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(previous);
                
                if (previous is MainMenuCreateQuestionControl mainMenu)
                {
                    mainMenu.ReloadQuestions();
                }
            }
        }

        private void CreateQuestionForm_Load(object sender, EventArgs e)
        {

        }


    }
}

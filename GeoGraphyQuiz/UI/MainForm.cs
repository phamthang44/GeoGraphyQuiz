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

namespace GeoGraphyQuiz.UI
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _provider;
        public MainForm(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
        }
        private void CreateQuestionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createForm = _provider.GetRequiredService<CreateQuestionForm>();
            createForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayGameBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var playGameForm = new PlayGameForm(_provider);
            playGameForm.Show();
        }
    }
}

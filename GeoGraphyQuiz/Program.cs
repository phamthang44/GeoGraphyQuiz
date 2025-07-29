using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms; // cần thêm dòng này để dùng MessageBox
using GeoGraphyQuiz.UI;
using GeoGraphyQuiz.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GeoGraphyQuiz.Service;
using GeoGraphyQuiz.Repository;
using GeoGraphyQuiz.UI.UserControls;
using GeoGraphyQuiz.Repository.IRepository;
using GeoGraphyQuiz.Service.Implements;

namespace GeoGraphyQuiz
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            // 1. Load configuration from appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // 2. Create DI container
            var services = new ServiceCollection();

            // 3. Register DbContext with SQL Server
            services.AddDbContext<QuizDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // 4. Register form and repositories
            services.AddScoped<MainForm>();
            services.AddScoped<CreateQuestionForm>();
            services.AddScoped<MultipleChoiceControl>();
            services.AddScoped<ConfirmMessageBox>();
            services.AddScoped<PlayGameForm>();

            // Multiple choice question
            services.AddScoped<IMultipleChoiceRepository, MCQuestionRepository>();
            services.AddScoped<IMultipleChoiceAnswerRepository, MultipleChoiceAnswerRepository>();
            services.AddScoped<MultipleChoiceQuestionService, MultipleChoiceQuestionServiceImpl>();
            services.AddScoped<MultipleChoiceAnswerService, MultipleChoiceAnswerServiceImpl>();
            // True False question
            services.AddScoped<ITrueFalseAnswerRepository, TrueFalseAnswerRepository>();
            services.AddScoped<ITrueFalseQuestionRepository, TrueFalseQuestionRepository>();
            services.AddScoped<TrueFalseAnswerService, TrueFalseAnswerServiceImpl>();
            services.AddScoped<TrueFalseQuestionService, TrueFalseQuestionServiceImpl>();
            // Open End question
            services.AddScoped<IOpenQuestionRepository, OpenQuestionRepository>();
            services.AddScoped<IOpenAnswerRepository, OpenAnswerRepository>();
            services.AddScoped<OpenAnswerService, OpenAnswerServiceImpl>();
            services.AddScoped<OpenQuestionService, OpenQuestionServiceImpl>();

            // 5. Build provider
            var provider = services.BuildServiceProvider();

            // 6. Test database connection
            using (var scope = provider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<QuizDbContext>();
            }

            // 7. Run the application
            ApplicationConfiguration.Initialize();
            var mainForm = provider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
            //ApplicationConfiguration.Initialize();
            //var createQuestionForm = provider.GetRequiredService<CreateQuestionForm>();
            //Application.Run(createQuestionForm);
        }
    }
}

using GeoGraphyQuiz.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace GeoGraphyQuiz.Data
{
    public class QuizDbContext : DbContext
    {
        public DbSet<MultipleChoiceQuestion> MCQuestions { get; set; }
        public DbSet<MultipleChoiceAnswer> MCAnswers { get; set; }

        public DbSet<TrueFalseQuestion> TFQuestions { get; set; }
        public DbSet<TrueFalseAnswer> TFAnswers { get; set; }

        public DbSet<OpenQuestion> OpenQuestions { get; set; }
        public DbSet<OpenAnswer> OpenAnswers { get; set; }

        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MultipleChoiceQuestion>(entity =>
            {
                entity.ToTable("mcquestion");

                entity.HasKey(q => q.Id);

                entity.Property(q => q.Id).HasColumnName("id");
                entity.Property(q => q.QuestionText).HasColumnName("question_text");

                entity.HasMany(q => q.Options)
                      .WithOne(a => a.Question)
                      .HasForeignKey(a => a.QuestionId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<MultipleChoiceAnswer>(entity =>
            {
                entity.ToTable("mcanswer");

                entity.HasKey(a => a.Id);

                entity.Property(a => a.Id).HasColumnName("id");
                entity.Property(a => a.QuestionId).HasColumnName("question_id");
                entity.Property(a => a.OptionLabel).HasColumnName("option_label");
                entity.Property(a => a.OptionText).HasColumnName("option_text");
                entity.Property(a => a.IsCorrect).HasColumnName("is_correct");
            });

            modelBuilder.Entity<TrueFalseQuestion>(entity =>
            {
                entity.ToTable("tfquestion");
                entity.HasKey(q => q.Id);
                entity.Property(q => q.Id).HasColumnName("id");
                entity.Property(q => q.QuestionText).HasColumnName("question_text");
                entity.HasOne(q => q.Answer)
                      .WithOne(a => a.TrueFalseQuestion)
                      .HasForeignKey<TrueFalseAnswer>(a => a.QuestionId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TrueFalseAnswer>(entity =>
            {
                entity.ToTable("tfanswer");
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Id).HasColumnName("id");
                entity.Property(a => a.QuestionId).HasColumnName("question_id");
                entity.Property(a => a.IsTrue).HasColumnName("is_true");
            });

            modelBuilder.Entity<OpenQuestion>(entity =>
            {
                entity.ToTable("openquestion");
                entity.HasKey(q => q.Id);
                entity.Property(q => q.Id).HasColumnName("id");
                entity.Property(q => q.QuestionText).HasColumnName("question_text");
                entity.HasMany(q => q.Answers)
                      .WithOne(a => a.OpenQuestion)
                      .HasForeignKey(a => a.QuestionId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<OpenAnswer>(entity =>
            {
                entity.ToTable("openanswer");
                entity.HasKey(a => a.Id);

                entity.Property(a => a.Id).HasColumnName("id");
                entity.Property(a => a.QuestionId).HasColumnName("question_id");
                entity.Property(a => a.AnswerText).HasColumnName("answer_text");
                entity.Property(a => a.IsMainAnswer).HasColumnName("is_main_answer");
            });
        }
        public  static string GetConnectionString(string connectionStringName)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString = configuration.GetConnectionString(connectionStringName);
            return connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlServer(GetConnectionString("DefaultConnection")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        
    }
}

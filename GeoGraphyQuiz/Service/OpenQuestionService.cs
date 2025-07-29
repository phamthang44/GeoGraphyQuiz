using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service
{
    public interface OpenQuestionService
    {
        void CreateQuestion(OpenQuestion question);
        OpenQuestion GetQuestionById(int id);
        List<OpenQuestion> GetAllQuestions();

        void DeleteQuestion(int id);

        void UpdateQuestion(OpenQuestion question);
    }
}

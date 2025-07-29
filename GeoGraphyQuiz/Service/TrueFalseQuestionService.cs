using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service
{
    public interface TrueFalseQuestionService
    {
        void CreateQuestion(TrueFalseQuestion question);
        TrueFalseQuestion GetQuestionById(int id);
        List<TrueFalseQuestion> GetAllQuestions();

        void DeleteQuestion(int id);

        void UpdateQuestion(TrueFalseQuestion question);
    }
}

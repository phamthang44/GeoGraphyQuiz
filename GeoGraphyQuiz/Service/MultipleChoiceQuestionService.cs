using GeoGraphyQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoGraphyQuiz.Model;

namespace GeoGraphyQuiz.Service
{
    public interface MultipleChoiceQuestionService
    {
        void CreateQuestion(MultipleChoiceQuestion question);
        MultipleChoiceQuestion GetQuestionById(int id);
        List<MultipleChoiceQuestion> GetAllQuestions();

        void DeleteQuestion(int id);

        void UpdateQuestion(MultipleChoiceQuestion question);

    }
}

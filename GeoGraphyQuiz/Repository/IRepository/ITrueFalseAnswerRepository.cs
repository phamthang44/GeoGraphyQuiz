using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Repository.IRepository
{
    public interface ITrueFalseAnswerRepository
    {
        List<TrueFalseAnswer> GetAnswersByQuestionId(int questionId);
        TrueFalseAnswer? GetById(int id);
        void Add(TrueFalseAnswer answer);
        void Update(TrueFalseAnswer answer);
        void Delete(int id);
    }
}

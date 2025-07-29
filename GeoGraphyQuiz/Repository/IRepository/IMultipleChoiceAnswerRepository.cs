using GeoGraphyQuiz.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Repository.IRepository
{
    public interface IMultipleChoiceAnswerRepository
    {
        List<MultipleChoiceAnswer> GetAnswersByQuestionId(int questionId);
        MultipleChoiceAnswer? GetById(int id);
        void Add(MultipleChoiceAnswer answer);
        void Update(MultipleChoiceAnswer answer);
        void Delete(int id);

    }
}

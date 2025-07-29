using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Repository.IRepository
{
    public interface IOpenAnswerRepository
    {
        List<OpenAnswer> GetAnswersByQuestionId(int questionId);
        OpenAnswer? GetById(int id);
        void Add(OpenAnswer answer);
        void Update(OpenAnswer answer);
        void Delete(int id);
    }
}

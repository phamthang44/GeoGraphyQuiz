using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Repository.IRepository
{
    public interface ITrueFalseQuestionRepository
    {
        List<TrueFalseQuestion> GetAll();
        TrueFalseQuestion? GetById(int id);
        void Add(TrueFalseQuestion question);
        void Update(TrueFalseQuestion question);
        void Delete(int id);
    }
}

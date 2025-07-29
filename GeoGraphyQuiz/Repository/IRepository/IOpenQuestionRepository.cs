using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Repository.IRepository
{
    public interface IOpenQuestionRepository
    {
        List<OpenQuestion> GetAll();
        OpenQuestion? GetById(int id);
        void Add(OpenQuestion question);
        void Update(OpenQuestion question);
        void Delete(int id);
    }
}

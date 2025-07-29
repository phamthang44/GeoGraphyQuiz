using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GeoGraphyQuiz.Repository.IRepository
{
    public interface IMultipleChoiceRepository
    {
        List<MultipleChoiceQuestion> GetAll();
        MultipleChoiceQuestion? GetById(int id);
        void Add(MultipleChoiceQuestion question);
        void Update(MultipleChoiceQuestion question);
        void Delete(int id);
    }
}

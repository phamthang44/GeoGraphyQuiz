using GeoGraphyQuiz.Data;
using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Repository
{
    public class TrueFalseAnswerRepository : ITrueFalseAnswerRepository
    {
        private readonly QuizDbContext _context;

        public TrueFalseAnswerRepository(QuizDbContext context)
        {
            _context = context;
        }

        public void Add(TrueFalseAnswer answer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TrueFalseAnswer> GetAnswersByQuestionId(int questionId)
        {
            return _context.TFAnswers
                .Where(a => a.QuestionId == questionId)
                .ToList();
        }

        public TrueFalseAnswer? GetById(int id)
        {
            return _context.TFAnswers
                .FirstOrDefault(a => a.Id == id);
        }

        public void Update(TrueFalseAnswer answer)
        {
            throw new NotImplementedException();
        }
    }
}

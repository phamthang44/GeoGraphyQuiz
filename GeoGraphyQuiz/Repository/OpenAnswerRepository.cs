using GeoGraphyQuiz.Data;
using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Repository
{
    public class OpenAnswerRepository : IOpenAnswerRepository
    {
        private readonly QuizDbContext _context;

        public OpenAnswerRepository(QuizDbContext context)
        {
            _context = context;
        }
        public List<OpenAnswer> GetAnswersByQuestionId(int questionId)
        {
            return _context.OpenAnswers
                .Where(a => a.QuestionId == questionId)
                .ToList();
        }

        public OpenAnswer? GetById(int id)
        {
            return _context.OpenAnswers
                .FirstOrDefault(a => a.Id == id);
        }

        public void Add(OpenAnswer answer)
        {
            _context.OpenAnswers.Add(answer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var answer = _context.OpenAnswers.Find(id);
            if (answer != null)
            {
                _context.OpenAnswers.Remove(answer);
                _context.SaveChanges();
            }
        }

        public void Update(OpenAnswer answer)
        {
            _context.OpenAnswers.Update(answer);
            _context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoGraphyQuiz.Data;
using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace GeoGraphyQuiz.Repository
{
    public class MultipleChoiceAnswerRepository : IMultipleChoiceAnswerRepository
    {
        private readonly QuizDbContext _context;

        public MultipleChoiceAnswerRepository(QuizDbContext context)
        {
            _context = context;
        }

        public List<MultipleChoiceAnswer> GetAnswersByQuestionId(int questionId)
        {
            return _context.MCAnswers
                .Where(a => a.QuestionId == questionId)
                .ToList();
        }

        public MultipleChoiceAnswer? GetById(int id)
        {
            return _context.MCAnswers
                .FirstOrDefault(a => a.Id == id);
        }

        public void Add(MultipleChoiceAnswer answer)
        {
            _context.MCAnswers.Add(answer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var answer = _context.MCAnswers.Find(id);
            if (answer != null)
            {
                _context.MCAnswers.Remove(answer);
                _context.SaveChanges();
            }
        }

        public void Update(MultipleChoiceAnswer answer)
        {
            _context.MCAnswers.Update(answer);
            _context.SaveChanges();
        }
    }
}

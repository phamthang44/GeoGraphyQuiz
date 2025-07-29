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
    public class MCQuestionRepository : IMultipleChoiceRepository
    {
        private readonly QuizDbContext _context;

        public MCQuestionRepository(QuizDbContext context)
        {
            _context = context;
        }

        public List<MultipleChoiceQuestion> GetAll()
        {
            return _context.MCQuestions
                .Include(q => q.Options)
                .ToList();
        }

        public MultipleChoiceQuestion? GetById(int id)
        {
            return _context.MCQuestions
                .Include(q => q.Options)
                .FirstOrDefault(q => q.Id == id);
        }

        public void Add(MultipleChoiceQuestion question)
        { 
            try
            {
                _context.MCQuestions.Add(question);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("DbUpdateException: " + ex.InnerException?.Message ?? ex.Message);
            }
        }

        public void Update(MultipleChoiceQuestion question)
        {
            _context.MCQuestions.Update(question);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var question = _context.MCQuestions.Find(id);
            if (question != null)
            {
                _context.MCQuestions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}

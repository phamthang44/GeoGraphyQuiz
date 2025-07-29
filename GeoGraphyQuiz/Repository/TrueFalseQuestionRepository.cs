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
    internal class TrueFalseQuestionRepository : ITrueFalseQuestionRepository
    {
        private readonly QuizDbContext _context;

        public TrueFalseQuestionRepository(QuizDbContext context)
        {
            _context = context;
        }
        public List<TrueFalseQuestion> GetAll()
        {
            return _context.TFQuestions
                .Include(q => q.Answer)
                .ToList();
        }
        public TrueFalseQuestion? GetById(int id)
        {
            return _context.TFQuestions
                .Include(q => q.Answer)
                .FirstOrDefault(q => q.Id == id);
        }
        public void Add(TrueFalseQuestion question)
        {
            try
            {
                _context.TFQuestions.Add(question);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("DbUpdateException: " + ex.InnerException?.Message ?? ex.Message);
            }
        }
        public void Update(TrueFalseQuestion question)
        {
            var tracked = _context.ChangeTracker.Entries<TrueFalseQuestion>()
                            .FirstOrDefault(e => e.Entity.Id == question.Id);

            if (tracked != null)
                _context.Entry(tracked.Entity).State = EntityState.Detached;

            _context.TFQuestions.Update(question);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var question = _context.TFQuestions.Find(id);
            if (question != null)
            {
                _context.TFQuestions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}

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
    public class OpenQuestionRepository : IOpenQuestionRepository
    {
        private readonly QuizDbContext _context;
        public OpenQuestionRepository(QuizDbContext context)
        {
            _context = context;
        }
        public void Add(OpenQuestion question)
        {
            try
            {
                _context.OpenQuestions.Add(question);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("DbUpdateException: " + ex.InnerException?.Message ?? ex.Message);
            }
        }

        public void Delete(int id)
        {
            var question = _context.OpenQuestions.Find(id);
            if (question != null)
            {
                _context.OpenQuestions.Remove(question);
                _context.SaveChanges();
            }
        }

        public List<OpenQuestion> GetAll()
        {
            return _context.OpenQuestions
                .Include(q => q.Answers)
                .ToList();
        }

        public OpenQuestion? GetById(int id)
        {
            return _context.OpenQuestions
                .Include(q => q.Answers)
                .FirstOrDefault(q => q.Id == id);
        }

        public void Update(OpenQuestion question)
        {
            var tracked = _context.ChangeTracker.Entries<OpenQuestion>()
                            .FirstOrDefault(e => e.Entity.Id == question.Id);

            if (tracked != null)
                _context.Entry(tracked.Entity).State = EntityState.Detached;
            _context.OpenQuestions.Update(question);
            _context.SaveChanges();
        }
    }
}

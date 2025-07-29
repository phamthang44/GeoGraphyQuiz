using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service.Implements
{
    public class OpenAnswerServiceImpl : OpenAnswerService
    {
        private readonly IOpenAnswerRepository _openAnswerRepository;

        public OpenAnswerServiceImpl(IOpenAnswerRepository openAnswerRepository)
        {
            _openAnswerRepository = openAnswerRepository;
        }

        public List<OpenAnswer> GetAnswerByQuestionId(int questionId)
        {
            if (questionId < 0)
            {
                throw new ArgumentException("This question id is less than zero");
            }

            List<OpenAnswer> ansList = _openAnswerRepository.GetAnswersByQuestionId(questionId);
            if (ansList == null)
            {
                throw new Exception("There is no answers available for this question");
            }
            return ansList;
        }

        public void DeleteAnswerById(int id)
        {
            var answer = _openAnswerRepository.GetById(id);
            if (answer != null)
            {
                _openAnswerRepository.Delete(answer.Id);
            } else
            {
                throw new Exception("Not found this answer in database");
            }
        }
    }
}

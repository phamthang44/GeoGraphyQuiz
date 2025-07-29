using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service.Implements
{
    public class TrueFalseQuestionServiceImpl : TrueFalseQuestionService
    {
        private readonly ITrueFalseQuestionRepository _trueFalseQuestionRepo;
        public TrueFalseQuestionServiceImpl(ITrueFalseQuestionRepository trueFalseQuestionRepository)
        {
            _trueFalseQuestionRepo = trueFalseQuestionRepository;
        }

        public void CreateQuestion(TrueFalseQuestion question)
        {
            if (question == null)
            {
                throw new Exception("Question must not be null or empty");
            }
            if (question.QuestionText.Trim().Length == 0)
            {
                throw new Exception("Invalid input question: " + question.QuestionText);
            }
            if (question.Answer == null)
            {
                throw new Exception("This question hasn't had an input answers!");
            }
            _trueFalseQuestionRepo.Add(question);
        }

        public void DeleteQuestion(int id)
        {
            if (id < 0)
            {
                throw new Exception("Bad Id. The id must be greater than zero");
            }
            try
            {
                _trueFalseQuestionRepo.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot delete this question, Reason: " + ex.Message);
            }
        }

        public List<TrueFalseQuestion> GetAllQuestions()
        {
            return _trueFalseQuestionRepo.GetAll();
        }

        public TrueFalseQuestion GetQuestionById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("id");
            }

            TrueFalseQuestion question = _trueFalseQuestionRepo.GetById(id);
            if (question == null)
            {
                throw new Exception("This question does not exist in Database");
            }
            return question;
        }

        public void UpdateQuestion(TrueFalseQuestion question)
        {
            if (question == null)
            {
                throw new Exception("Question must not be null or empty");
            }
            if (question.QuestionText.Trim().Length == 0)
            {
                throw new Exception("Invalid input question: " + question.QuestionText);
            }
            if (question.Answer == null)
            {
                throw new Exception("This question hasn't had an input answers!");
            }
            try
            {
                if (question != null)
                {
                    _trueFalseQuestionRepo.Update(question);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoGraphyQuiz.Model;
using System.Windows.Forms.VisualStyles;
using GeoGraphyQuiz.Repository.IRepository;

namespace GeoGraphyQuiz.Service.Implements
{
    public class MultipleChoiceQuestionServiceImpl : MultipleChoiceQuestionService
    {
        private readonly IMultipleChoiceRepository _multipleChoiceRepository;

        public MultipleChoiceQuestionServiceImpl(IMultipleChoiceRepository multipleChoiceRepository)
        {
            _multipleChoiceRepository = multipleChoiceRepository;
        }

        public void CreateQuestion(MultipleChoiceQuestion question)
        {
            if (question == null)
            {
                throw new Exception("Question must not be null or empty");
            }
            if (question.QuestionText.Trim().Length == 0)
            {
                throw new Exception("The question is empty or null!");
            }
            if (question.Options == null)
            {
                throw new Exception("This question still not has any answers");
            }
            foreach (var item in question.Options)
            {
                if (item.OptionText.Trim().Length == 0) 
                {
                    throw new Exception("The answer text is empty");
                }
            }

            _multipleChoiceRepository.Add(question);

        }

        public MultipleChoiceQuestion GetQuestionById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("id");
            }

            MultipleChoiceQuestion question = _multipleChoiceRepository.GetById(id);
            if (question == null)
            {
                throw new Exception("This question does not exist in Database");
            }
            return question;
        }

        public List<MultipleChoiceQuestion> GetAllQuestions()
        {
            return _multipleChoiceRepository.GetAll();
        }

        public void DeleteQuestion(int id)
        {
            if (id < 0)
            {
                throw new Exception("Bad Id. The id must be greater than zero");
            }
            try
            {
                _multipleChoiceRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot delete this question, Reason: " + ex.Message);
            }
        }
        public void UpdateQuestion(MultipleChoiceQuestion question)
        {
            if (question == null)
            {
                throw new Exception("Question must not be null or empty");
            }
            if (question.QuestionText.Trim().Length == 0)
            {
                throw new Exception("The question is empty or null!");
            }
            if (question.Options == null)
            {
                throw new Exception("This question still not has any answers");
            }
            foreach (var item in question.Options)
            {
                if (item.OptionText.Trim().Length == 0)
                {
                    throw new Exception("The answer text is empty");
                }
            }
            try
            {
                if (question != null)
                {
                    _multipleChoiceRepository.Update(question);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

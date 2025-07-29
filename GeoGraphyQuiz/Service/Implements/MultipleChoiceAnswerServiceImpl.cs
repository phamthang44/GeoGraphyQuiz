using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service.Implements
{
    public class MultipleChoiceAnswerServiceImpl : MultipleChoiceAnswerService
    {
        private readonly IMultipleChoiceAnswerRepository _multipleChoiceAnswerRepository;

        public MultipleChoiceAnswerServiceImpl(IMultipleChoiceAnswerRepository multipleChoiceAnswerRepository)
        {
            _multipleChoiceAnswerRepository = multipleChoiceAnswerRepository;
        }

        public MultipleChoiceAnswer CreateAnswer(MultipleChoiceAnswer ans)
        {
            if (ans == null)
            {
                throw new Exception("Answer information is empty");
            }

            if (ans.OptionText.Length == 0)
            {
                throw new Exception("Answer text is empty");
            }
            if (ans.IsCorrect != true || ans.IsCorrect != false)
            {
                throw new Exception("There is no correct answer input!");
            }

            _multipleChoiceAnswerRepository.Add(ans);
            MultipleChoiceAnswer newAns = _multipleChoiceAnswerRepository.GetById(ans.Id);
            return newAns;
        }
        public List<MultipleChoiceAnswer> GetMultipleChoiceAnswersByQuestionId(int questionId)
        {
            if (questionId < 0)
            {
                throw new ArgumentException("Index is less than 0!");
            }
            List<MultipleChoiceAnswer> ansList = _multipleChoiceAnswerRepository.GetAnswersByQuestionId(questionId);
            if (ansList == null)
            {
                throw new NullReferenceException("The list of answer which is store in Question with Id: " + questionId + " is null");

            }
            return ansList;
        }
    }
}

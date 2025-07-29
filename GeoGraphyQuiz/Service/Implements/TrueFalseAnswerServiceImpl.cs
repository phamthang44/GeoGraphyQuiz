using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service.Implements
{
    public class TrueFalseAnswerServiceImpl : TrueFalseAnswerService
    {
        private readonly ITrueFalseAnswerRepository _trueFalseAnswerRepository;

        public TrueFalseAnswerServiceImpl(ITrueFalseAnswerRepository trueFalseAnswerRepository)
        {
            _trueFalseAnswerRepository = trueFalseAnswerRepository;
        }

        public TrueFalseAnswer CreateAnswer(TrueFalseAnswer ans)
        {
            if (ans == null)
            {
                throw new Exception("Answer information is empty");
            }


            if (ans.IsTrue != true || ans.IsTrue != false)
            {
                throw new Exception("There is no correct answer input!");
            }

            _trueFalseAnswerRepository.Add(ans);
            TrueFalseAnswer newAns = _trueFalseAnswerRepository.GetById(ans.Id);
            return newAns;
        }

        public TrueFalseAnswer GetAnswerByQuestionId(int questionId)
        {
            if (questionId < 0)
            {
                throw new ArgumentException("Index is less than 0!");
            }
            TrueFalseAnswer ans = _trueFalseAnswerRepository.GetById(questionId);
            if (ans == null)
            {
                throw new NullReferenceException("The list of answer which is store in Question with Id: " + questionId + " is null");

            }
            return ans;
        }
    }
}

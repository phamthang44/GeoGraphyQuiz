using GeoGraphyQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoGraphyQuiz.Model;
namespace GeoGraphyQuiz.Service
{
    public interface MultipleChoiceAnswerService
    {
        MultipleChoiceAnswer CreateAnswer(MultipleChoiceAnswer ans);
        List<MultipleChoiceAnswer> GetMultipleChoiceAnswersByQuestionId(int questionId);

    }
}

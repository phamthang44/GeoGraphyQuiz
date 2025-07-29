using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service
{
    public interface TrueFalseAnswerService
    {
        TrueFalseAnswer CreateAnswer(TrueFalseAnswer ans);
        TrueFalseAnswer GetAnswerByQuestionId(int questionId);
    }
}

using GeoGraphyQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service
{
    public interface OpenAnswerService
    {
        List<OpenAnswer> GetAnswerByQuestionId(int questionId);
        void DeleteAnswerById(int id);
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    public class TrueFalseAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }

        public bool IsTrue { get; set; }
        
        public TrueFalseAnswer(int questionId, bool isTrue)
        {
            QuestionId = questionId;
            IsTrue = isTrue;
        }

        public TrueFalseQuestion? TrueFalseQuestion { get; set; }

        public TrueFalseAnswer() { }

        public override string? ToString()
        {
            return IsTrue.ToString();
        }
    }
}

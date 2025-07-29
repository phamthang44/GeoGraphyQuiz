using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(int id, string questionText, TrueFalseAnswer answer) : base(id, questionText)
        {
            Answer = answer;
        }

        public TrueFalseAnswer Answer { get; set; }
        public TrueFalseQuestion() { }

        public override string ToString()
        {
            return base.ToString() + " [True False]";
        }

        public bool CheckAnswer(bool userChoice)
        {
            return userChoice == Answer.IsTrue;
        }
    }
}

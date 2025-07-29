using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GeoGraphyQuiz.Model
{
    public class MultipleChoiceQuestion : Question
    {
        public MultipleChoiceQuestion(int id, string questionText, List<MultipleChoiceAnswer> answers) : base(id, questionText)
        {
            Options = answers;
        }

        public MultipleChoiceQuestion() { }

        public List<MultipleChoiceAnswer> Options { get; set; } // A, B, C, D

        public override string ToString()
        {
            return base.ToString() + " [Multiple Choice]";
        }

        public bool CheckAnswer(MultipleChoiceAnswer ans)
        {
            return Options.Any(opt => opt.Id.Equals(ans.Id) && opt.IsCorrect);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    public class MultipleChoiceAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public char OptionLabel { get; set; } // 'A', 'B', ...
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; }

        public MultipleChoiceQuestion Question { get; set; }

        public MultipleChoiceAnswer() { }

        public MultipleChoiceAnswer(int questionId, char label, string text, bool isCorrect)
        {
            QuestionId = questionId;
            OptionLabel = label;
            OptionText = text;
            IsCorrect = isCorrect;
        }

        public override string? ToString()
        {
            return OptionText;
        }
    }
}

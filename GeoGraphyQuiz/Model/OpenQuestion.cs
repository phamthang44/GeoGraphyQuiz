using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    
    public class OpenQuestion : Question
    {
        public List<OpenAnswer> Answers { get; set; }
        public OpenQuestion(int id, string questionText, List<OpenAnswer> answers) : base(id, questionText)
        {
            Answers = answers;
        }
        public OpenQuestion() { }

        public override string ToString()
        {
            return base.ToString() + " [Open-ended Question]";
        }

        public bool CheckAnswer(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer)) return false;

            string normalizedUserInput = Normalize(userAnswer);

            return Answers
                .Any(a => Normalize(a.AnswerText) == normalizedUserInput);
        }

        private string Normalize(string input)
        {
            return new string(input
                .ToLowerInvariant()
                .Where(c => !char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}

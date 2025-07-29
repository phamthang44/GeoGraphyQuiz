using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    public class OpenAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool IsMainAnswer { get; set; }
        public OpenQuestion? OpenQuestion { get; set; }

        public OpenAnswer() { }

        public OpenAnswer(int questionId, string answerText, bool isMainAnswer) 
        {
            QuestionId = questionId;
            AnswerText = answerText;
            IsMainAnswer = isMainAnswer;
        }

        [NotMapped]
        public Guid AnswerUID { get; set; } = Guid.NewGuid();

        public override string? ToString()
        {
            return AnswerText;
        }
    }
}

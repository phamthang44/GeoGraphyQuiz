using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    [NotMapped]
    public class UserAnswerResult<T>
    {
        public Guid QuestionId { get; set; }
        public T UserAnswer { get; set; }
        public T CorrectAnswer { get; set; }
        public bool IsCorrect => EqualityComparer<T>.Default.Equals(UserAnswer, CorrectAnswer);
    }
}

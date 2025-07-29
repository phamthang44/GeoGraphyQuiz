using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    public abstract class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }


        public Question(int id, string questionText)
        {
            Id = id;
            QuestionText = questionText;
        }
        public Question() { }

        public override string ToString()
        {
            return QuestionText;
        }

    }
}

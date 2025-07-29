using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Model
{
    [NotMapped]
    public class UserAnswer
    {
        public int Id { get; set; }
        public object Answer { get; set; }

        public override string? ToString()
        {
            return Answer.ToString();
        }
    }


}

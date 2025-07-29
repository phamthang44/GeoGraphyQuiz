using GeoGraphyQuiz.Model;
using GeoGraphyQuiz.Repository.IRepository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoGraphyQuiz.Service.Implements
{
    public class OpenQuestionServiceImpl : OpenQuestionService
    {
        private readonly IOpenQuestionRepository _openQuestionRepository;

        public OpenQuestionServiceImpl(IOpenQuestionRepository openQuestionRepository)
        {
            _openQuestionRepository = openQuestionRepository;
        }

        public void CreateQuestion(OpenQuestion question)
        {
            if (question == null)
            {
                throw new Exception("The input is null!");
            }
            if (question.QuestionText.Trim().Length == 0)
            {
                throw new Exception("Invalid input question: " + question.QuestionText);
            }
            if (question.Answers.IsNullOrEmpty())
            {
                throw new Exception("There is answers input for this question: [" + question.QuestionText + "], Please input answers");
            }
            foreach (var answer in question.Answers)
            {
                if (answer.AnswerText.Trim().Length == 0)
                {
                    throw new Exception("Invalid input answer in this question: " + question.QuestionText);
                }
            }

            _openQuestionRepository.Add(question);
        }

        public void DeleteQuestion(int id)
        {
            if (id < 0) throw new Exception("Invalid question!");
            var question = _openQuestionRepository.GetById(id);
            if (question == null) throw new Exception("There is no question found with this id");
            _openQuestionRepository.Delete(id);
        }

        public List<OpenQuestion> GetAllQuestions()
        {
            List<OpenQuestion> questions = _openQuestionRepository.GetAll();
            if (questions == null)
            {
                throw new Exception("There are no questions exist in the database");
            }
            return questions;
        }

        public OpenQuestion GetQuestionById(int id)
        {
            if (id < 0)
            {
                throw new Exception("Invalid id of question: [" + id +"]");
            }
            OpenQuestion response = _openQuestionRepository.GetById(id);
            if (response == null)
            {
                throw new Exception("There is no question with this id : [" + id + "]");
            }
            return response;
        }

        public void UpdateQuestion(OpenQuestion question)
        {
            if (question == null)
            {
                throw new Exception("The input is null!");
            }
            if (question.QuestionText.Trim().Length == 0)
            {
                throw new Exception("Invalid input question: " + question.QuestionText);
            }
            if (question.Answers.IsNullOrEmpty())
            {
                throw new Exception("There is answers input for this question: [" + question.QuestionText + "], Please input answers");
            }
            foreach (var answer in question.Answers)
            {
                if (answer.AnswerText.Trim().Length == 0)
                {
                    throw new Exception("Invalid input answer in this question: " + question.QuestionText);
                }
            }

            _openQuestionRepository.Update(question);
        }
    }
}

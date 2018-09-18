﻿using System.Collections.Generic;
using System.Linq;

namespace OnlineQuizClasses.QuizManagement
{
    public class QuizHandler
    {
        private QuizContext _context = new QuizContext();
        public List<Quiz> GetAllQuizzes()
        {
            using (_context)
            {
                return (from v in _context.Quizzes select v).ToList();
            }
        }

        public Quiz GetQuizId(string name)
        {
            using (_context)
            {
                return (from c in _context.Quizzes where c.QuizTitle == name select c).FirstOrDefault();
            }
        }

        public Quiz GetQuizById(int i)
        {
            using (_context)
            {
                return (from c in _context.Quizzes where c.Id == i select c).FirstOrDefault();
            }
        }

        public List<Question> GetAllQuestion()
        {
            using (_context)
            {
                return (from c in _context.Questions select c).ToList();
            }
        }
    }
}
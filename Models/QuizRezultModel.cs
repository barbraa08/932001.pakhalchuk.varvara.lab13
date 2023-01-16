using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task13.Models;

namespace task13.Models
{
    public class QuizResultModel
    {
        public List<QuizQuestionModel> Questions { get; set; }

        public int CorrectAnswerCount
        {
            get
            {
                return Questions.Count(q => q.AnswerIsCorrect);
            }
        }

        public int Count => Questions.Count;
    }
}
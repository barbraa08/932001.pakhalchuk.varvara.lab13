using task13.Utils;

namespace task13.Models
{
    public class QuizAnswerModel
    {
        [LessThanOrNull(101, ErrorMessage = "The number is bigger than it is allowed.")]
        public int? Answer { get; set; }
    }
}
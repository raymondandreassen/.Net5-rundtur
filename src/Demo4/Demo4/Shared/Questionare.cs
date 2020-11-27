using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Shared
{
    public class Questionare
    {
        [Key]
        public int QuestId { get; set; }
        public string DisplayName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }

    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionString { get; set; }
        public string QuestionDescription { get; set; }
        public List<AnswerAlteratives> AnswerAlternatives { get; set; } = new List<AnswerAlteratives>();
    }

    public class AnswerAlteratives
    {
        [Key]
        public int AnswerAlternative { get; set; }
        public string Answer { get; set; }
    }
}

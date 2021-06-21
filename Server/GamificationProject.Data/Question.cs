using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamificationProject.Data
{
    public enum DifficultyLevel
    {
        Easy = 1,
        Normal = 2,
        Hard = 3
    }

    [Table("Questions")]
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string QuestionName { get; set; }

        public DifficultyLevel Difficulty { get; set; }

        public virtual ICollection<Choice> Choices { get; set; }

    }
}

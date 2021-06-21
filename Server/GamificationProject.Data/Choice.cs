using GamificationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GamificationProject.Data
{
    [Table("Choices")]
    public class Choice : Simple
    {
        public int QuestionId { get; set; }

        [MaxLength(256)]
        public string ChoiceName { get; set; }

        public bool Right { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
    }
}

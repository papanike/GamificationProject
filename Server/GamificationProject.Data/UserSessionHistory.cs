using GamificationProject.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamificationProject.Data
{ 
    [Table("UserSessionHistory")]
    public class UserSessionHistory : Simple
    {
        public int UserId { get; set; }

        public DateTime LoggedTime { get; set; }

        public int PointsGained { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}

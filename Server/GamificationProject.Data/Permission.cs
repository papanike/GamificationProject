using GamificationProject.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamificationProject.Data
{
    public class Permission : Simple
    {
        [Required]
        [MaxLength(256)]
        public string Description { get; set; }

        [Required]
        public bool Active { get; set; }

        public string OperationsOnEntitiesJson { get; set; }

        [NotMapped]
        public Dictionary<string, Dictionary<string, bool>> OperationsOnEntities { get; set; }
    }
}

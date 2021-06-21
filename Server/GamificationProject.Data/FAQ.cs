using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GamificationProject.Data
{
    [Table("FAQs")]
    public class FAQ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(256)]
        public string Question { get; set; }

        [MaxLength(256)]
        public string Answer { get; set; }
    }
}

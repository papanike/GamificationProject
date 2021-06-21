using GamificationProject.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamificationProject.Data
{
    [Table("Users")]
    public class User : Simple, ISecureUser
    {
        [MaxLength(64)]
        public string FirstName { get; set; }

        [MaxLength(64)]
        public string LastName { get; set; }

        [MaxLength(64)]
        public string Email { get; set; }

        [MaxLength(64)]
        public string Username { get; set; }

        [NotMapped]
        public string Password { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        public int Points { get; set; }

        [MaxLength(32)]
        public string Status { get; set; }

        public bool Admin { get; set; }

        public virtual ICollection<UserSessionHistory> UserSessionHistories { get; set; }
    }
}

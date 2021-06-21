using GamificationProject.Interfaces;

namespace GamificationProject.Data
{
    public class AuthenticatedUser : Simple
    {
        public string Username { get; set; }
        public string Token { get; set; }
        //public Permission Permission { get; set; }
        public bool Admin { get; set; }
    }
}

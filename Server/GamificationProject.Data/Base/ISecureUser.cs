using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationProject.Interfaces
{
    public interface ISecureUser
    {
        byte[] PasswordHash { get; set; }
        byte[] PasswordSalt { get; set; }
    }
}

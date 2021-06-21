using GamificationProject.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationProject.Interfaces
{
    public interface ILoginService
    {
        AuthenticatedUser GetUser(int userId);
        AuthenticatedUser Login(AuthenticationRequest entity);
    }
}

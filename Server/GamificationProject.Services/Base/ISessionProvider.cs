using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationProject.Interfaces
{
    public interface ISessionProvider
    {
        ISession Session { get; }

        void Initialise(int? userId, object data = null);
    }

    public interface ISession
    {
        int? UserId { get; set; }
        object Data { get; set; }

        T GetData<T>() where T : class;
    }
}

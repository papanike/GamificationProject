using System;
using System.Collections.Generic;
using System.Text;

namespace GamificationProject.Interfaces
{
    public class SessionProvider : ISessionProvider
    {
        public ISession Session { get; private set; }

        public SessionProvider()
        {
            Session = new Session();
        }

        public void Initialise(int? userId, object data = null)
        {
            Session.UserId = userId;
            Session.Data = data;
        }
    }

    public class Session : ISession
    {
        public int? UserId { get; set; }
        public object Data { get; set; }

        public T GetData<T>() where T : class
        {
            return Data as T;
        }
    }
}


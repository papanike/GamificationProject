using GamificationProject.Data;
using GamificationProject.Interfaces;

namespace GamificationProject.Server.Services
{
    public class ChoiceService : SimpleService<Choice>
    {
        public ChoiceService(IRepository<Choice> repository, ISessionProvider sessionProvider) : base(repository, sessionProvider)
        {
        }
    }
}

namespace GamificationProject.Interfaces
{
    public interface ISimpleService<T> : IBaseService<T> where T : Simple
    {
        T Get(int id);
        void Delete(int id);
    }
}

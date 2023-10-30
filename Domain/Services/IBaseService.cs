using PocScheduler.Domain.Model;

namespace PocScheduler.Domain.Services
{
    public interface IBaseService<T> where T : BaseModel
    {
        void ExecuteSomeAction(T input);
    }
}
using PocScheduler.Domain.Model;
using PocScheduler.Domain.Services;

namespace PocScheduler.Domain.UseCase
{
    public class OneUseCase
    {
        private readonly IBaseService<OneModel> service;

        public OneUseCase(IBaseService<OneModel> service)
        {
            this.service = service;
        }

        public void Execute(OneModel input){
            service.ExecuteSomeAction(input);
        }

    }
}
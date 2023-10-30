using System.Text.Json;
using PocScheduler.Domain.Model;

namespace PocScheduler.Domain.Services
{
    public class OneService : IBaseService<OneModel>
    {
        public void ExecuteSomeAction(OneModel input)
        {
            var data = JsonSerializer.Serialize(input);
            Console.WriteLine("The input was : {0}", input);
        }
    }
}
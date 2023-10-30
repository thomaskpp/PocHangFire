using System.Text.Json;
using PocScheduler.Domain.Model;
using Quartz;

namespace PocScheduler.Domain.Jobs
{
    public abstract class BaseJob : IJob
    {
        public virtual Task Execute(IJobExecutionContext context)
        {
            var jobResult = new JobResult();
            Console.WriteLine("Job Executou => {0}", JsonSerializer.Serialize(jobResult));
            return Task.FromResult(jobResult);
        }
    }
}
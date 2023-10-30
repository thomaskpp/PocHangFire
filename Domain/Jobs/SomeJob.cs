using Quartz;

namespace PocScheduler.Domain.Jobs
{
    public class SomeJob : BaseJob
    {
        public string JobName { get; set; }
        public override Task Execute(IJobExecutionContext context)
        {
            //do JobStuffHere
            return base.Execute(context);
        }
    }
}
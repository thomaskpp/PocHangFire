using PocScheduler.Domain.Jobs;
using Quartz;
using Quartz.AspNetCore;

namespace PocScheduler.Config
{
    public static class Scheduler
    {
        public static IServiceCollection AddSchedulers(this IServiceCollection services)
        {
            services.AddQuartz(q =>
            {
                q.AddJob<SomeJob>(o => o.WithIdentity("SomeJob"));
                q.AddTrigger(t => t
                    .ForJob("SomeJob")
                    .WithIdentity("SomeJob-Trigger")
                    .WithCronSchedule("0 * * ? * *")
                );
            });
            services.AddQuartzServer(o => o.WaitForJobsToComplete = true);
            return services;
        }
    }
}
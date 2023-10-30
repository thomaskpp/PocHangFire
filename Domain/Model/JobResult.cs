namespace PocScheduler.Domain.Model
{
    public class JobResult
    {
        public Guid JobId { get; set; }
        public bool IsJobSuccess { get; set; }
        public string JobResultMessage { get; set; }

        public JobResult()
        {
            var rdm = new Random().NextInt64();
            JobId = Guid.NewGuid();
            IsJobSuccess = rdm % 128 == 0;
            JobResultMessage = rdm % 128 == 0 ? "Job Executado com Sucesso" : "Falha ao executar";
        }
    }
}
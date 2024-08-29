using FluentScheduler;

namespace TaskSchedule.Models
{
    public class SampleJob : IJob
    {
        public void Execute()
        {
            Console.WriteLine("Schedule 1");
        }
    }
}

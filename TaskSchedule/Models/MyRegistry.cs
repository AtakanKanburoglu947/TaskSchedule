using FluentScheduler;

namespace TaskSchedule.Models
{
    public class MyRegistry : Registry
    {
        public MyRegistry() { 
            Schedule<SampleJob>().ToRunNow().AndEvery(5).Seconds();
            Schedule(()=>Console.WriteLine("Schedule 2")).ToRunNow().AndEvery(2).Seconds();
            Schedule(()=>Console.WriteLine("Schedule 3")).ToRunNow().AndEvery(1).Months().OnTheFirst(DayOfWeek.Monday).At(14,0);
            Schedule(() => Console.WriteLine("Schedule 4")).ToRunEvery(5).Seconds();
        }
    }
}

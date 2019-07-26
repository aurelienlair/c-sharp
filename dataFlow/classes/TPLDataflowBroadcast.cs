using System;
using System.Threading.Tasks.Dataflow;

public class TPLDataflowBroadcast
{
    private BroadcastBlock<string> _jobs;

    public TPLDataflowBroadcast()
    {
        // The delegate 'job=>job' allows to transform the job, like Select in LINQ
        _jobs = new BroadcastBlock<string>(job => job);

        var act1 = new ActionBlock<string>((job) =>
        {
            Console.WriteLine($"Broadcast thread enqueuing job n°{job}");
        });

        var act2 = new ActionBlock<string>((job) =>
        {
            LogToFile(job);
        });

        // the jobs are enqueued in this order but that doesn't mean they will be consumed in that order!
        _jobs.LinkTo(act1);
        _jobs.LinkTo(act2);
    }

    private void LogToFile(string job)
    {
        Console.WriteLine($"Broadcast I am writing job n°{job} to the log file");
    }

    public void Enqueue(string job)
    {
        _jobs.Post(job);
    }
}
using System;
using System.Threading.Tasks.Dataflow;

public class TPLDataflowQueue
{
    private ActionBlock<string> _jobs;

    public TPLDataflowQueue()
    {
        // job is a parameter and its type is string
        _jobs = new ActionBlock<string>((job) =>
        {
            Console.WriteLine($"Single thread enqueuing job n°{job}");
        });
        
        // Same as 
        // _jobs = new ActionBlock<string>(job => Console.WriteLine(job));
    }

    public void Enqueue(string job)
    {
        _jobs.Post(job);
    }
}
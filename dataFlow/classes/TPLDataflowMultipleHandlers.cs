using System;
using System.Threading;
using System.Threading.Tasks.Dataflow;

public class TPLDataflowMultipleHandlers
{
    private ActionBlock<string> _jobs;

    public TPLDataflowMultipleHandlers()
    {
        var executionDataflowBlockOptions = new ExecutionDataflowBlockOptions()
        {
            MaxDegreeOfParallelism = 2,
        };

        _jobs = new ActionBlock<string>((job) =>
        {
            // sleep 0.1 seconds
            Thread.Sleep(10);
            // following is just for example's sake
            Console.WriteLine($"Multi thread enqueuing job n°{job}, thread: { Thread.CurrentThread.ManagedThreadId}");
        }, executionDataflowBlockOptions);
    }

    public void Enqueue(string job)
    {
        _jobs.Post(job);
    }
}
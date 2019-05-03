using System;

namespace TaskExecutionEngine.Tasks
{
    using Common;
    using Interfaces;

    public class SampleTask : IExecuteTask
    {
        public void ExecuteTask(BaseJobData JobData)
        {
            Console.WriteLine("Sample task completed");
        }
    }
}

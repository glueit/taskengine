namespace Client
{
    using TaskExecutionEngine;
    using TaskExecutionEngine.Common;
    using TaskExecutionEngine.Tasks;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var storage = new InMemoryBaseDataStorage();
            var task = new SampleTask();
            var data = new BaseJobData("sampleId", "smapleName");
            var engine = new TaskExecutionEngine(storage, task, data);

            // to start the task.
            engine.StartTask();

            // to get status of task.
            engine.GetStatus(data.ID);

        }
    }
}

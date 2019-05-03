namespace TaskExecutionEngine.Interfaces
{
    using Common;

    public interface IExecuteTask
    {
        void ExecuteTask(BaseJobData JobData);
    }
}

namespace TaskExecutionEngine.Interfaces
{
    using Common;

    public interface ITaskExecutionEngine
    {
        void StartTask(IExecuteTask task, BaseJobData baseJobDate);
        Progress GetStatus(string id);
        bool Cancel(string id);
        bool Restart(string id);
    }
}

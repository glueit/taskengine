namespace TaskExecutionEngine.Interfaces
{
    using Common;

    public interface IBaseStorage
    {
        void AddOrUpdate(BaseJobData jobData);

        BaseJobData GetData(string ID);
    }
}

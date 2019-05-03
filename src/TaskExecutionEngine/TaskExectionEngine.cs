namespace TaskExecutionEngine
{
    using Common;
    using Interfaces;
    using System;

    public class TaskExecutionEngine : ITaskExecutionEngine
    {
        private readonly IBaseStorage _storage;

        public TaskExecutionEngine(IBaseStorage storage)
        {
            _storage = storage;
        }

        public bool Cancel(string id)
        {
            throw new NotImplementedException();
        }

        public Progress GetStatus(string id)
        {
            BaseJobData data = _storage.GetData(id);
            return data.progress;
        }

        public bool Restart(string id)
        {
            throw new NotImplementedException();
        }

        public void StartTask(IExecuteTask task, BaseJobData baseJobDate)
        {
            // starts a new threat and executes the task.
            task.ExecuteTask(baseJobDate);
            _storage.AddOrUpdate(baseJobDate);
        }
    }
}


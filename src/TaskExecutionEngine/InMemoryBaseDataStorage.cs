namespace TaskExecutionEngine
{
    using System.Collections.Generic;
    using Common;
    using Interfaces;

    public class InMemoryBaseDataStorage:IBaseStorage
    {
        private Dictionary<string, BaseJobData> storage;
        public InMemoryBaseDataStorage()
        {
            storage = new Dictionary<string, BaseJobData>();
        }
        public void AddOrUpdate(BaseJobData jobData)
        {
            storage[jobData.ID] = jobData;
        }

        public BaseJobData GetData(string ID)
        {
            return storage[ID];
        }
    }
}

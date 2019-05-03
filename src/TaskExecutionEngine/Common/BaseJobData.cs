namespace TaskExecutionEngine.Common
{
    public class BaseJobData
    {
        public string ID;
        public string Name;
        public State state;
        public Progress progress;

        public BaseJobData(string ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}

namespace TaskManager.Models
{
    public class Task
    {
        public Task()
        {
            Done = false;
        }

        public Task(string description, bool done)
        {
            Description = description;
            Done = done;
        }

        public bool Done { get; set; }

        public string Description { get; set; }

        public void SwitchDoneCondition()
        {
            Done = !Done;
        }
    }
}
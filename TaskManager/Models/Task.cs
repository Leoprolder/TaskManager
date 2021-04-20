using System;

namespace TaskManager.Models
{
    public class Task
    {
        public Task(string description, bool done)
        {
            Description = description;
            Done = done;
            Id = new Guid().ToString();
        }

        public Task(string description)
            : this(description, false)
        {
        }

        public string Id { get; set; }

        public bool Done { get; set; }

        public string Description { get; set; }

        public void SwitchDoneCondition()
        {
            Done = !Done;
        }
    }
}
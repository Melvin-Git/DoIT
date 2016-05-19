using System;

namespace DoIT
{
    public class UserTask
    {
        // Properties

        // Index

        public int Index { get; set; }

        // Description

        public string Description { get; set; }

        // Deadline

        public DateTime Deadline { get; set; }

        // Priority

        public int Priority { get; set; }

        // Reminder

        public DateTime Reminder { get; set; }

        // Status

        public TaskStatus Status { get; set; }

        // Methods
        public UserTask()
        {
        }

        public UserTask(int index, string description, DateTime deadline, int priority, DateTime reminder, TaskStatus status)
        {
        }

        public void Remember()
        {
        }
    }
}
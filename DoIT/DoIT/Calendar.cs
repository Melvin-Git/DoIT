using System.Collections.Generic;

namespace DoIT
{
    public class Calendar
    {
        // Properties

        // Index

        public int Index { get; set; }

        // Name

        public string Name { get; set; }

        // Tasks

        public List<UserTask> Tasks { get; set; }

        // Methods
        public Calendar(string name)
        {
            Name = name;
        }

        public Calendar(string name, List<UserTask> tasks)
        {
            Name = name;
            Tasks = tasks;
        }
    }
}
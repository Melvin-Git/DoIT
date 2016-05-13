using System.Collections.Generic;

namespace DoIT
{
    public class Calendar
    {
        // Members
        private string m_Name;
        private List<UserTask> m_Tasks;

        // Methods
        public Calendar(string name)
        {
            setName(name);
        }

        public Calendar(string name, List<UserTask> tasks)
        {
            setName(name);
            setTasks(tasks);
        }

        // Properties

        // Name
        public string getName()
        {
            return m_Name;
        }

        public void setName(string value)
        {
            m_Name = value;
        }

        // Tasks
        public List<UserTask> getTasks()
        {
            return m_Tasks;
        }

        public void setTasks(List<UserTask> value)
        {
            m_Tasks = value;
        }
    }
}
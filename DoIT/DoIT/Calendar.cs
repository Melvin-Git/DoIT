using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIT
{
    public class Calendar
    {
        // Members
        private string m_Name;
        private List<UserTask> m_Tasks;

        // Methods
        public Calendar(string name) { }

        public Calendar(string name, List<UserTask> tasks)
        {
            this.setName(name);
            this.setTasks(tasks);
        }

        // Properties

        // Name
        public string getName()
        {
            return this.m_Name;
        }

        public void setName(string value)
        {
            this.m_Name = value;
        }

        // Tasks
        public List<UserTask> getTasks()
        {
            return this.m_Tasks;
        }

        public void setTasks(List<UserTask> value)
        {
            this.m_Tasks = value;
        }
    }
}

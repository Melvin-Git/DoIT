using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIT
{
    public class Checklist
    {
        // Members
        private List<UserTask> m_Tasks;

        // Methods
        public Checklist() { }

        public Checklist(List<UserTask> tasks)
        {
            this.setTasks(tasks);
        }

        // Properties

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

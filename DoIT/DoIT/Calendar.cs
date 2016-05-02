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
        private List<UserTask> m_OpenTasks;
        private List<UserTask> m_ClosedTasks;

        // Methods
        public Calendar() { }

        public Calendar(List<UserTask> tasks)
        {

        }

        // Properties

        // Properties for m_OpenTasks.
        public List<UserTask> getOpenTasks()
        {
            return this.m_OpenTasks;
        }

        public void setOpenTasks(List<UserTask> value)
        {
            this.m_OpenTasks = value;
        }

        // Properties for m_ClosedTasks.
        public List<UserTask> getClosedTasks()
        {
            return this.m_ClosedTasks;
        }

        public void setClosedTasks(List<UserTask> value)
        {
            this.m_ClosedTasks = value;
        }
    }
}

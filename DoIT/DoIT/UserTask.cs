using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIT
{
    public class UserTask
    {
        // Members
        private string m_Description;
        private DateTime m_Deadline;
        private int m_Priority;
        private DateTime m_Reminder;
        private TaskStatus m_Status;

        // Methods
        public UserTask() { }

        public UserTask(string description, DateTime deadline, int priority, DateTime reminder, TaskStatus status)
        {

        }

        public void Remember()
        {

        }        

        // Properties

        // Description
        public string getDescription()
        {
            return this.m_Description;
        }

        public void setDescription(string value)
        {
            this.m_Description = value;
        }

        // Deadline
        public DateTime getDeadline()
        {
            return this.m_Deadline;
        }

        public void setDeadline(DateTime value)
        {
            this.m_Deadline = value;
        }

        // Priority
        public int getPriority()
        {
            return this.m_Priority;
        }

        public void setPriority(int value)
        {
            this.m_Priority = value;
        }

        // Reminder
        public DateTime getReminder()
        {
            return this.m_Reminder;
        }

        public void setReminder(DateTime value)
        {
            this.m_Reminder = value;
        }

        // Done?
        public TaskStatus getDone()
        {
            return this.m_Status;
        }

        public void setDone(TaskStatus value)
        {
            this.m_Status = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIT
{
    public class User
    {
        // Members
        private string m_Username;
        private string m_Password;
        private List<UserTask> m_Tasks;
        private List<Calendar> m_Calendars = new List<Calendar>();
        private Checklist m_Checklist;

        // Methods
        public void AddTask()
        {

        }

        public void EditTask()
        {

        }

        public void DeleteTask()
        {

        }

        public void AddCalendar()
        {

        }

        public void RemoveCalendar()
        {

        }

        // Properties
        // Properties for m_Username.
        public string getUsername()
        {
            return this.m_Username;
        }

        public void setUsername(string value)
        {
            this.m_Username = value;
        }

        // Properties for m_Password.
        public string getPassword()
        {
            return this.m_Password;
        }

        public void setPassword(string value)
        {
            this.m_Password = value;
        }

        // Properties for m_Tasks.
        public List<UserTask> getTasks()
        {
            return this.m_Tasks;
        }

        private void setTasks(List<UserTask> value)
        {
            this.m_Tasks = value;
        }
        // Properties for m_Calendars.
        public List<Calendar> getCalendars()
        {
            return this.m_Calendars;
        }

        private void setCalendars(List<Calendar> value)
        {
            this.m_Calendars = value;
        }

        // Properties for m_Checklist.
        public Checklist getChecklist()
        {
            return this.m_Checklist;
        }

        public void setChecklist(Checklist value)
        {
            this.m_Checklist = value;
        }
    }
}

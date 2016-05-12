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

        // Methods
        public void AddTask(UserTask task)
        {
            m_Tasks.Add(task);
        }

        public UserTask EditTask(int index)
        {
            return m_Tasks[index];
        }

        public void DeleteTask(UserTask task)
        {
            m_Tasks.Remove(task);
        }

        public void AddCalendar(string name, string path)
        {
            Calendar Cal;

            if (path != null)
            {
                Cal = new Calendar(name, Program.DeserializeTasklist());
            }
            else
            {
                Cal = new Calendar(name);
            }

            m_Calendars.Add(Cal);
        }

        public void RemoveCalendar(Calendar calendar)
        {
            m_Calendars.Remove(calendar);

            if(m_Calendars.Count == 0)
            {
                AddCalendar("Calendar " + (m_Calendars.Count + 1).ToString(), null);
            }
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
    }
}

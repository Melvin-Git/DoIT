using System.Collections.Generic;

// ReSharper disable ConvertIfStatementToConditionalTernaryExpression

namespace DoIT
{
    public class User
    {
        // Constructor
        public User()
        {
            Calendars = new List<Calendar>();
        }

        // Properties
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Calendar> Calendars { get; set; }

        // Methods
        /*public void AddTask(UserTask task)
        {
            //Tasks.Add(task);
        }

        public UserTask EditTask(int index)
        {
            //return Tasks[index];
        }

        public void DeleteTask(UserTask task)
        {
            //Tasks.Remove(task);
        }*/

        public void AddCalendar(string name, string path)
        {
            Calendar cal;

            if (name == null)
            {
                name = "Calendar " + (Calendars.Count + 1);
            }

            if (path != null)
            {
                cal = new Calendar(name, Program.DeserializeTasklist());
            }
            else
            {
                cal = new Calendar(name);
            }

            cal.Index = (Calendars.Count);

            Calendars.Add(cal);
        }

        public void RemoveCalendar(Calendar calendar)
        {
            Calendars.Remove(calendar);

            if (Calendars.Count == 0)
            {
                AddCalendar("Calendar " + (Calendars.Count + 1), null);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace DoIT
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }

        public static List<User> Users = new List<User>();
        public static User ActiveUser = null;
        public static string[] DateTimeFormats = {"dd.MM.yyyy" , "HH:mm" , "dd.MM.yyyy , HH:mm"};

        public static List<UserTask> DeserializeTasklist()
        {
            var Tasklist = new List<UserTask>();

            // Code for deserialization of a tasklist when the Import Function is used.

            return Tasklist;
        }
    }
}

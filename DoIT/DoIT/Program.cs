using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static List<UserTask> DeserializeTasklist()
        {
            var Tasklist = new List<UserTask>();

            // Code for deserialization of a tasklist when the Import Function is used.

            return Tasklist;
        }
    }
}

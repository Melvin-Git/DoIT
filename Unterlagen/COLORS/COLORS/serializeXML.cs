using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLORS
{
    public class serializeXML
    {
        public serializeXML() { }

        public void serialize(User u)
        {
            if (u.rank <= 50)
            {
                frmScoreboard.users.Add(u);
            }

            // User Contains Rank, Name, Score and Profile Picture
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            var path = Application.StartupPath + "//leaderboard.xml";
            System.IO.FileStream file = System.IO.File.Create(path);            
            writer.Serialize(file, frmScoreboard.users); // frmScoreboard.users = static List<User>
            file.Close();
        }
    }
}

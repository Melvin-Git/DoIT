using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace COLORS
{
    public class deserializeXML
    {
        public deserializeXML() { }

        public void deserialize()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\leaderboard.xml"))
            {
                string path = Application.StartupPath + "\\leaderboard.xml";

                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

                StreamReader reader = new StreamReader(path);
                frmScoreboard.users = (List<User>)serializer.Deserialize(reader); //Deserializes XML to a List<User>
                reader.Close();
            }

            else
            {
                if (frmScoreboard.users.Count != 0)
                {
                    for (int i = frmScoreboard.users.Count() - 1; i >= 0; i--)
                    {
                        frmScoreboard.users.RemoveAt(i);
                    }
                }
            }
        }
    }
}

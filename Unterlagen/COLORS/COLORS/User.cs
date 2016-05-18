using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLORS
{
    [Serializable()]
    public class User
    {
        //Members
        public int rank;
        public string name;
        public int score;
        public byte[] Picture;

        //Constructors
        public User(string n, Image i)
        {
            name = n;
            Picture = imageToString(i);
        }

        public User()
        { }

        //Functions
        private byte[] imageToString(Image i)
        {
            MemoryStream ms = new MemoryStream();
            i.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            byte[] byteArray = ms.ToArray();

            return byteArray;
        }

        public Image stringToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Image p = Image.FromStream(ms);

            return p;
        }

        public void sort()
        {
            deserializeXML dsXML = new deserializeXML();
            dsXML.deserialize();
            if (frmScoreboard.users.Count != 0)
            {
                int countLargerScores = 0;
                foreach (User u in frmScoreboard.users)
                {
                    if (u.getScore() >= score)
                    {
                        countLargerScores++;
                    }
                }
                rank = countLargerScores + 1;

                foreach (User u in frmScoreboard.users)
                {
                    if (u.getRank() >= rank)
                    {
                        u.setRank(u.getRank() + 1);
                    }
                }
            }

            else
            {
                rank = 1;
            }
        }

        //Get-Set Methods
        public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }

        public int getScore()
        {
            return score;
        }

        public void setScore(int s)
        {
            score = s;
        }

        public byte[] getPicture()
        {
            return Picture;
        }

        public void setPicture(byte[] i)
        {
            Picture = i;
        }

        public int getRank()
        {
            return rank;
        }

        public void setRank(int r)
        {
            rank = r;
        }
    }
}

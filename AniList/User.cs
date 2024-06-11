using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AniList.UC;

namespace AniList
{
    public class User
    {
        public string Username, Password, Fname, Lname, Email, Sq1, Sq2, Sa1, Sa2, Name, Preferences, Plan;
        public Image Pic;
        public DateTime Joined;
        public int Animecount;
        public User(string username, string password, string fname, string lname, string email, string sq1, string sa1, string sq2, string sa2, Image pic, DateTime joined, string preferences,string plan)
        {
            Preferences = preferences;
            Name = $"{fname} {lname}";
            Username = username;
            Password = password;
            Fname = fname;
            Lname = lname;
            Email = email;
            Sq1 = sq1;
            Sq2 = sq2;
            Sa1 = sa1;
            Sa2 = sa2;
            Pic = pic;
            Joined = joined;
            Animecount = statsprofile.animecount(username);
            Plan = plan;
        }

    }
}

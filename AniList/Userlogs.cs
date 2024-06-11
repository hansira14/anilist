using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniList
{
    public class Userlogs
    {
        public string Username, Action;
        public int AnimeId;
        public DateTime Dt;
        public Anime Anime;
        public User User;
        public Userlogs(string username, int animeid, DateTime dt, string action, Anime ani)
        {
            Username = username;
            AnimeId = animeid;
            Dt = dt;
            Action = action;
            Anime = ani;
            User = retrieve.GetUser(username);
        }
    }
}

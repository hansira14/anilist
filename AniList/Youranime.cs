using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniList
{
    public class Youranime
    {
        public Anime anime;
        public string Username, Status;
        public int AnimeID;
        public double Score, Progress;
        public DateTime Started;
        public DateTime Finished;
        public Youranime(string username, int animeid, double score, double progress, DateTime stared, DateTime finished, string status, Anime b)
        {
            Username= username;
            AnimeID= animeid;
            Score= score;
            Status= status;
            Started= stared;
            Finished= finished;
            Progress= progress;
            if (b != null) anime = b;
            else anime = retrieve.GetAnime(animeid);
        }
    }
}

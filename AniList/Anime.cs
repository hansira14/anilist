
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniList
{
    public class Anime
    {
        public int AnimeId;
        public string Review, Title, English, Poster, Trailer, Type, Premiere, Genre, Studio, Status, Broadcast, Source, Synopsis, RelatedAnime, Theme, Demo;
        public double Rating, RatedBy, Rank, Popularity, Users, Duration, Episodes, Favorites, Completedcount, Watchingcount, Planscount,Pausedcount,Droppedcount, R10, R9, R8, R7, R6, R5, R4, R3,R2,R1;
        public DateTime Aired;
        public DateTime Ended;
        public Image Pic;
        

        public Anime(int animeId, string title, string englishTitle, string posterUrl, string trailerUrl,
            double rating, double ratedBy, double rank, double popularity, double users, string type, string premiere,
            string genre, string studio, double episodes, string status, DateTime aired, DateTime ended,
            string broadcast, string source, double duration, double favorites, string synopsis, string relatedAnime,string theme, string demo,
            double completedcount, double watchingcount, double planscount, double pausedcount, double droppedcount, double r10, double r9, double r8, double r7, double r6, double r5, double r4, double r3, double r2, double r1, Image img,string review)
        {
            AnimeId = animeId;
            Title = title;
            English = englishTitle;
            Poster = posterUrl;
            Trailer = trailerUrl;
            Rating = rating;
            RatedBy = ratedBy;
            Rank = rank;
            Popularity = popularity;
            Users = users;
            Type = type;
            Premiere = premiere;
            Genre = genre;
            Studio = studio;
            Episodes = episodes;
            Status = status;
            Aired = aired;
            Ended = ended;
            Broadcast = broadcast;
            Source = source;
            Duration = duration;
            Favorites = favorites;
            Synopsis = synopsis;
            RelatedAnime = relatedAnime;
            Theme = theme;
            Demo = demo;
            Completedcount = completedcount;
            Watchingcount = watchingcount;
            Planscount = planscount;
            Pausedcount = pausedcount;
            Droppedcount = droppedcount;
            R1 = r1;
            R2 = r2;
            R3 = r3;
            R4 = r4;
            R5 = r5;
            R6 = r6;
            R7 = r7;
            R8 = r8;
            R9 = r9;
            R10 = r10;
            Pic = img;
            Review = review;
        }
    }

}

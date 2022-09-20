/*1.Create a console project
2. Creat a entity movie(movieid, moviename, year, lang, actor, director)
3.create a List of Movies and add the list of movies to movielist txt file.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace FileHandlingAssing
{
    internal class file
    {
        static void Main()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie(){MovieId = 1, Year = 2000, Moviename= "abc", Lang = "eng", Actor = "srk", Director = "RS" },
                new Movie(){MovieId = 2, Year = 2001, Moviename= "xyz", Lang = "hindi", Actor = "salman", Director = "slm" }

            };

            using (StreamWriter sw = new StreamWriter(@"D:\VisualStudioDotNet\Batch913\FileHandlingAssing\\MovieList.txt", true))
            {
                foreach (Movie m in movies)
                {
                    sw.WriteLine($"MovieID:{m.movieid}, MovieName:{m.moviename}, Language:{m.lang}, Year:{m.year}, Actor:{m.actor}, Director:{m.director}");
                }
            }
        }
    }

    class Movie
    {
        public int movieid, year;
        public string moviename, lang, actor, director;

        public Movie() { }
        public Movie(int movieid, int year, string moviename, string lang, string actor, string director)
        {
            this.movieid = movieid;
            this.year = year;
            this.moviename = moviename;
            this.lang = lang;
            this.actor = actor;
            this.director = director;
        }
        //public override string ToString()
        //{
        //    return $"MovieID:{movieid}, MovieName:{moviename}, Language:{lang}, Year:{year}, Actor:{actor}, Director:{director}";
        //}

        public int MovieId { get { return movieid; } set { movieid = value; } }
        public int Year { get { return year; } set { year = value; } }

        public string Moviename { get { return moviename; } set { moviename = value; } }
        public string Lang { get { return lang; } set { lang = value; } }
        public string Actor { get { return actor; } set { actor = value; } }
        public string Director { get { return director; } set { director = value; } }   
    }
}

/*
1.Create a console project
2. Creat a class movie(movieid, moviename, year, lang, actor, director
3.serialize and deserialize the movie class using binary and xml serialization and deserialization */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace SerializationAssing
{
    [Serializable]
    public class Movie
    {
        public int MovieId, year;
        public string MovieName, Lang, Actor, Director;
    }
    class file
    {
        public static void binaryserialization(List<Movie> lm)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"D:\VisualStudioDotNet\Batch913\SerializationAssing\movie.bat", FileMode.Create, FileAccess.Write))
            {
                binaryFormatter.Serialize(fs, lm);
            }
        }

        public static List<Movie> binarydeserialization()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"D:\VisualStudioDotNet\Batch913\SerializationAssing\movie.bat", FileMode.Open, FileAccess.Read))
            {
                List<Movie> lm = binaryFormatter.Deserialize(fs) as List<Movie>;
                return lm;
            }
        }

        public static void xmlserialization1(List<Movie> lm)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>));
            using (FileStream stream = new FileStream(@"D:\VisualStudioDotNet\Batch913\SerializationAssing\movie.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, lm);
            }
        }

        public static List<Movie> xmldeserialization1()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Movie>));
            using (FileStream fs = new FileStream(@"D:\VisualStudioDotNet\Batch913\SerializationAssing\movie.xml", FileMode.Open, FileAccess.Read))
            {
                List<Movie> lm = xmlSerializer.Deserialize(fs) as List<Movie>;
                return lm;
            }
        }

        public static void print(List<Movie> Mlist)
        {
            foreach (Movie movie in Mlist)
            {

                Console.WriteLine($"MovieID: {movie.MovieId} Movie Name: {movie.MovieName} Movie Year: {movie.year} Movie language: {movie.Lang} Movie Actor: {movie.Actor} Movie Director: {movie.Director}\n");
            }
        }

        static void Main(string[] args)
        {
            List<Movie> Mlist = new List<Movie>();
            Console.Write("Enter the number of Movies: ");
            int id, yr, n = int.Parse(Console.ReadLine());
            string na, l, a, d;
            for (int i = 0; i < n; i++)
            {
                Movie m1 = new Movie();
                Console.Write("Enter the Movie Id: ");
                m1.MovieId = int.Parse(Console.ReadLine());
                Console.Write("Enter the Movie Name: ");
                m1.MovieName = Console.ReadLine();
                Console.Write("Enter the Movie Year: ");
                m1.year = int.Parse(Console.ReadLine());
                Console.Write("Enter the Movie language: ");
                m1.Lang = Console.ReadLine();
                Console.Write("Enter the Movie Actor: ");
                m1.Actor = Console.ReadLine();
                Console.Write("Enter the Movie Director: ");
                m1.Director = Console.ReadLine();
                Mlist.Add(m1);
            }

            //binary serialisation
            binaryserialization(Mlist);
            List<Movie> Mlist2 = binarydeserialization();
            print(Mlist2);

            //xml serialisation
            xmlserialization1(Mlist);
            List<Movie> Mlist3 = xmldeserialization1();
            print(Mlist3);
        }
    }
}
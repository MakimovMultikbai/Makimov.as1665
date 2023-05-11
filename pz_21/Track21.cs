using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    public class Track21
    {
        public string author;
        public string title;
        public string album;
        public int year;
        public int bitrate;
        public string type;

        public Track21(string author, string title, string album, int year)
        {
            this.author = author;
            this.title = title;
            this.album = album;
            this.year = year;
            this.bitrate = 00;
            this.type = "Тип кодека";
        }
        public Track21(string author)
        {
            this.author = author;
            title = "Название трека";
            album = "Альбом";
            year = 0;
            bitrate = 0;
            type = "Тип кодека";
        }
        public Track21()
        {
            author = "Неизвестный автор";
            title = "Название трека";
            album = "Альбом";
            year = 0;
            bitrate = 0;
            type = "Тип кодека";
        }

        public static void PrintInfo(Track21 a)
        {
            Console.WriteLine("Автор: " + a.author);
            Console.WriteLine("Название: " + a.title);
            Console.WriteLine("Альбом: " + a.album);
            Console.WriteLine("Год выпуска: " + a.year);
            Console.WriteLine("Битрейт: " + a.bitrate);
            Console.WriteLine("Тип кодека: " + a.type);
        }

    }
}

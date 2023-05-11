using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Track22 : ICloneable
    {
        public object Clone()
        {
            return new Track22(author, title, album, year, typeCodecEnum);
        }

        private string author = "Something";
        private string title = "TitleSomething";
        private string album = "AlbumSomething";
        private int year = 2000;
        private int bitrate = 32;

        public static int countTypesMP3;
        public static int countTypesAAC;
        public static int countTypesFLAC;

        public TypeCodecEnum typeCodecEnum = TypeCodecEnum.MP3;

        public enum TypeCodecEnum
        {
            MP3,
            AAC,
            FLAC
        }

        public string Author
        {
            get => author;

            set
            {
                if (value.Length > 0 && value != null)
                {
                    author = value;
                }
            }
        }

        public int Year
        {
            get => year;

            set
            {
                if (value > 1990 && value < 2022)
                {
                    year = value;
                }
            }
        }

        public string Title
        {
            get => title;

            set
            {
                if (value.Length > 0 && value != null)
                {
                    title = value;
                }
            }
        }

        public string Album
        {
            get => album;

            set
            {
                if (value.Length > 0 && value != null)
                {
                    album = value;
                }
            }
        }


        public int Bitrate
        {
            get => bitrate;
            set { }

        }

        public Track22(string author, string title, string album, int year, TypeCodecEnum typeCodecEnum)
        {
            Author = author;
            Title = title;
            Album = album;
            Year = year;
            this.bitrate = 00;
            this.typeCodecEnum = typeCodecEnum;
            IncrementTypeCounter(typeCodecEnum);
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Название: " + Title);
            Console.WriteLine("Альбом: " + Album);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Битрейт: " + Bitrate);
            Console.WriteLine("Тип кодека: " + typeCodecEnum.ToString());
        }

        public static void PrintTypeCounters()
        {
            Console.WriteLine(countTypesMP3 + " " + "counts type MP3");
            Console.WriteLine(countTypesAAC + " " + "counts type AAC");
            Console.WriteLine(countTypesFLAC + " " + "counts type FLAC");
        }

        private void IncrementTypeCounter(TypeCodecEnum typeCodecEnum)
        {
            if (typeCodecEnum == TypeCodecEnum.MP3)
            {
                ++countTypesMP3;
            }
            if (typeCodecEnum == TypeCodecEnum.AAC)
            {
                ++countTypesAAC;
            }
            if (typeCodecEnum == TypeCodecEnum.FLAC)
            {
                ++countTypesFLAC;
            }
        }
    }
}

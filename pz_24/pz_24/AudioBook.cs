using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class AudioBook : Track22, ICloneable
    {
        public object Clone()
        {
            return new AudioBook(Author, Title, Album, Year, typeCodecEnum, Time);
        }
        private int time = 60;

        public int Time
        {
            get => time;

            set
            {
                if (value > 30 && value < 90)
                {
                    time = value;
                }
            }
        }
        public AudioBook(string author, string title, string album, int year, TypeCodecEnum typeCodecEnum, int time)
            : base(author, title, album, year, typeCodecEnum) { }

        public override void PrintInfo()
        {
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Название: " + Title);
            Console.WriteLine("Альбом: " + Album);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Битрейт: " + Bitrate);
            Console.WriteLine("Тип кодека: " + typeCodecEnum.ToString());
            Console.WriteLine("Длительность: " + Time);
        }
    }
}

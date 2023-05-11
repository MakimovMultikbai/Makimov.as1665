namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Track22 track_1 = new Track22("", "", "", 0, Track22.TypeCodecEnum.FLAC);
            Track22 track_2 = new Track22("123", "", "", 0, Track22.TypeCodecEnum.MP3);
            Track22 track_3 = new Track22("321", "some", "Jhon sina", 0, Track22.TypeCodecEnum.FLAC);

            track_1.PrintInfo();
            Console.WriteLine();
            track_2.PrintInfo();
            Console.WriteLine();
            track_3.PrintInfo();
            Console.WriteLine();

            Track22.PrintTypeCounters();

            AudioBook audioBook_1 = new AudioBook("", "", "", 0, Track22.TypeCodecEnum.MP3, 80);
            Console.WriteLine();
            audioBook_1.PrintInfo();
            Console.WriteLine();
            Track22 track_4 = (Track22)audioBook_1.Clone();
            Track22 track_5 = (Track22)audioBook_1.Clone();

            track_4.PrintInfo();
            Console.WriteLine();
            track_5.PrintInfo();
            Console.WriteLine();

            AudioBook audioBook_2 = (AudioBook)audioBook_1.Clone();
            audioBook_2.Title = "Red Hat";
            AudioBook audioBook_3 = (AudioBook)audioBook_2.Clone();
            audioBook_3.Title = "Solaris";
            audioBook_3.Album = "7";
            AudioBook audioBook_4 = (AudioBook)audioBook_3.Clone();
            audioBook_4.Title = "The thing";
            audioBook_4.Time = 80;

            audioBook_2.PrintInfo();
            Console.WriteLine();
            audioBook_3.PrintInfo();
            Console.WriteLine();
            audioBook_4.PrintInfo();

        }
    }
}
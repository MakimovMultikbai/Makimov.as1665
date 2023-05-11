namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Track24 track_1 = new Track24("", "", "", 0, Track24.TypeCodecEnum.FLAC);
            Track24 track_2 = new Track24("123", "", "", 0, Track24.TypeCodecEnum.MP3);
            Track24 track_3 = new Track24("321", "some", "Jhon sina", 0, Track24.TypeCodecEnum.FLAC);

            track_1.PrintInfo();
            Console.WriteLine();
            track_2.PrintInfo();
            Console.WriteLine();
            track_3.PrintInfo();
            Console.WriteLine();

            Track24.PrintTypeCounters();

            AudioBook audioBook_1 = new AudioBook("", "", "", 0, Track24.TypeCodecEnum.MP3, 80);
            Console.WriteLine();
            audioBook_1.PrintInfo();
        }
    }
}
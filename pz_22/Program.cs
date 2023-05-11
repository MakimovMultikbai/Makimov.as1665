namespace pz_22
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

            AudioBook audioBook_1 = new AudioBook("","","",0, Track22.TypeCodecEnum.MP3, 80);
            Console.WriteLine();
            audioBook_1.PrintInfo();
        }
    }
}
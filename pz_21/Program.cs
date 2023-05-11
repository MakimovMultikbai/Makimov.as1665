namespace pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Track21 track = new Track21();
            Track21 track1 = new Track21("Author1", "Title1", "Album1", 2012);
            Track21 track2 = new Track21("Author2");
            Track21 track3 = new Track21("Author3", "Title3", "Album3", 1998);
            Track21.PrintInfo(track);
            Console.WriteLine();
            Track21.PrintInfo(track1);
            Console.WriteLine();
            Track21.PrintInfo(track2);
            Console.WriteLine();
            Track21.PrintInfo(track3);
        }
    }
}
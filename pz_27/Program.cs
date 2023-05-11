namespace pz_27
{
    struct NOTE
    {
        public string NAME;
        public string TELE;
        public int[] BDAY;

        public NOTE(string name, string tele, int[] bday)
        {
            this.NAME = name;
            this.TELE = tele;
            this.BDAY = bday;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<NOTE> BLOCKNOTE = new List<NOTE>();
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите фамилию и имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите номер телефона: ");
                string tele = Console.ReadLine();
                Console.WriteLine("Введите день рождения (день месяц год): ");
                string[] bdayStr = Console.ReadLine().Split(' ');
                int[] bday = new int[3];
                for (int j = 0; j < 3; j++)
                    bday[j] = int.Parse(bdayStr[j]);
                BLOCKNOTE.Add(new NOTE(name, tele, bday));
            }
            BLOCKNOTE.Sort((x, y) => x.NAME.CompareTo(y.NAME));
            Console.WriteLine("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (var note in BLOCKNOTE)
                if (note.BDAY[1] == month)
                {
                    found = true;
                    Console.WriteLine(note.NAME + " " + note.TELE + " " + note.BDAY[0] + "." + note.BDAY[1] + "." + note.BDAY[2]);
                }
            if (!found)
                Console.WriteLine("Нет людей с днем рождения в этом месяце.");
        }
    }
}
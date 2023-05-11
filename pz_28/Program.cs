namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 Задание
            Console.WriteLine("Задание 2:");
            Console.WriteLine();
            Temperatur temperature = new Temperatur();
            temperature.TemperatureChanged += (sender, e) =>
            {
                if (e.Temperature == -25)
                {
                    Console.WriteLine("Temperature is -25");
                }
                else if (e.Temperature == 0)
                {
                    Console.WriteLine("Temperature is 0");
                }
                else if (e.Temperature == 25)
                {
                    Console.WriteLine("Temperature is 25");
                }
                else if (e.Temperature == 35)
                {
                    Console.WriteLine("Temperature is 35");
                }
            };
            temperature.Start();

            Console.WriteLine();

            //5 Задание
            Console.WriteLine("Задание 5:");
            Console.WriteLine();

            Guest[] visitors = new Guest[35];
            Controler controller = new Controler();

            for (int i = 0; i < 35; i++)
            {
                visitors[i] = new Guest();
                controller.AddVisitor(visitors[i]);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    class Controler
    {
        const int maxVisitors = 30;
        int currenGuests;

        public void AddVisitor(Guest visitor)
        {
            if (currenGuests < maxVisitors)
            {
                currenGuests++;
                Console.WriteLine($"Гость добавлен. Сейчас {currenGuests} гостей");
            }
            else
            {
                Console.WriteLine("Максимальное количество гостей.");
            }
        }
    }
}

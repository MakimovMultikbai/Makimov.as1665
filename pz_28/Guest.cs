using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    class Guest
    {
        static int count;
        public Guest()
        {
            count++;
            Console.WriteLine($"{count}-й гость пришел.");
        }
    }
}


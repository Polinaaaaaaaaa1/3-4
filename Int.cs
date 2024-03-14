using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Int : IValue<int>
    {
        public int random()
        {
            Random rand = new Random();
            return rand.Next(0, 20);
        }
        public int user()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

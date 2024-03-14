using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Bool:IValue<bool>
    {public bool random()      
        {
            Random rand = new Random(); 
            bool[] choice = { true, false };
            return choice[rand.Next(choice.Length)];
        }
        public bool user()
        {
            return bool.Parse(Console.ReadLine());
        }
    }
}

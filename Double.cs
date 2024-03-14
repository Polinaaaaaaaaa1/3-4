using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Double: IValue<double>
    {
        public double random()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }
        public double user()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    
    
}

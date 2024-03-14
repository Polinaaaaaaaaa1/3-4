using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class String : IValue<string>
    {
        public string random()
        {
            Random rand = new Random();
            string str = "";
            string choice = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i=0; i < rand.Next(3); i++)
            {
                str += choice[rand.Next(choice.Length)];
            }
            return str;
        }
        public string user()
        {
            return Console.ReadLine();
        }
    }
}

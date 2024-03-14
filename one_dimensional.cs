using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_3.Program;

namespace _3_3
{
    internal class one_dimensional<T> : BaseArray<T>, IBaseArray, IPRINTER
    {
        private T[] array;
        public one_dimensional(int length, IValue<T> value) :base(value)
        {
            array = new T[length];
        }
        protected override void user_fill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" введите {typeof(T)}");
                
                array[i]= value.user();
            }
        }
        protected override void random_fill()
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=value.random();
            }
        }
        public void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

       
        public void ReCreate()
        {int length = int.Parse(Console.ReadLine());
            array = new T[length];
        }
    }
}

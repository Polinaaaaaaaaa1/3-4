using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_3.Program;

namespace _3_3
{
    internal class multidimensional<T> : BaseArray<T>, IBaseArray, IPRINTER
    {
        private T[,] array;
        private int length, heigth;
        public multidimensional(int length2, int heigth2, IValue<T> value) : base(value)
        {
            length = length2;
            heigth = heigth2;
            array = new T[length,heigth];
           
        }
        protected override void user_fill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)

                {
                    Console.WriteLine($" введите {typeof(T)}");
                    Console.Write($"Элемент [{i},{j}]в многомерном массиве: ");

                    array[i, j] =  value.user();

                }
            }
        }
        protected override void random_fill()
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = value.random();
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

       
        
        public void ReCreate()
        {
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            array = new T[length,heigth];
        }

    }
}

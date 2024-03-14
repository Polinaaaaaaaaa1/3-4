using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class jagged<T> : BaseArray<T>, IBaseArray, IPRINTER
    {
        private int[] array_of_lengths;
        private T[][] array;
        private int heigth;
        public jagged(int heigth,int[] array_of_lengths,IValue<T> value):base(value) 
        {
            this.heigth = heigth;
            array = new T[heigth][];
            this.array_of_lengths = array_of_lengths;
        }
        protected override void user_fill()
        {
            for (int i = 1; i <= array.GetLength(0); i++)
            {
                Console.WriteLine($" введите {typeof(T)}");
                T[] mas = new T[array_of_lengths[i-1]];
                Console.WriteLine("Введите " + i + " строку зубчатого массива");
                for(int j=0;j< array_of_lengths.Length; j++)
                {
                    mas[j] = value.user();
                }

                array[i - 1] = mas;

            }
        }
        protected override void random_fill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                T[] mas = new T[array_of_lengths[i]];
                for (int j = 0; j < mas.Length; j++)
                {
                    mas[j] = value.random();
  
                    array[i] = mas;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < array_of_lengths[i]; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
       
        public void ReCreate()
        {
            int heigth = int.Parse(Console.ReadLine());
            array = new T[heigth][];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            IPRINTER[] arrays = new IPRINTER[8];
            Int ints = new Int();
            String strings = new String();
           Bool bools = new Bool();
            Double doubles = new Double ();

            Console.WriteLine("длина одномерного массива");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите true, если заполните массив  с клавиатуры, иначе false");
            bool id = bool.Parse(Console.ReadLine());
            one_dimensional<int> Array = new one_dimensional<int>(length,ints);
            //Console.Write("введите int");
            Array.fill_select(id);
            one_dimensional<bool> Array_2 = new one_dimensional<bool>(length,bools);
            
            one_dimensional<double> Array_3 = new one_dimensional<double>(length,doubles);
            
            one_dimensional<string> Array_4 = new one_dimensional<string>(length,strings);
            
            Array_2.fill_select(id);
            
            Array_3.fill_select(id);
            Array_4.fill_select(id);
            arrays[0] = Array;
            arrays[1] = Array_2;
            arrays[2] = Array_3;
            arrays[3] = Array_4;


            Console.WriteLine("введите true, если многомерный и false, если зубчатый");
            bool selected = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите true, если заполните массив  с клавиатуры, иначе false");
            bool id2 = bool.Parse(Console.ReadLine());
            if (selected)
            {
                Console.Write("введите длину многомерного массива");
                int length2 = int.Parse(Console.ReadLine());
                Console.Write("введите ширину многомерного массива");
                int heigth2 = int.Parse(Console.ReadLine());
                multidimensional<int> Array2_1 = new multidimensional<int>(length2, heigth2,ints);
                multidimensional<string> Array2_2 = new multidimensional<string>(length2, heigth2,strings);
                multidimensional<bool> Array2_3 = new multidimensional<bool>(length2, heigth2,bools);
                multidimensional<double> Array2_4 = new multidimensional<double>(length2, heigth2,doubles);
                Array2_1.fill_select(id2);
                Array2_2.fill_select(id2);
                Array2_3.fill_select(id2);
                Array2_4.fill_select(id2);
                arrays[4] = Array2_1;
                arrays[5] = Array2_2;
                arrays[6] = Array2_3;
                arrays[7] = Array2_4;
            }
            else
            {
                Console.WriteLine("введите количествео строк зубчатого массива");
                int heigth3 = int.Parse(Console.ReadLine());
                int[] array_of_lengths = new int[heigth3];
                for (int i = 0; i < heigth3; i++)
                {
                    Console.WriteLine($"введите количество эл-тов в {i + 1} строке зубч массива");
                    array_of_lengths[i] = int.Parse(Console.ReadLine());
                }
                jagged<int> Array3 = new jagged<int>(heigth3, array_of_lengths, ints);
                jagged<string> Array3_2 = new jagged<string>(heigth3, array_of_lengths,strings);
                jagged<bool> Array3_3 = new jagged<bool>(heigth3, array_of_lengths,bools);
                jagged<double> Array3_4 = new jagged<double>(heigth3, array_of_lengths,doubles);
                Array3.fill_select(id2);
                Array3_2.fill_select(id2);
                Array3_3.fill_select(id2);
                Array3_4.fill_select(id2);
                arrays[4] = Array3;
                arrays[5] = Array3_2;
                arrays[6] = Array3_3;
                arrays[7] = Array3_4;
            }

            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine($"вывод массива {i+1}");
                arrays[i].Print();
                
            }
            
        }
    }
}

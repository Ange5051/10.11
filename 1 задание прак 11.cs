using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить количество элементов одномерного массива.
            //int[] omas;
            //int [] omas = { (0, -1, 2, 3) };
            //Console.WriteLine($"Размер:{omas.Length}");
            //string[] mas = { "Антон", "Даша", "Никита" };
            //int size = mas.Length; 
            //Console.WriteLine($"Размер:{size}");

            //Задача 2. Обнулить заданный диапазон элементов в одномерном массиве
            //int[] omas = Input(Size());
            //Array.Clear(omas, 1, 3);
            //Output(omas);
            //Console.ReadKey();

            //Задача 3. Найти максимальное и минимальное значение в массиве.
            ////int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = array.Max();
            //int min = array.Min();
            //Console.WriteLine("Максимальное значение: " + max);
            //Console.WriteLine("Минимальное значение: " + min);
            //Console.ReadKey();

            //Задача 4. Сортировка массива по возрастанию.
            int[] array = { 9, 5, 3, 8, 6, 1, 7, 2, 4 };
            Array.Sort(array);
            Console.WriteLine("Отсортированный массив:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}

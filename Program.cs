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

            //Задача 2. Обнулить заданный диапазон элементов в одномерном массиве.
                // Пример массива
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                // Указываем диапазон (например, с индекса 2 по индекс 5)
                int startIndex = 2;  // Начальный индекс диапазона
                int endIndex = 5;    // Конечный индекс диапазона

                // Проверка на корректность диапазона
                if (startIndex < 0 || endIndex >= array.Length || startIndex > endIndex)
                {
                    Console.WriteLine("Некорректный диапазон индексов.");
                    return;
                }

                // Обнуление элементов в заданном диапазоне
                for (int i = startIndex; i <= endIndex; i++)
                {
                    array[i] = 0;
                }

                // Выводим результат
                Console.WriteLine("Массив после обнуления:");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }
        }

    }



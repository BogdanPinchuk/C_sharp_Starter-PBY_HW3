﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{

    class Program
    {
        // створюємо поля для умови якщо малося на увазі розрахувати
        // дані 5 операцій окремо а не підряд

        /// <summary>
        /// Змінні для розрахунків
        /// </summary>
        static int x = 10,
            y = 12,
            z = 3;

        static void Main(string[] args)
        {
            // Підключення української мови для коректного виведення (взято з інтернету)
            Console.OutputEncoding = Encoding.Default;

            #region 1-й варіант
            // за умови коли необхідно все вираховувати підряд
            // і допускаємо змінну зміннних

            // Створюємо змінні в методі (локальні по відношенню до рівня класів)
            // стандартний довгий/громіздкіший варіант, можна також ініціалізувати методом: UpdateIndef(out x, out y, out z);
            // out - не вимагає, щоб змінна була проініціалізована;
            // ref - вимагає, щоб змінна була проініціалізована;

            int x = Program.x,
                y = Program.y,
                z = Program.z;

            // Вимодимо задані значення:
            Console.WriteLine("Три задані змінні:");
            Console.WriteLine($"\tx = {x};");
            Console.WriteLine($"\ty = {y};");
            Console.WriteLine($"\tz = {z};\n");

            // Підпис варіанту розрахунку
            Console.WriteLine("Варіант 1-й, за умови коли виконується все підряд.\n");

            Console.WriteLine("1-й вираз: x += y - x++ * z");
            x += y - x++ * z;
            Console.WriteLine($"Результат: x = {x};\n");

            Console.WriteLine("2-й вираз: z = --x - y * 5");
            z = --x - y * 5;
            Console.WriteLine($"Результат: z = {z};\n");

            Console.WriteLine("3-й вираз: y /= x + 5 % z");
            y /= x + 5 % z;
            Console.WriteLine($"Результат: y = {y};\n");

            Console.WriteLine("4-й вираз: z = x++ + y * 5");
            z = x++ + y * 5;
            Console.WriteLine($"Результат: z = {z};\n");

            Console.WriteLine("5-й вираз: x = y - x++ * z");
            x = y - x++ * z;
            Console.WriteLine($"Результат: x = {x};\n");
            #endregion

            #region 2-й варіант
            // за умови коли необхідно все вираховувати окремо
            // і недопускаэмо змінну ідентифікаторів

            // Підпис варіанту розрахунку
            Console.WriteLine("Варіант 2-й, за умови коли виконується все окремо.\n");

            // Оновлюємо індертифікатори:
            UpdateIndef(out x, out y, out z);

            Console.WriteLine("1-й вираз: x += y - x++ * z");
            x += y - x++ * z;
            Console.WriteLine($"Результат: x = {x};\n");

            // Оновлюємо індертифікатори:
            UpdateIndef(out x, out y, out z);

            Console.WriteLine("2-й вираз: z = --x - y * 5");
            z = --x - y * 5;
            Console.WriteLine($"Результат: z = {z};\n");

            // Оновлюємо індертифікатори:
            UpdateIndef(out x, out y, out z);

            Console.WriteLine("3-й вираз: y /= x + 5 % z");
            y /= x + 5 % z;
            Console.WriteLine($"Результат: y = {y};\n");

            // Оновлюємо індертифікатори:
            UpdateIndef(out x, out y, out z);

            Console.WriteLine("4-й вираз: z = x++ + y * 5");
            z = x++ + y * 5;
            Console.WriteLine($"Результат: z = {z};\n");

            // Оновлюємо індертифікатори:
            UpdateIndef(out x, out y, out z);

            Console.WriteLine("5-й вираз: x = y - x++ * z");
            x = y - x++ * z;
            Console.WriteLine($"Результат: x = {x};\n");
            #endregion

            // Затримка
            Console.ReadKey();
        }

        /// <summary>
        /// функція ініціалізації та присвоєння даних
        /// </summary>
        /// <param name="x">10</param>
        /// <param name="y">12</param>
        /// <param name="z">5</param>
        static void UpdateIndef(out int x, out int y, out int z)
        {
            x = Program.x;
            y = Program.y;
            z = Program.z;
        }
    }
}

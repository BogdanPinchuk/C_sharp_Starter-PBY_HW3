﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Підключення української мови для коректного виведення (взято з інтернету)
            Console.OutputEncoding = Encoding.Default;

            // можна скаоистатися вбудованою сталою, але для спрощення запису 
            // краще скористатися коротким індентифікатором
            // Число пі = 3,14
            const double pi = Math.PI;

            double r,   // радіус кола
                C,      // довжина кола
                S;      // площа кола

            // Пропонуємо ввести радіус користувачу,
            // так як в умові не вказано задати самому значення

            // Заголовок
            Console.WriteLine("Розрахунок параметрів кола\n");

            // введення користучачем радіуса
            // в завданні не було умови робити перевірку на число
            // тому надіємось що користучав знає як правильно ввести дані)))
            Console.Write("Введіть будь ласка\nРадіус кола: R = ");
            string R = Console.ReadLine();

            // щоб не вибивало помилки необхідно зробити заміну
            R = R.Replace(".", ",");

            // Конвертація строкової змінної в число відповідного формату
            r = double.Parse(R);

            // Розрахунок довжини кола, довжина кола не може бути від'ємною
            C = 2 * pi * Math.Abs(r);

            // Вивід результату
            Console.WriteLine($"\nДовжина кола: С = {C:N} відносних одиниць;");

            // Розрахунок площі кола
            S = pi * r * r;

            // Вивід результату
            Console.WriteLine($"Площа кола: S = {S:N} відносних одиниць;\n");

            // Затримка
            Console.ReadKey();
        }
    }
}
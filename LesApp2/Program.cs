using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Підключення української мови для коректного виведення (взято з інтернету)
            Console.OutputEncoding = Encoding.Default;

            // Примітка. Подібна проблема була розглянута в LesApp0 при діленні,
            // для отримання точного результату, необхідно щоб хочаб один із чисел
            // або приводився до дійсного числа (явно/неявно) {був кастинг}
            // при діленні цілих чисел втрачається залишок

            // Створюємо 3 цілочислові змінні, аналогічно LesApp0

            // Заголовок
            Console.WriteLine("Середнє арифметичне з цілочисельними змінними: \n");

            // створення випадкових змінних в відповідному діапазоні
            Random rnd = new Random();
            int a = rnd.Next(short.MinValue, short.MaxValue),
                b = rnd.Next(short.MinValue, short.MaxValue),
                c = rnd.Next(short.MinValue, short.MaxValue);

            // Вивід отриманих змінних
            Console.WriteLine($"1-ша змінна: a = {a:N0};");
            Console.WriteLine($"2-га змінна: b = {b:N0};");
            Console.WriteLine($"3-тя змінна: c = {c:N0};\n");

            #region неточний варіант розрахунку
            // Цілочисельне (неточне) ділення
            Console.WriteLine("Цілочисельний (неточний) розрахунок:");

            {
                // створення випадкових змінних в відповідному діапазоні
                int AM = (a + b + c) / 3;   // https://uk.wikipedia.org/wiki/Середнє_степеневе - правильне позначення середнього арифметичного

                Console.WriteLine($"Результат: AM = {AM:N};\n");
            }
            #endregion

            #region точний варіант розрахунку
            // Цілочисельне (неточне) ділення
            Console.WriteLine("Розрахунок (точний) з плаваючою комою:");

            {
                // створення випадкових змінних в відповідному діапазоні
                float AM = (a + b + c) / 3f;

                Console.WriteLine($"Результат: AM = {AM:N};\n");
            }
            #endregion

            // із деякою ймовірністю, сума може бути кратною "3",
            // в такому випадку результати точного і неточного варіантів збігаються

            // Затримка
            Console.ReadKey();
        }
    }
}

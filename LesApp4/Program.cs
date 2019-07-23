using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Підключення української мови для коректного виведення (взято з інтернету)
            Console.OutputEncoding = Encoding.Default;

            // коментарі спрощені, дивитися аналогічні коментрі в LesApp3

            double r,   // радіус торця циліндра
                h,      // висота циліндра
                S,      // площа циліндра
                V;      // об'єм циліндра

            // Заголовок
            Console.WriteLine("Розрахунок параметрів циліндра\n");

            // введення користучачем радіуса
            Console.Write("Введіть будь ласка\n\tРадіус торця циліндра: R = ");

            // записуємо змінну разом і робимо заміну символів
            string R = Console.ReadLine().Replace(".", ",");

            // введення користучачем висоти
            Console.Write("\tВисота циліндра: H = ");

            // записуємо змінну разом і робимо заміну символів
            string H = Console.ReadLine().Replace(".", ",");

            // Конвертація строкових змінних в числа відповідного формату
            r = double.Parse(R);
            h = double.Parse(H);

            // Примітка. Так як в умові завдання не вказано створювати константу
            // pi = 3.14 для розрахункыв, то маэмо право скористатися вбудованою
            // точність має велике значення)))

            // Розрахунок площі циліндра
            S = 2 * Math.PI * r * (h + r);

            // Вивід результату
            Console.WriteLine($"\nПлоща циліндра: S = {S:N} відносних одиниць;");

            // Розрахунок об'єму циліндра
            V = Math.PI * r * r * h;

            // Вивід результату
            Console.WriteLine($"Об'єм циліндра: V = {V:N} відносних одиниць;\n");

            // Затримка
            Console.ReadKey();
        }
    }
}

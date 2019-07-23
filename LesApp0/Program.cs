using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Підключення української мови для коректного виведення (взято з інтернету)
            Console.OutputEncoding = Encoding.Default;

            // Створюємо 2 цілочислові змінні,
            // в даному випадку краще створити змінні в діапазоні типу short (враховуючи знак)
            // і висести в int, щоб не було переповнення
            // всі цікаві варіанти чисел охопити важко, тому доцільно скористатися
            // рандомними/випадковими числами

            // Заголовок
            Console.WriteLine("Арифметичні операції з двома цілочисельними змінними: \n");

            // створення випадкових змінних в відповідному діапазоні
            Random rnd = new Random();
            int a = rnd.Next(short.MinValue, short.MaxValue),
                b = rnd.Next(short.MinValue, short.MaxValue),
                res = default;    // результат арифметичних операцій

            // Вивід отриманих змінних
            Console.WriteLine($"Перша змінна: a = {a:N0};");
            Console.WriteLine($"Друга змінна: b = {b:N0};\n");

            // Робимо всі арифметичні операції

            #region додавання
            res = a + b;
            // вивід на екран
            Console.WriteLine($"Сума: a + b = {res:N0};\n");
            #endregion

            #region віднімання
            res = a - b;
            // вивід на екран
            Console.WriteLine($"Різниця: a - b = {res:N0};");
            res = b - a;
            // вивід на екран
            Console.WriteLine($"Різниця: b - a = {res:N0};\n");
            #endregion

            #region множення
            res = a * b;
            // вивід на екран
            Console.WriteLine($"Добуток: a * b = {res:N0};\n");
            #endregion

            #region ділення
            // у випадку якщо відбувається ділення 0/0 - маємо невизначенність
            // якщо ділитьсяс якеь число на 0 то безкінечність
            // врахуємо особливості

            if (a == 0 && b == 0)
            {
                Console.WriteLine($"Частка: a / b = NaN (невизначеність);");
                Console.WriteLine($"Частка: b / a = NaN (невизначеність);\n");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine($"Частка: a / b = 0;");
                Console.WriteLine($"Частка: b / a = {Math.Sign(b)} * Inf (безкінечність);\n");
            }
            else if (a != 0 && b == 0)
            {
                Console.WriteLine($"Частка: b / a = 0;");
                Console.WriteLine($"Частка: a / b = {Math.Sign(a)} * Inf (безкінечність);\n");
            }
            else
            {
                // Цілочисельне (неточне) ділення
                Console.WriteLine("Цілочисельне (неточне) ділення:");
                res = a / b;
                Console.WriteLine($"Частка: a / b = {res};");
                res = b / a;
                Console.WriteLine($"Частка: b / a = {res};\n");

                // Дійсне (точне) ділення
                Console.WriteLine("Дійсне (точне) ділення:");
                Console.WriteLine($"Частка: a / b = {a / (float)b:N3};");
                Console.WriteLine($"Частка: b / a = {b / (float)a:N3};\n");
            }
            #endregion

            #region визначення залишку від ділення
            // так як в нас відбувається ділення перш ніж отримати остаток 
            // то результати подібні вище наведеного прикладу;
            // причому, при діленні на 0, матимемо безкінечність це лише для ділення,
            // а так як будь яке число в тому числі безкінечність ділитиметься на вказане
            // число і даватиме залишок або не даватиме (якщо ділитиметься націло), і
            // залишок знаходитиметься в діапазоні [1, N) де N число на яке ділять,
            // то безкінечності отримати неможливо, тому в даному випадку доцільно скористатися
            // вірним твердженням - невизначеність

            if (a == 0 && b == 0)
            {
                Console.WriteLine($"Залишок: a % b = NaN (невизначеність);");
                Console.WriteLine($"Залишок: b % a = NaN (невизначеність);\n");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine($"Залишок: a / b = 0;");
                Console.WriteLine($"Залишок: b / a = NaN (невизначеність);\n");
            }
            else if (a != 0 && b == 0)
            {
                Console.WriteLine($"Залишок: b / a = 0;");
                Console.WriteLine($"Залишок: a / b = NaN (невизначеність);\n");
            }
            else
            {
                res = a % b;
                Console.WriteLine($"Залишок: a % b = {res:N0};");
                res = b % a;
                Console.WriteLine($"Залишок: b % a = {res:N0};");
            }
            #endregion

            // Затримка
            Console.ReadKey();
        }
    }
}

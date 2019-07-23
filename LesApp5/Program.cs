using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Перевірка створення змінних
            int //uberflu?,           // неможна, так як останній знак "?" недопустимий
                _Identifier,        // можна, венгерське йменування індентифікаторів
                \u006fIdentifier,   // можна, на початку використано символ Юнікоду, користуватися не рекомендується
                myVariab1le;        // можна, бажано не використовувати числа в середні назв, так як це погіршує сприйняття
                //&myVar;             // неможна, так як перший знак "&" недопустимий

        }
    }
}

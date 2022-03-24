using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRandom
{
    internal class Number
    {
        internal int IsValidNumber(string pretext)
        {
            int number;
            bool isValid;
            Console.Write(pretext);
            while (isValid = !int.TryParse(Console.ReadLine(), out number))
            {
                if(isValid)
                {
                    Console.Write("Вы ввели некорректные данные, попробуйте еще раз: ");
                }
            }
            return number;
        }

        internal int IsValidDischarge()
        {
            int discharge;
            bool isValid;
            Console.Write("Введите разряд, на который нужно поделить рандомные числа:");
            while (isValid = !int.TryParse(Console.ReadLine(), out discharge))
            {
                if(isValid)
                {
                    Console.Write("Вы ввели некорректные данные, попробуйте еще раз: ");
                }
            }
            return discharge;
        }
    }
}

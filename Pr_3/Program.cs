using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Pr_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Задание 1
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Число чётное");
            else
                Console.WriteLine("Число нечётное");


            ////Задание 2
            Console.WriteLine("Сколько у вас карт?");
            int count = int.Parse(Console.ReadLine());
            int summ = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите номинал вашей карты");
                string card = Console.ReadLine();
                switch (card)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T": summ += 10; break;
                    default: summ += int.Parse(card); break;
                }
            }
            Console.WriteLine("Сумма = " + summ);



            ////Задание 3
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
            int count1 = 1;
            bool flag = false;
            while (count1 != N)
            {
                if (N % count1 == 0 && count1 != 1) flag = true;
                count1++;
            }
            if (flag) Console.WriteLine("Число не простое");
            else Console.WriteLine("Число простое");





            ////Задание 4
            Console.WriteLine("Ведите количество чисел в последовательности ");
            int count2 = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < count2; i++)
            {
                Console.Write("Ведите число");
                int number1 = int.Parse(Console.ReadLine());
                if (number1 < min) min = number1;

            }
            Console.WriteLine("Минимальное число = " + min);



            //Задание 5
            Random random = new Random();
            Console.WriteLine("Введите границу диапазона");
            int border = int.Parse(Console.ReadLine());
            int number2;
            int number3 = random.Next(border);
            do
            {
                Console.WriteLine("Введите число");
                string num=Console.ReadLine();
                if (num == " ")
                {
                    Console.WriteLine("Загаданное число = " + number3);
                    break;
                }
                else
                {
                    number2 = int.Parse(num);
                    if (number3 == number2)
                    {
                        Console.WriteLine("Вы угадали!!!");
                        break;
                    }
                    if (number3 < number2) Console.WriteLine("Загаданное число меньше");
                    else Console.WriteLine("Загаданное число больше");
                }
               
            }
            while (true);
            Console.ReadKey();

        }
    }
}

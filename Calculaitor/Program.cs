using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculaitor
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в программу \"Калькулятор\"!");
            Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n" +
                 "4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n" +
                 "6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n" +
                 "8. Найти факториал из числа\r\n9. Выйти из программы");
            Console.WriteLine("Выберите одну из операций: ");
            while (true)
            {
                int operation = Convert.ToInt32(Console.ReadLine());
                if (operation > 9 || operation < 1)
                {
                    Console.WriteLine("Ошибка, выберите корректную операцию!");
                }

                switch (operation)
                {
                    case 1:
                        {
                            Amount();
                            break;
                        }
                    case 2:
                        {
                            Minus();
                            break;
                        }
                    case 3:
                        {
                            Umnoj();
                            break;
                        }
                    case 4:
                        {
                            Del();
                            break;
                        }
                    case 5:
                        {
                            Stepen();
                            break;
                        }
                    case 6:
                        {
                            Koren();
                            break;
                        }
                    case 7:
                        {
                            Procent();
                            break;
                        }
                    case 8:
                        {
                            Integral();
                            break;
                        }         
                    case 9:
                        Console.WriteLine("Спасибо за использование программы!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void Amount()
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ:" + (a + b) + "\r\n");
            Main();
        }

        static void Minus()
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ:" + (a - b) + "\r\n");
            Main();
        }
        
        static void Umnoj()
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ:" + (a * b) + "\r\n");
            Main();
        }

        static void Del()
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Ошибка. Делитель не может быть равен 0!");
                return;
            }
            Console.WriteLine("Ответ:" + (a / b) + "\r\n");
            Main();
        }
        
        static void Stepen()
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double stepen = Math.Pow(a, b);
            Console.WriteLine("Ответ:" + stepen + "\r\n");
            Main();
        }

        static void Koren()
        {
            Console.WriteLine("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Ошибка. Корень не может быть равен 0!");
                return;
            }
            double koren = Math.Sqrt(a);
            Console.WriteLine("Ответ:" + koren + "\r\n");
            Main();
        }

        static void Procent()
        {
            Console.WriteLine("Выберите число:");
            double a = Convert.ToDouble(Console.ReadLine());
            double procent = a / 100;
            Console.WriteLine("Ответ: " + procent + "\r\n");
            Main();
        }
        static void Integral()
        {
            double integral = 1;
            Console.WriteLine("Выберите число:");
            double a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                integral = integral * i;
            }
            Console.WriteLine(integral + "\r\n");
            Main();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_к_семинару_2
{
    internal class Program
    {
        static void Main()
        {

            void zadacha13()

            {
                //Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

                ConsoleKeyInfo btn; 
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите целое число: ");
                    string a = Console.ReadLine();
                    if (int.TryParse(a, out var x)) 
                    {
                        if (a.Length > 2)
                        {
                            Console.WriteLine("3-е цифра слева: " + a[2]);
                        }
                        else
                        {
                            Console.WriteLine("У числа: <" + a + "> нет 3-й слева цифры");
                        }
                        Console.Write("Для выхода из программы нажмите Escape");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод, нужно ввести число");
                    }
                    btn = Console.ReadKey();
                    a = "";
                }
                while (!(btn.Key == ConsoleKey.Escape));
            }
            void zadacha15()
            {
                //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
                ConsoleKeyInfo btn; 
                do
                {
                    Console.Clear();
                    int a;
                    Console.WriteLine("Введите порядковый номер дня недели:");
                    a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("Понедельник-будний день");
                            break;
                        case 2:
                            Console.WriteLine("Вторник-будний день");
                            break;
                        case 3:
                            Console.WriteLine("Среда-будний день");
                            break;
                        case 4:
                            Console.WriteLine("Четверг-будний день");
                            break;
                        case 5:
                            Console.WriteLine("Пятница-будний день");
                            break;
                        case 6:
                            Console.WriteLine("Суббота-выходной день");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье-выходной день");
                            break;
                        default:
                            Console.WriteLine("в неделе 7 дней, число не может быть  меньше 1 и больше 7");
                            break;
                    }
                    Console.Write("Для выхода из программы нажмите Escape");
                    btn = Console.ReadKey();
                    Console.ReadKey();
                }
                while (!(btn.Key == ConsoleKey.Escape));
            }
            zadacha15();
        }
    }
}




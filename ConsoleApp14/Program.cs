using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        { ////№1
            //Console.Write("Введите текущий год: ");
            //double year = double.Parse(Console.ReadLine());
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine($"{year} Год высокосный");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} Год не высокосный");
            //}
            ////№2
            //Console.Write("Введите стоимость ноутбука: ");
            //double price = double.Parse(Console.ReadLine());
            //if (20000 < price && price < 30000)
            //{
            //    Console.WriteLine($"{price} рублей входит в диапозон от 20 до 30 тыс. руб.");
            //}
            //else
            //{
            //    Console.WriteLine($"{price} рублей не входит в диапозон от 20 до 30 тыс. руб.");
            //}
            ////№3
            //Console.WriteLine("Введите балл полученный учеником: ");
            //double mark = double.Parse(Console.ReadLine());
            //if (mark < 60 && mark > -1)
            //{
            //    Console.WriteLine($"Балл {mark} = оценка неуд.");
            //}
            //else if (mark > 59 && mark < 75)
            //{
            //    Console.WriteLine($"Балл {mark} = оценка удовл.");
            //}
            //else if (mark > 74 && mark < 90)
            //{
            //    Console.WriteLine($"Балл {mark} = оценка хорошо");
            //}
            //else if (mark > 89 && mark < 101)
            //{
            //    Console.WriteLine($"Балл {mark} = оценка отлично");
            //}
            //else { Console.WriteLine($"Балл {mark} не может быть использован для оценки"); };
            ////№4
            //Console.Write("Введите номер состояния светофора от 1 до 3: ");
            //double sveto4 = double.Parse(Console.ReadLine());
            //switch (sveto4)
            //{
            //    case 1: Console.WriteLine("Состояние светофора - красный"); break;
            //    case 2: Console.WriteLine("Состояние светофора - жёлтый"); break;
            //    case 3: Console.WriteLine("Состояние светофора - зелёный"); break;
            //    default: Console.WriteLine("Не существует такого состояния"); break;
            //}
            ////№5
            //Random rnd = new Random();
            //double i = rnd.Next(-100, 100);
            //Console.Write(i % 2 == 0 ? $"Число {i} четное" : $"Число {i} не четное");
            //Console.Write(i > 0 ? $" и положительное" : $" и отрицательное");
            //№6
            //Console.Write("Введите номер дня недели: ");
            //double day = double.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1: Console.WriteLine("Понедельник"); break;
            //    case 2: Console.WriteLine("Вторник"); break;
            //    case 3: Console.WriteLine("Среда"); break;
            //    case 4: Console.WriteLine("Четверг"); break;
            //    case 5: Console.WriteLine("Пятница"); break;
            //    case 6: Console.WriteLine("Суббота"); break;
            //    case 7: Console.WriteLine("Воскресенье"); break;
            //    default: Console.WriteLine("Не существует такого дня недели"); break;
            //}
            ////№7
            //Console.WriteLine("Создайте логин: ");
            //string login = Console.ReadLine();
            //Console.WriteLine("Создайте пароль: ");
            //string password = Console.ReadLine();
            //Console.WriteLine("Повторно введите логин: ");
            //string login1 = Console.ReadLine();
            //if (login == login1)
            //{
            //    Console.WriteLine("Логин веренн");
            //}
            //else
            //{
            //    Console.WriteLine("Логин неверен");
            //}
            //Console.WriteLine("\nПовторно введите пароль: ");
            //string password1 = Console.ReadLine();
            //if (password == password1)
            //{
            //    Console.WriteLine("Пароль верен");
            //}
            //else
            //{
            //    Console.WriteLine("Пароль неверен");
            //}
            ////№8
            //string op;
            //Console.WriteLine("Введите переменную a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите переменную b: ");
            //double b = double.Parse(Console.ReadLine());
            //double res;
            //Console.WriteLine("Введите желаемую операцию: ");
            //op = Console.ReadLine();
            //switch (op)
            //{
            //    case "+": res = a + b; Console.WriteLine($"Ответ:{res}"); break;
            //    case "-": res = a - b; Console.WriteLine($"Ответ:{res}"); break;
            //    case "*": res = a * b; Console.WriteLine($"Ответ:{res}"); break;
            //    case "/": res = a / b; Console.WriteLine($"Ответ:{res:f2}"); break;
            //}
            ////№9
            //Console.WriteLine("Введите возраст: ");
            //int age = int.Parse(Console.ReadLine());
            //int p = 0;
            //if ((age >= 0) && (age < 17)) p = 1;
            //if ((age >= 17) && (age < 25)) p = 2;
            //if ((age >= 25) && (age < 50)) p = 3;
            //if ((age >= 50) && (age < 80)) p = 4;
            //if (age >= 80) p = 5;
            //switch (p)
            //{
            //    case 1: Console.WriteLine("ребёнок"); break;
            //    case 2: Console.WriteLine("юноша"); break;
            //    case 3: Console.WriteLine("зрелый"); break;
            //    case 4: Console.WriteLine("пожилой "); break;
            //    case 5: Console.WriteLine("старческий"); break;
            //    default:
            //        Console.WriteLine("Вы ввели отрицательное число."); break;
            //}
            //Console.ReadKey();
        }
    }
}

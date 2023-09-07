using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_6_02._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задача 6.  b присвоить значение c, а присвоить значение b, с присвоить значение а*/
            Console.WriteLine("Вваедите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
            int d;
            d= a;
            a = b;
            b = c;
            c = d;
            Console.WriteLine(a + " " + b + " " + c);
            /*b присвоить значение а, с присвоить значение b, а присвоить значение с*/
            Console.WriteLine(b + " " + c + " " + a);



        }
    }
}

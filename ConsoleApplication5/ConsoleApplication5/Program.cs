using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{

    class A
    {
        private int a; int b;
        public A()
        {
            try
            {
                Console.WriteLine("Введите a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }
        }
        public int c
        {
            get
            {
                if (a > b) return a;
                else return b;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine("Значение с = {0}", obj.c);
            Console.ReadKey();
        }
    }
}

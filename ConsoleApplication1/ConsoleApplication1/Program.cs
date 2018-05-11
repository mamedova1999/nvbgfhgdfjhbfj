using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class A
    {
        private int a; int b;
        public A()
        {
            a = 10;
            b = -11;
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

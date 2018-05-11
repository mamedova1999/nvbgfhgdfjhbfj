using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{

    public class Tochka
    {
        public Tochka(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double X
        {
            get;
            set;
        }
        public double Y
        {
            get;
            set;
        }
    }
    public class Krug
    {
        public double Radius
        {
            get;
            set;
        }
        public Tochka Center
        {
            get;
            set;
        }
        public Krug(double radius, Tochka center)
        {
            Radius = radius;
            Center = center;
        }
        public double PlosadKruga
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }
        public double DlinaOkruznosti
        {
            get { return Math.PI * 2 * Radius; }
        }
        public bool Vnutri(Tochka tochka)
        {
            Tochka vec = new Tochka(tochka.X - Center.X, tochka.Y - Center.Y);
            double dist = Math.Pow(vec.X, 2) + Math.Pow(vec.Y, 2);
            return dist <= Math.Pow(Radius, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводим координаты центра");
            Tochka tochka = new Tochka(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Координаты центра = {0},{1}", tochka.X, tochka.Y);
            Console.WriteLine("Вводим координаты радиус окружности и координаты новой точки");
            Krug mkrug = new Krug(double.Parse(Console.ReadLine()), tochka);
            Console.WriteLine("Входит ли точка в окружность {0}", mkrug.Vnutri(new Tochka(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))));
            Console.WriteLine("Площадь = {0}", mkrug.PlosadKruga);
            Console.WriteLine("Длина окружности = {0}", mkrug.DlinaOkruznosti);
            Console.ReadKey();
        }
    }
}

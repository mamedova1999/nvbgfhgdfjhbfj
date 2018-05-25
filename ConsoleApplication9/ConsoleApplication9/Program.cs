using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classs
{
    public class IEngine // создаем интерфейс Двигатель
    {
        int Power //задаем свойство Мощность
        {
            get;
            set;
        }
        int Speed
        {
            get;
            set;
        }
        void GetPower()
        { }
        void GetSpeed()
        { }
    }

    class GasolinEngine : IEngine //создаем класс Двигатель внутреннего сгорания
    {
        private int Power1;
        private int Speed1;
        public GasolinEngine(int Power, int Speed)
        {
            Power1 = Power;
            Speed1 = Speed;
        }
        public int Power
        {
            get { return Power; }
            set { Power = value; }
        }
        public int Speed
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public void GetPower()
        {
            Console.WriteLine("  Мощность : " + Power1 + " л.с");
        }
        public void GetSpeed()
        {
            Console.WriteLine("  Число оборотов :" + Speed1);
        }


    }
    class RocketEngine : IEngine  //создаем класс Реактивный двигатель
    {
        private int Power1;
        private int Speed1;
        public RocketEngine(int Power, int Speed)
        {
            Power1 = Power;
            Speed1 = Speed;
        }
        public int Power
        {
            get { return Power; }
            set { Power = value; }
        }
        public int Speed
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public void GetPower()
        {
            Console.WriteLine("  Мощность : " + Power1 + " л.с");
        }
        public void GetSpeed()
        {
            Console.WriteLine("  Число оборотов :" + Speed1);
        }
    }
    class dizel : GasolinEngine //создаем класс Реактивный двигатель
    {
        public dizel(int Power, int Speed) : base(Power, Speed)
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Двигатель внутреннего сгорания");
            GasolinEngine gas = new GasolinEngine(200, 300);
            gas.GetPower();
            gas.GetSpeed();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Реактивный двигатель");
            RocketEngine rock = new RocketEngine(5000, 400);
            rock.GetPower();
            rock.GetSpeed();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Дизель");
            dizel diz = new dizel(210, 100);
            diz.GetPower();
            diz.GetSpeed();
            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }
    }
}

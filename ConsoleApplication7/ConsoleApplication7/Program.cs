using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3
{
    class Tchka
    {
        public int Koordinatax, Koordinatay;
        public Tchka()
        {
            Koordinatax = Koordinatay = 0;
        }
        public void Position(int x, int y)
        {

            Koordinatax = x;
            Koordinatay = y;
        }
    }
    class ColorTchka : Tchka
    {
        public byte r;
        public byte g;
        public byte b;

        public void Color(byte R, byte G, byte B)
        {
            r = R;
            g = G;
            b = B;
        }
        public int KoordinataX()
        {
            return Koordinatax;
        }
        public int KoordinataY()
        {
            return Koordinatay;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ColorTchka color = new ColorTchka();
            color.Position(0, 0);
            color.Color(17, 15, 0xFF);
            Console.WriteLine("Координаты точки = ({0},{1})",
                color.KoordinataX(), color.KoordinataY());
            Console.WriteLine("Цвет точки =({0},{1},{2}) ", color.r, color.g, color.b);
            Console.ReadLine();

        }
    }
}

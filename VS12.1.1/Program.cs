using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS12._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Сircle.Length(4));
            Console.WriteLine(Сircle.Squar(4));
            Console.WriteLine(Сircle.Сheck(8, 0, 0, 5, 6));
            Console.ReadKey();
        }
        static class Сircle
        {
            //метод, определяющий длину окружности по заданному радиусу;
            public static double Length(double radius)
            {
                double lengthСircle = 2 * Math.PI * radius;
                return lengthСircle;
            }
            //метод, определяющий площадь круга по заданному радиусу;
            public static double Squar(double radius)
            {
                double square = Math.PI * Math.Pow(radius, 2);
                //Console.WriteLine("Площадь круга = {0:0.f2}", square);
                return square;

            }
            //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
            public static bool Сheck(double radius, int xO, int yO, int x, int y)
            {                
                if (radius >= Math.Sqrt(Math.Pow(xO - x, 2) + Math.Pow(yO - y, 2)))
                {
                    Console.Write("Точка принадлежит кругу ");
                    return true;
                }
                else
                {
                    Console.Write("Точка не принадлежит кругу ");
                    return false;
                }
            }
        }


    }

}

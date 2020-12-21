using System;

namespace ArchitectArithmetic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Rect(2500, 1500));
            Console.WriteLine(Circle(375));
            Console.WriteLine(Triangle(750, 500));
            double totalArea = Rect(2500,500) + 0.5*Circle(375) + Triangle(750,500);
            Console.WriteLine(totalArea);
            //total cost in Mexican Pesos
            double mxPesos = Math.Round(totalArea * 180);
            Console.WriteLine($"The total cost to build Teotihuacan is {mxPesos} pesos");

            static double Rect(double length, double width)
            {
                return length * width;
            }
            static double Circle(double radius)
            {
                return Math.PI * Math.Pow(2, 2);
            }

            static double Triangle(double bottom, double height)
            {
                return 0.5 * bottom * height;
            }
         

        }
    }
}

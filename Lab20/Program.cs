using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double raidius);
        static void Main(string[] args)
        {
            Console.Write("Введите значение радиуса: ");
            double r = double.Parse(Console.ReadLine());
            MyDelegate mydelegate = iLangth;
             double d= mydelegate(r);
              Console.WriteLine("Длина окружности равна: {0:f2}", d);

            mydelegate = Square;
              d = mydelegate(r);
              Console.WriteLine("Площадь круга равна: {0:f2}", d);

            mydelegate = volume;
              d = mydelegate(r);
              Console.WriteLine("Объем шара равен: {0:f2}", d);
            Console.ReadKey();

        }
       

        static double iLangth(double r) => 2 * Math.PI * r;

        static double Square(double r) => Math.PI * Math.Pow(r, 2);

        static double volume(double r) =>   Math.PI * 4/3 * Math.Pow(r, 3);
    }

   
   
}

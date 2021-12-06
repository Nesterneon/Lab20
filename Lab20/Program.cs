using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Сircumference;
            if (myDelegate != null)
            {
                double r = myDelegate(3);
                Console.WriteLine("{0:.000}", r);
            }
            myDelegate = Areaof​​acircle;
            if (myDelegate != null)
            {
                double r = myDelegate(3);
                Console.WriteLine("{0:.000}",r);
            }
            myDelegate = Sharpvolume;
            if (myDelegate !=null)
            {
                double r = myDelegate(3);
                Console.WriteLine("{0:.000}",r);
            }
            Console.ReadKey();
        }

        static double Сircumference(double r)
        {
            Console.WriteLine("Длина окружности:");
            return 2 * Math.PI * r;
        }

        static double Areaof​​acircle(double r)
        {
            Console.WriteLine("Площадь круга:");
            return Math.PI * Math.Pow(r,2);
        }

        static double Sharpvolume(double r)
        {
            Console.WriteLine("Объем шара:");
            return 4/3 * Math.PI * Math.Pow(r, 3);
        }
    }
}

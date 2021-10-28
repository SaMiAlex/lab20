using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20
{
    class Program
    {
        delegate double Calc(double x);
        static void Main(string[] args)
        {
            double R = 100;
            Calc length = GetL;
            Calc square = GetS;
            Calc vol = GetV;
            double L = length(R);
            double S = square(R);
            double V = vol(R);
            Console.WriteLine($"Длина окружности радиусом {R} - {L:f2}\nПлощадь круга радиусом {R} - {S:f2}\nОбъем шара радиусом {R} - {V:f2}");
            Console.ReadKey();
        }
        static double GetL(double x)
        {
            return 2 * Math.PI * x;
        }
        static double GetS(double x)
        {
            return Math.PI * x * x;
        }
        static double GetV(double x)
        {
            return 4 * Math.PI * x * x * x / 3;
        }
    }
}

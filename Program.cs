using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб2_зад1_САВДЕЙ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = CheckPoint(x, y);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static bool CheckPoint(double x, double y)
        {

            if (y < 0 && y > x - 1 && y > -x - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

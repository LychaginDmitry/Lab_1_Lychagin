using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_1_Lychagin
{
    class Program
    {
        public static int Input(string[] args, int i)
        {
            int a;
            try
            {
                if (args.Length != 3)
                    a = Convert.ToInt32(Console.ReadLine());
                else
                {
                    a = Convert.ToInt32(args[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Format");
                a = Input(args, i);
            }
            return a;
        }
        public static void Solution(string[] args)
        {
            double a, b, c, D, x1, x2; //a,b,c - исходные переменные, вводимые с клавиатуры; D - дискриминант; x1, x2 - искомые корни квадратного уравнения
            Console.WriteLine(" Данная программа создана для вычисления корней квадратного уравнения вида: a*x^2 + b*x + c \n");
            Console.WriteLine("Введите коэффиценты квадратного уравнения в формате a*x^2 +b * x + c\n");

            Console.WriteLine("Введите a: ");
            a = Input(args, 0);
            Console.WriteLine("Введите b: ");
            b = Input(args, 1);
            Console.WriteLine("Введите c: ");
            c = Input(args, 2);

            if (a == 0)
            {

                if (b == 0)
                {
                    Console.WriteLine("Данное уравнение решить нельзя");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Введеное уравнение является линейным\n");
                    x1 = -c / b;
                    Console.WriteLine("x = {0}", x1);
                    Console.ReadKey();
                }
            }

            else
            {
                D = Math.Pow(b, 2) - 4 * a * c;
                Console.Write("Дискриминант D = ");
                Console.WriteLine(D);
                if (D > 0 || D == 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Корней у данное уравнения нет");
                    Console.ReadKey();
                }
            }

        }
        static void Main(string[] args)
        {
            Solution(args);
        }
    }
}

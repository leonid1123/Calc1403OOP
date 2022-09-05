using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oper oper = new Oper();
            Regex regex = new Regex(@"(\d*)", RegexOptions.IgnoreCase);
            double i;
            string d;
            double j;
            Console.Clear();
            Console.WriteLine("Добро пожаловать в калькулятор. " +
                "Нажмите Y если хотите продолжить или N чтобы выйти из калькулятора");
            do
            {
                Console.WriteLine("введите первое число и нажмите ввод");

                ConsoleKeyInfo f = Console.ReadKey();

                //сделать сравнение символов тут

                i = Double.Parse(Console.ReadLine());
                

                 d = Console.ReadLine();

                 j = Double.Parse(Console.ReadLine());

                if (d.Equals("+"))
                {
                    oper.Slozh(i, j);
                }
                else if (d.Equals("-"))
                {
                    oper.Vich(i, j);
                }
                else if (d.Equals("*"))
                {
                    oper.Umnozh(i, j);
                }
                else if (d.Equals("/") & j != 0)
                {
                    oper.Deleniye(i, j);
                }
                else
                {
                    Console.WriteLine("Очень Криворукий!!!");
                }

                Console.WriteLine(oper.res);
                //Console.ReadLine();
            } while (true);
        }
        public class Oper
        {
            public double res;
            public void Slozh(double a, double b)
            {
                res = a + b;
            }
            public void Vich(double a, double b)
            {
                res = a - b;
            }
            public void Deleniye(double a, double b)
            {
                res = a / b;
            }
            public void Umnozh(double a, double b)
            {
                res = a * b;
            }
        }
    }
}

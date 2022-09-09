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
            Regex regex = new Regex(@"^[0-9]+$");
            Regex regex1 = new Regex(@"(^[+-/*]+$)");
            double pervoeChislo;
            string znakDeystviya;
            double vtoroeChislo;
            string vvodPolzovatelya; 
            Console.Clear();
            Console.WriteLine("Добро пожаловать в калькулятор. " +
                "Нажмите Y если хотите продолжить или N чтобы выйти из калькулятора");
            //сюда дописать выход из калькулятора
            do
            {
                int proverkaNevernogoVvoda = -1;
                do
                {
                    proverkaNevernogoVvoda++;
                    Console.WriteLine("введите первое число и нажмите ввод");
                    if (i>0) { Console.WriteLine("ты дурачок?"); }
                    vvodPolzovatelya = Console.ReadLine();
                } while (!regex.IsMatch(vvodPolzovatelya));//до тех пор пока не даст правильное
                pervoeChislo = Double.Parse(vvodPolzovatelya);
                //написать метод для проверки ввода пользователя



                znakDeystviya = Console.ReadLine();

                vtoroeChislo = Double.Parse(Console.ReadLine());

                if (znakDeystviya.Equals("+"))
                {
                    oper.Slozh(pervoeChislo, vtoroeChislo);
                }
                else if (znakDeystviya.Equals("-"))
                {
                    oper.Vich(pervoeChislo, vtoroeChislo);
                }
                else if (znakDeystviya.Equals("*"))
                {
                    oper.Umnozh(pervoeChislo, vtoroeChislo);
                }
                else if (znakDeystviya.Equals("/") & vtoroeChislo != 0)
                {
                    oper.Deleniye(pervoeChislo, vtoroeChislo);
                }
                else
                {
                    Console.WriteLine("Очень Криворукий!!!");
                }

                Console.WriteLine(oper.res);
                //Console.ReadLine();
            } while (true);
        }
        public class Proverki
        {

            public bool ProverkaVvoda(string _vvod, string _sravnenie)
            {

            }
        }
        public class Oper
        {
            public double res = Double.NaN;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Practicheskaya2
    {

        double num_one;
        double num_two;

        public void plus(double num_one, double num_two)
        {
            Console.WriteLine(num_one + num_two);
        }
        public void minus(double num_one, double num_two)
        {
            Console.WriteLine(num_one - num_two);
        }
        public void umnoshenie(double num_one, double num_two)
        {
            Console.WriteLine(num_one * num_two);
        }
        public void delenie(double num_one, double num_two)
        {
            if (num_two == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                Console.WriteLine(num_one / num_two);
            }

        }
        public void sqrt(double num_one, double num_two)
        {
            Console.WriteLine(Math.Sqrt(num_one));
            Console.WriteLine(Math.Sqrt(num_two));
        }
        public void stepen(double num_one, double num_two)
        {
            Console.WriteLine(Math.Pow(num_one, num_two));
        }
        public void okryglenie(double num_one, double num_two)
        {
            Console.WriteLine(Math.Round(num_one));
        }

        public void arksin(double num_one, double num_two)
        {
            Console.WriteLine(Math.Atan(num_one));
        }
        public void tan(double num_one, double num_two)
        {
            Console.WriteLine(Math.Tan(num_one));
        }
        public void tanh(double num_one, double num_two)
        {
            Console.WriteLine(Math.Tanh(num_one));
        }
        public void perimetr(double num_one, double num_two)
        {
            Console.WriteLine((num_one + num_two) * 2);
        }
        public void ploshadpr(double num_one, double num_two)
        {
            Console.WriteLine(num_one * num_two);
        }

        public void g(double num_one, double num_two)
        {
            Console.WriteLine(num_one * num_two);
        }
        public void plcube(double num_one)
        {
            Console.WriteLine(Math.Pow(num_one, 6));
        }
    }
}
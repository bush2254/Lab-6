using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
             double eps= 0.001;
            double x =double.Parse(Console.ReadLine());
            double S = 0;
            int N = 0;
            double A = x ;
            do
            {
                S = S + A;
                N += 1;
                A = A* N * N / ((N + 1) * (N + 1));
                Console.WriteLine(A);
            }
            while (A >= eps);
            Console.WriteLine($"Сумма членов ряда S={S}число итераций N={N}");
        }
    }
}
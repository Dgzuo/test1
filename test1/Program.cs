using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x0, y0, x1, y1;
                Console.WriteLine("Введите координаты A\n");
                Console.Write("X0: ");
                x0 = int.Parse(Console.ReadLine());
                Console.Write("Y0: ");
                y0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите координаты B\n");
                Console.Write("X1: ");
                x1 = int.Parse(Console.ReadLine());
                Console.Write("Y1: ");
                y1 = int.Parse(Console.ReadLine());

                double r1 = Math.Sqrt(Math.Pow(x0, 2) + Math.Pow(y0, 2)); 
                double r2 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)); 

                if (r1 == r2)
                    Console.WriteLine("равны");
                else if(r1 > r2)
                    Console.WriteLine("B ближе к 0");
                else
                    Console.WriteLine("A ближе к 0");


                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

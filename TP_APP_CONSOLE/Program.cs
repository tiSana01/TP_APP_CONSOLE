using System;

namespace TP_APP_CONSOLE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Résolution de l'équation quadratique ax^2 + bx + c = 0");

            Console.Write("Entrez le coefficient a : ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez le coefficient b : ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez le coefficient c : ");
            double c = Convert.ToInt32(Console.ReadLine());

            Solution solution = Solve(a, b, c);

            solution.Print();
        }
        public static Solution Solve(double a, double b, double c)
        {
            Solution solution = new Solution();

            // Cas où a = 0 (équation linéaire bx + c = 0)
            if (a == 0)
            {
                if (b == 0)
                {
                    solution.Count = 0;
                }
                else
                {
                    solution.Count = 1;
                    solution.X1 = -c / b;
                }
                return solution;
            }

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                solution.Count = 2;
                solution.X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                solution.X2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                solution.Count = 1;
                solution.X1 = -b / (2 * a);
            }
            else
            {
                solution.Count = 0;
            }

            return solution;
        }
    }
}


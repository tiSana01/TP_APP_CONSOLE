using System;

namespace TP_APP_CONSOLE
{
    public class Solution
    {
        public int Count { get; set; } 
        public double X1 { get; set; } 
        public double X2 { get; set; } 

        public Solution()
        {
            Count = 0;
            X1 = 0;
            X2 = 0;
        }

        public void Print()
        {
            if (Count == 0)
            {
                Console.WriteLine("Pas de solution réelle.");
            }
            else if (Count == 1)
            {
                Console.WriteLine($"Une seule solution : X = {X1}");
            }
            else
            {
                Console.WriteLine($"Deux solutions : X1 = {X1}, X2 = {X2}");
            }
        }
    }
}

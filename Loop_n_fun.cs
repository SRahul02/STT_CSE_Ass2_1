using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Loop_n_fun
    {
        public void ForLoop()
        {
            Console.WriteLine("Printing 1-10 using 'for' loop -->");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void ForEachLoop()
        {
            Console.WriteLine("\nPrinting 1-10 using 'foreach' loop -->");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // We need a collection to loop "over"

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void DoWhileLoop()
        {
            Console.WriteLine("\n'Do-While' loop: Enter 'exit' to stop -->");
            string input;
            do
            {
                Console.Write("Enter a command (or 'exit'): ");
                input = Console.ReadLine();
            }
            while (input != "exit");

            Console.WriteLine("Exiting loop!\n");
        }

        public static long Factorial(int n)
            // We can call it without creating an object.
        {
            if (n == 0) {return 1;}

            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact*i;
            }
            return fact;
        }
    }
}

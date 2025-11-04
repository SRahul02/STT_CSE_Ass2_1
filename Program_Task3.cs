namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loop_n_fun loops = new Loop_n_fun();

            loops.ForLoop();
            loops.ForEachLoop();
            loops.DoWhileLoop(); // This will loop until you type 'exit'

            Console.WriteLine("Factorial Calculation -->");
            Console.Write("Enter a number to calculate its factorial: ");

            int num = Convert.ToInt32(Console.ReadLine());
            long result = Loop_n_fun.Factorial(num);

            Console.WriteLine($"The factorial of {num} is: {result}");
        }
    }
}
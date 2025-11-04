namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc call_to_calculator = new Calc();

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double tot = call_to_calculator.Add(num1, num2);
            double diff = call_to_calculator.Subtract(num1, num2);
            double prod = call_to_calculator.Multiply(num1, num2);
            double quot = call_to_calculator.Divide(num1, num2);

            string even_Or_odd = call_to_calculator.CheckOdd(tot);
            Console.WriteLine($"\n--- Results ---");
            Console.WriteLine($"Addition: {num1} + {num2} = {tot}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {diff}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {prod}");
            Console.WriteLine($"Division: {num1} / {num2} = {quot}");
            Console.WriteLine($"The sum ({tot}) is: {even_Or_odd}");
        }
    }
}

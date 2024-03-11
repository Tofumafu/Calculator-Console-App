internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choose an Operator: ");
        Console.WriteLine();
        string[] Operators = { "\t a = Addition", "\t s = Subtraction", "\t m = Multiplication", "\t d = Division" };
        for (int i = 0; i < Operators.Length; i++)
        {
            Console.WriteLine(Operators[i]);
        }

        switch (Console.ReadLine())
        {
            case "a":
            {
                    Console.WriteLine("Type First Number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type Second Number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(number1 + number2);
                    break;
            }
            case "s":
            {
                    Console.WriteLine("Type First Number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type Second Number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(number1 - number2);
                    break;
            }
            case "m":
            {
                    Console.WriteLine("Type First Number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type Second Number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(number1 * number2);
                    break;
            }
            case "d":
            {
                    Console.WriteLine("Type First Number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type Second Number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Answer: " + number1 / number2);
                    break;
            }
        }
    }   
}

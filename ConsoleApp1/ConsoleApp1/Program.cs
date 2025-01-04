class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Enter the first number");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("You entered a non-number");
            return;
        }

        Console.WriteLine("Enter the second number");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("You entered a non-number");
            return;
        }

        Console.WriteLine("Enter the logical operation symbol: &, |, ^");
        var c = Console.ReadLine();
        if (c != "&" && c != "|" && c != "^")
        {
            Console.WriteLine("Enter one of three characters: &, |, ^");
            return;
        }

        switch (c)
        {
            case "&":
                Console.WriteLine(Convert.ToString(a & b));
                Console.WriteLine(Convert.ToString(a & b, 2));
                Console.WriteLine(Convert.ToString(a & b, 16));
                break;
            case "|":
                Console.WriteLine(Convert.ToString(a | b));
                Console.WriteLine(Convert.ToString(a | b, 2));
                Console.WriteLine(Convert.ToString(a | b, 16));
                break;
            case "^":
                Console.WriteLine(Convert.ToString(a ^ b));
                Console.WriteLine(Convert.ToString(a ^ b, 2));
                Console.WriteLine(Convert.ToString(a ^ b, 16));
                break;
        }
    }
}

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

        //Домашнее задание по массивам
        //Задача "А"

        int[] arrFib = new int[] {0,1,1,2,3,5,8,13};
        string[] arrMonths = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        int[][] arrTwo = new int[3][] { new[] {2, 3, 4}, new[] {4, 9, 16}, new[] {8, 27, 64} };
        double[][] arrMath = new double[3][] { new[] {1.0,2.0,3.0,4.0,5.0}, new[] {Math.E, Math.PI}, new[] {Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)} };

        //Задача "Б"

        int[] array = {1, 2, 3, 4, 5};
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
        Array.Copy(array, array2, 3);
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }
        Array.Resize(ref array, array.Length * 2);
        Console.WriteLine(array.Length);
    }
}

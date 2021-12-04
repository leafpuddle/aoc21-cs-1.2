using System;

class Program
{
    static void Main(string[] args)
    {
        string input = System.IO.File.ReadAllText("./input.txt");
        string[] inputs = input.Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None
        );

        int result = 0;

        for(int i = 0; i < inputs.Length; i++)
        {
            if( i == 0 || i >= inputs.Length - 2 ) continue;

            int.TryParse(inputs[i - 1], out int n1);
            int.TryParse(inputs[i], out int b);
            int.TryParse(inputs[i + 1], out int p1);
            int.TryParse(inputs[i + 2], out int p2);

            if( (b + p1 + p2) > (n1 + b + p1) ) result++;
        }

        Console.WriteLine("Result: " + result);
        Console.ReadKey();
    }
}

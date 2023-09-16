using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("Cycle");
        Console.WriteLine("Write k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int l = 7;
        int n = 5;
        int m = 10;
        int pathLenght = 0;

        for (int i = 1; i <= k; i++)
        {
            pathLenght += l * 2 + 2 * n + 2 * m * i;
        }

        Console.WriteLine(pathLenght);
    }
}

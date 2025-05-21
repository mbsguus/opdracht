using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{

    //Example Input

    //6
    //4
    //1 2 3 4 5 6

    //Expected Output:

    //2

    static public void Main()
    {
        // Read N
        int N = Convert.ToInt32(Console.ReadLine());

        // Read K
        int K = Convert.ToInt32(Console.ReadLine());

        // Read array
        string[] parts  = Console.ReadLine().Split(' ');
        int[] arr       = Array.ConvertAll(parts, int.Parse);

        // Call the function
        int result = Max(N, K, arr);
        Console.WriteLine(result);
    }

    static int Max(int N, int K, int[] arr)
    {
        // TODO: Implement the logic here

        return 0;
    }
}
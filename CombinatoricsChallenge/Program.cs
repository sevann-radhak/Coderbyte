using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Claims;
using System;

internal class MainClass
{
    /// <summary>
    /// For this challenge you will determine how many different ways you can walk up a flight of stairs.
    /// have the function CombinatoricsChallenge(num) take the num parameter beig passed wich will be an integer beween 1 and 1000 that represents the number of stairs you will have to climb.you can climb the set of stairs by taking either 1 step or 2 steps, and you can combine these in any order.So for example, to climb 3 steps you can either do: (1 step, 1 step, 1 step) or(2, 1) or(1, 2). So for 3 steps we have 3 different ways to climb them, so your program should return 3. Your program should return the number of combinations of climbing num steps.
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static int CombinatoricsChallenge(int num)
    {
        if (num <= 2)
        {
            return num;  // Base cases: 1 way for 1 step, 2 ways for 2 steps
        }
        int[] ways = new int[num + 1];
        ways[1] = 1;
        ways[2] = 2;

        // Calculate ways for each step using dynamic programming
        for (int i = 3; i <= num; i++)
        {
            ways[i] = ways[i - 1] + ways[i - 2];
        }
        return ways[num];
    }

    private static void Main()
    {
        int numSteps = 8; // Input
        Console.WriteLine(CombinatoricsChallenge(numSteps));
    }
}

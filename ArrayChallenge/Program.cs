internal class MainClass
{
    public static int ArrayChallenge(int[] arr)
    {
        Array.Sort(arr);  // Sort the array in ascending order
        int sum = 0;

        // Calculate the sum of the four largest elements
        for (int i = arr.Length - 1; i >= Math.Max(arr.Length - 4, 0); i--)
        {
            sum += arr[i];
        }

        return sum;
    }

    private static void Main()
    {
        int[] inputArray = { 4, 5, -2, 3, 1, 2, 6, 6 }; // Input value
        Console.WriteLine(ArrayChallenge(inputArray));
    }
}

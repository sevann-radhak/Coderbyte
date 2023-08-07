internal class MainClass
{
    /// <summary>
    /// For this challenge you will need to find the four largest elements in an array.
    /// have he function arrayChallenge(arr) take the array of integers stored in arr, and find the four largest elements and return their sum. For example: if arr is [4, 5, -2, 3, 1, 2, 6, 6] then the four largest elements in this array are 6, 6, 5, 4 and the total sum of these numbers is 21, so your program shoould return 21. If there are less than four numbers in the array, your program should return the sum of all numbers in the array.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
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

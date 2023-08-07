internal class MainClass
{
    /// <summary>
    /// For this challenge you will be reducing a string of roman numerals.
    /// Have the function StringCallenge(str) read str which will be a string of roman numerals in decreasing order. The numerrals being used are: I for 1, V for 5, X for 10, L for 50, C for 100, D for 500 and M for 1000. Your program wwhould return the same number given by str using a smaller set of roman numerals. For example: if str is "LLLXXXVVVV" THIS IS 200, SO YOUR PROGRAM SHOULD RETURN CC because this is the shortest way to write 200 using the roman numeral system given above. If a string is given in its shortest form, just return that same string.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string StringChallenge(string str)
    {
        string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        int num = 0;
        string result = string.Empty;

        for (int i = 0; i < romanNumerals.Length; i++)
        {
            while (str.StartsWith(romanNumerals[i]))
            {
                num += values[i];
                str = str[romanNumerals[i].Length..];
            }
        }

        for (int i = 0; i < values.Length; i++)
        {
            while (num >= values[i])
            {
                num -= values[i];
                result += romanNumerals[i];
            }
        }

        return result;
    }

    private static void Main()
    {
        string str = "LLLXXXVVVV"; // Input
        Console.WriteLine(StringChallenge(str));
    }
}

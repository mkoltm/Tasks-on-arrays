using System;

class PalindromeChecker
{
    public bool IsPalindrome(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        return str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        string input = "level";
        PalindromeChecker palindromeChecker = new PalindromeChecker();
        bool isPalindrome = palindromeChecker.IsPalindrome(input);
        Console.WriteLine("Is Palindrome: {0}", isPalindrome);
    }
}

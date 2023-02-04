using System;

namespace PalindromeChecker
{
    class PalindromeException : Exception
    {
        public PalindromeException(string? message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(IsPalindrome("anna"));
                Console.WriteLine(IsPalindrome("anna"));
                Console.WriteLine(IsPalindrome("anna"));
                Console.WriteLine(IsPalindrome("an21a"));
                Console.WriteLine(IsPalindrome("anna"));
            }
            catch (PalindromeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new PalindromeException("Входная строка имеет значение null или пуста.");

            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                {
                    throw new PalindromeException("Входная строка не является палиндромом.");
                }
            }

            return true;
        }
    }
}
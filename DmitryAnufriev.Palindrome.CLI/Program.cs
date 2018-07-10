using System;

namespace DmitryAnufriev.Palindrome.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            var input = Console.ReadLine();
            var a =
                new ChSqWithoutWhitespace(
                    new ChSqLowered(
                        new ChSqString(
                            input
                        )
                    )
                );
            var b =
                new ChSqWithoutWhitespace(
                    new ChSqLowered(
                        new ChSqReversedString(
                            input
                        )
                    )
                );
            Console.WriteLine(a.Equals(b) ? "It's a palindrome!" : "It's not a palindrome.");
        }
    }
}
using System;

// write an extention method to validate a sting value
// if string is null empty, throw ArgumentException
// if string is not a valid number, throw Format Exception
// handle exceptions in main function
// if all good, print the string, as integer, at console


namespace ExtensionMethod_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var line = Console.ReadLine();
                line.ValidateString();

                var parsedLine = int.Parse(line);
                Console.WriteLine(parsedLine);
            }

            catch (ArgumentException e)
            {
            }
            catch (FormatException e)
            {
            }
        }
    }

    static class StringExtension
    {
        public static void ValidateString(this string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                throw new ArgumentException();
            }
            else if (!int.TryParse(line, out int number))
            {
                throw new FormatException();
            }
        }
    }
}

using System;

namespace CSharpWarmup
{
    class Program
    {        

        static void Main(string[] args)
        {
            Console.WriteLine("Begin Sierra->MiscApp");

            while (true)
            {
                ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                if(input.ToLower() == "factorial")
                {
                    Console.WriteLine("Type an integer");
                    ReadLine();

                    int parsedNum = 0;
                    bool parseSucceded = false;

                    try
                    {
                        parsedNum = Int32.Parse(input);
                        parseSucceded = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Unable to parse '{input}'");
                    }

                    if (parseSucceded)
                    {
                        int nFactorial = 1;
                        for (int i = 1; i <= Math.Abs(parsedNum); i++)
                        {
                            nFactorial *= (parsedNum > 0) ? i : -i;
                        }

                        Console.WriteLine($"Factorial of '{parsedNum}' is '{nFactorial}'");
                    }
                }
    
            }
        }

        static string input = String.Empty;
        static void ReadLine() { input = Console.ReadLine(); }
    }

}

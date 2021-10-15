using RegexAssignmentLibrary;
using System;
using System.Collections.Generic;

namespace RegexAssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = MethodService.StringComparisonRecursion("fiets", "fiets", 0);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static void ShowResults(CSharpFunctionalExtensions.Result<string> result)
        {
            if (result.IsFailure)
            {
                Console.WriteLine(result.Error);
            }
            else
            {
                Console.WriteLine(result.Value);
            }
        }
    }
}

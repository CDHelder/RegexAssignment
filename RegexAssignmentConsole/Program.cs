using RegexAssignmentLibrary;
using System;
using System.Collections.Generic;

namespace RegexAssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = MethodService.StringCompareExtraCharacters("fiets", "fiets");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

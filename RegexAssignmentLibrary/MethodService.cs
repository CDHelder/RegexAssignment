﻿using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAssignmentLibrary
{
    public static class MethodService
    {
        public static bool StringComparisonRecursion(string input, string compareString, int lastindex)
        {
            if (lastindex == 0)
            {
                if (input.Length != compareString.Length)
                    return false;
            }

            int index = lastindex;
            if (index > input.Length - 1)
            {
                return true;
            }
            else if (input[index] != compareString[index])
            {
                return false;
            }

            index++;

            if (StringComparisonRecursion(input, compareString, index))
            {
                return true;
            }
            return false;
        }

        public static bool StringComparisonSimplified(string input, string compareString)
        {
            if (input.Length != compareString.Length)
                return false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != compareString[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static Result<string> StringComparison(string input, string compareString)
        {
            if (input.Length != compareString.Length)
            {
                string error = $"input length:{input.Length} is not equal to comparison string length: {compareString.Length}";
                return Result.Failure<string>(error);
            }

            string goodChars = "";
            Dictionary<char, char> badChars = new Dictionary<char, char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != compareString[i])
                {
                    badChars.Add(input[i], compareString[i]);
                    //volgende in loop
                    continue;
                }

                goodChars += input[i];
            }

            if (badChars.Count() > 0)
            {
                string error = $"Symmetrical Values: {goodChars} \nAsymmetrical Values: Input:{badChars.Keys} Comparison: {badChars.Values}";
                return Result.Failure<string>(error);
            }

            return Result.Success($"Symmetrical Values: {goodChars} \nInput:{input}, Comparion:{compareString}");
        }

        public static bool IsMatch(string s, string p)
        {
            if (s != p)
            {
                return false;
            }

            foreach (var character in s)
            {

            }

            return false;
        }
    }
}

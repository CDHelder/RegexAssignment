using RegexAssignmentLibrary;
using System;
using Xunit;

namespace RegexAssignmentTest
{
    public class StringComparisonSimplifiedTest
    {
        [Theory]
        [InlineData("fiets", "fiets", true)]
        [InlineData("fiets", "fietz", false)]
        [InlineData("fiets", "fi420", false)]
        [InlineData("fiets", "fiETS", false)]  
        [InlineData("", "", true)]
        [InlineData("", "hallo", false)]
        public void Test(string input, string compare, bool expectedResult)
        {
            var result = MethodService.StringComparisonSimplified(input, compare);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("fiets", "fiets", true)]
        [InlineData("fiets", "fietz", false)]
        [InlineData("fiets", "fi420", false)]
        [InlineData("fiets", "fiETS", false)]
        [InlineData("", "", true)]
        [InlineData("", "hallo", false)]
        public void Test2(string input, string compare, bool expectedResult)
        {
            var result = MethodService.StringComparisonRecursion(input, compare, 0);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("fiets", "fiets", true)]
        [InlineData("fiets", "fietz", false)]
        [InlineData("fiets", "fi420", false)]
        [InlineData("fiets", "fiETS", false)]
        [InlineData("", "", true)]
        [InlineData("", "hallo", false)]

        [InlineData("a*A", "aA", true)]
        [InlineData("a*A", "aaaA", true)]
        [InlineData("a*A", "Aa", false)]
        [InlineData("a*A", "aaaZ", false)]

        [InlineData(".*", "sdfgsdfgsfg", true)]

        [InlineData("a.A", "aaA", true)]
        [InlineData("a.A", "aaaA", false)]

        [InlineData("a*", "aa", true)]
        [InlineData("mis*is*ip*.", "mississippi", true)]

        public void Test3(string input, string compare, bool expectedResult)
        {
            var result = MethodService.StringComparisonRecursionExtraCharacters(input, compare, 0 , 0, '\0');
            Assert.Equal(expectedResult, result);
        }
    }
}

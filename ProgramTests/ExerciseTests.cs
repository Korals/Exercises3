using System;
using System.Linq;
using Exercises;
using Xunit;

namespace ProgramTests
{
    public class ExerciseTests
    {
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("madam", true)]
        [InlineData("Wow", true)]
        [InlineData("john", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        public void IsPalindrome(string someString, bool expected)
        {
            var result = Program.IsPalindrome(someString);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("tacocat is fucking kot", 4)]
        [InlineData("madam is gay", 3)]
        [InlineData("Wow", 1)]
        [InlineData("john", 1)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        public void CountWords(string someString, int expected)
        {
            var result = Program.CountWords(someString);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(96, 4)]
        [InlineData(420, 320)]
        [InlineData(30, 70)]
        [InlineData(-130, 230)]
        [InlineData(99, 1)]
        [InlineData(100, 0)]
        public void HowFarFromOneHundred(int number, int expected)
        {
            var result = Program.HowFarFromOneHundred(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(96, 6)]
        [InlineData(420, 0)]
        [InlineData(30, 0)]
        [InlineData(-131, 1)]
        [InlineData(99, 9)]
        [InlineData(1001, 1)]
        public void GetTheLastDigitOfNumber(int number, int expected)
        {
            var result = Program.GetTheLastDigitOfNumber(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("hitacocat", true)]
        [InlineData("Himadam", true)]
        [InlineData("hIWow", true)]
        [InlineData("HIjohn", true)]
        [InlineData("Hi john", true)]
        [InlineData("hi- hIWow", true)]
        [InlineData("Wow", false)]
        [InlineData("hWow", false)]
        [InlineData("iWow", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        public void StartsWithHi(string input, bool expected)
        {
            var result = Program.StartsWithHi(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(96, 69)]
        [InlineData(42, 24)]
        [InlineData(36, 63)]
        [InlineData(131, 131)]
        [InlineData(92, 29)]
        [InlineData(123, 321)]
        public void ReverseNumber(int input, int expected)
        {
            var result = Program.ReverseNumber(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("beetroot is eee", 5)]
        [InlineData("mommy is elchocholeec", 3)]
        [InlineData("Wow", 0)]
        [InlineData("crusade", 1)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        public void HowManyEsInAString(string input, int expected)
        {
            var result = Program.HowManyEsInAString(input);
            Assert.Equal(expected, result);
        }
    }
}
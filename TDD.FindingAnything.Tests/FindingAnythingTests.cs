using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using TDD.FindAnything;

namespace TDD.FindingAnything.Tests
{
    [TestClass]
    public class FindingTests
    {

        [TestMethod]
        public void FindShortestWord_ShortWordSearchProcess_ShortWord()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            StringAssert.Contains("я", finder.FindShortestWord("Хейтеры говорят что я глухой"));
        }

        [TestMethod]
        public void CountWords_WordQuantity_True()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.AreEqual(5, finder.CountWords("Хейтеры говорят что я глухой"));
        }

        [TestMethod]
        public void CountCharacters_Count_28()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.AreNotEqual(20, finder.CountCharacters("Хейтеры говорят что я глухой"));
        }

        [TestMethod]
        public void FindNthCharacter_FindingCharacter_ia()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            string input = "example string"; 

            Regex regex = new Regex(finder.FindNthCharacter(input));

            StringAssert.DoesNotMatch("а", regex);
        }

        [TestMethod]
        public void CountDigits_Count_4()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.Fail("Тяжело");
        }

        [TestMethod]
        public void CountMaxConsecutiveDigits_CountMaxDigits_4()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.Inconclusive("525252");
        }

        [TestMethod]
        public void Test_CountOccurrences()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.IsNotNull(finder.CountOccurrences("Я такой ам ам ам", "ам"));
        }
    }
}

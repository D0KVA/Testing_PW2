using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Assert.AreEqual("я", finder.FindShortestWord("Хейтеры говорят что я глухой"));
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
            Assert.AreEqual(28, finder.CountCharacters("Хейтеры говорят что я глухой"));
        }

        [TestMethod]
        public void FindNthCharacter_FindingCharacter_ia()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.AreNotEqual("я", finder.FindNthCharacter("Хейтеры говорят что я глухой"));
        }

        [TestMethod]
        public void CountDigits_Count_4()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.AreEqual(4, finder.CountDigits("Хейтеры говорят что 1337"));
        }

        [TestMethod]
        public void CountMaxConsecutiveDigits_CountMaxDigits_4()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.AreEqual(4, finder.CountMaxConsecutiveDigits("Хейтеры говорят 123 1337"));
        }

        [TestMethod]
        public void Test_CountOccurrences()
        {
            FindingAnythingWord finder = new FindingAnythingWord();
            Assert.AreEqual(3, finder.CountOccurrences("Я такой ам ам ам", "ам"));
        }

    }
}

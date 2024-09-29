using System.Linq;

namespace TDD.FindingAnything
{
    public class FindingAnythingWord
    {
        public string FindShortestWord(string input)
        {
            return input.Split(' ').OrderBy(word => word.Length).First();
        }


    }
}
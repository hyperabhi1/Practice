using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class WeightedUniformStrings : IHackerRankContract
    {
        /// <summary>
        /// Source URL : https://www.hackerrank.com/challenges/weighted-uniform-string/problem?isFullScreen=false&utm_campaign=challenge-recommendation&utm_medium=email&utm_source=60-day-campaign
        /// </summary>
        /// <param name="input">aabbccdd/aaas/asdasdasda</param>
        /// <param name="inputList">{1,3,12,5,9,10}/{1,3,12,5}</param>
        /// <returns>List of string</returns>
        public List<string> GetWightedUniformString(string input, List<int> inputList)
        {
            var inputCharCountPairs = GetCharCountInString(input);
            List<int> charPermutedSums = new List<int>();
            foreach(KeyValuePair<char, int> charKeyValue in inputCharCountPairs)
                charPermutedSums.AddRange(GetCharPermutatedSum(charKeyValue));
            return GetIntersectionRespectively(inputList, charPermutedSums);
        }
        private Dictionary<char,int> GetCharCountInString(string input)
        {
            Dictionary<char, int> charCountPairs = new Dictionary<char, int>();
            foreach(char c in input)
            {
                int charCount = 0;
                if(!charCountPairs.Keys.Contains(c))
                {
                    foreach (char cc in input)
                    {
                        if (c.Equals(cc))
                            charCount++;
                    }
                    charCountPairs.Add(c, charCount);
                }
            }
            return charCountPairs;
        }
        private List<int> GetCharPermutatedSum(KeyValuePair<char,int> charCountPair)
        {
            List<int> sums = new List<int>();
            for (int i = 0; i < charCountPair.Value; i++)
            {
                var c = System.Text.Encoding.ASCII.GetBytes(charCountPair.Key.ToString());
                if (i==0)
                    sums.Add(c[0]-96);
                else
                    sums.Add(sums[i-1]+ (c[0]-96));
            }
            return sums;
        }
        private List<string> GetIntersectionRespectively(List<int> sourceList, List<int> targetList)
        {
            List<string> yesNoList = new List<string>();
            foreach (int originalValue in sourceList)
                yesNoList.Add(IsContains(originalValue,targetList) ? "Yes" : "No");
            return yesNoList;
        }
        private bool IsContains(int originalValue, List<int> targetList)
        {
                foreach (int comparableValue in targetList)
                    if (originalValue == comparableValue)
                        return true;
            return false;
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class SherlockAndTheValidString : IHackerRankContract
    {
        public string IsSherlockAndTheValidString(string input)
        {
            Dictionary<object,int> CharCountPair = GroupBy(input);
            List<int> groupCounts = GetGroupCounts(CharCountPair);
            if (groupCounts.Count() > 2)
                return "NO";
            else if(groupCounts.Count() ==1)
            {
                return "YES";
            }
            else
            {
                if (((groupCounts[0] - groupCounts[1]) == 1) || ((groupCounts[0] - groupCounts[1]) == -1))
                    return "YES";
                else
                    return "NO";
            }
        }
        private Dictionary<object,int> GroupBy(string input)
        {
            Dictionary<object, int> CharCountPair = new Dictionary<object, int>();
            foreach (object c1 in input)
            {
                int count = 0;
                foreach (object c2 in input)
                {
                    if (c1.Equals(c2))
                        count++;
                }
                if(!CharCountPair.Keys.Contains(c1))
                    CharCountPair.Add(c1, count);
            }
            return CharCountPair;
        }
        private List<int> GetGroupCounts(Dictionary<object,int> keyValuePairs)
        {
            List<int> counts = new List<int>();
            foreach (KeyValuePair<object,int> kvp in keyValuePairs)
            {
                if(!counts.Contains(kvp.Value))
                    counts.Add(kvp.Value);
            }
            return counts;
        }
    }
}

using HackerRank;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            int[] queries = new int[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            var wus = new WeightedUniformStrings();

           // System.Console.WriteLine(string.Join("\n", wus.GetWightedUniformString( (s, queries.ToList())));
            System.Console.Read();
        }
    }
}

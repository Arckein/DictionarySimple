using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("input.txt");
            StreamWriter output = new StreamWriter("output.txt");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while (!input.EndOfStream)
            {
                string[] str = input.ReadLine().ToLower().Split(" ,.?!\'(-)\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in str)
                {
                    if (dict.ContainsKey(word)) dict[word]++;
                    else dict.Add(word, 1);
                }
            }
            var result = dict.OrderByDescending(x => x.Value);
            foreach (var item in result) output.WriteLine(item.Key);
            input.Close();
            output.Close();
        }
    }
}

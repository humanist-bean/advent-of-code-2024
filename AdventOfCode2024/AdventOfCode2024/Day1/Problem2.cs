using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Day1
{
    internal class Problem2
    {
        public static void SolveProblem()
        {
            try
            {
                string filepath = "C:\\Users\\alder.french\\OneDrive - Leviton\\Desktop\\repos\\advent-of-code-2024\\AdventOfCode2024\\AdventOfCode2024\\Day1\\problem1.txt";
                StreamReader sr = new StreamReader(filepath);
                string? line = sr.ReadLine();
                int diffSum = 0;
                List<int> firstNums = new List<int>();
                List<int> secondNums = new List<int>();
                while (line != null)
                {
                    string[] lineList = line.Split(" ");
                    List<int> nums = lineList.Where((str) => str.Length > 0).Select((str) => int.Parse(str)).ToList();
                    //Console.WriteLine($"Nums: {nums[0]}, {nums[1]}");
                    int num1 = nums[0];
                    int num2 = nums[1];
                    firstNums.Add(num1);
                    secondNums.Add(num2);
                    //Console.WriteLine(lineList[0]);
                    //int num1 = int.Parse(lineList[0]);
                    //Console.WriteLine(lineList[2]);
                    //int num2 = int.Parse(lineList[2]);
                    line = sr.ReadLine();
                }
                Dictionary<int, int> numCounts = new Dictionary<int, int>();
                secondNums.ForEach((num) => numCounts[num] = numCounts.GetValueOrDefault(num, 0) + 1);
                int similarity = 0;
                firstNums.ForEach((num) =>  similarity += num * numCounts.GetValueOrDefault(num, 0)); 
                Console.WriteLine($"Day 1 - Problem 2: the similarity score is: {similarity}");
                sr.Close();

                return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}

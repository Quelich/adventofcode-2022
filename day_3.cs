using System;
using System.Collections.Generic;

class RucksackReorganization
{
    // static void Main(string[] args)
    // {
    //     var r = GetSumByThreeGroups();
    //     System.Console.WriteLine($"Sum:{r}");
    // }

    Dictionary<char, int> Priorities
    {
        get
        {
            return new Dictionary<char, int>
            {
                { 'a', 1 },
                { 'b', 2 },
                { 'c', 3 },
                { 'd', 4 },
                { 'e', 5 },
                { 'f', 6 },
                { 'g', 7 },
                { 'h', 8 },
                { 'ı', 9 },
                { 'j', 10 },
                { 'k', 11 },
                { 'l', 12 },
                { 'm', 13 },
                { 'n', 14 },
                { 'o', 15 },
                { 'p', 16 },
                { 'q', 17 },
                { 'r', 18 },
                { 's', 19 },
                { 't', 20 },
                { 'u', 21 },
                { 'v', 22 },
                { 'w', 23 },
                { 'x', 24 },
                { 'y', 25 },
                { 'z', 26 },
                { 'A', 27 },
                { 'B', 28 },
                { 'C', 29 },
                { 'D', 30 },
                { 'E', 31 },
                { 'F', 32 },
                { 'G', 33 },
                { 'H', 34 },
                { 'I', 35 },
                { 'J', 36 },
                { 'K', 37 },
                { 'L', 38 },
                { 'M', 39 },
                { 'N', 40 },
                { 'O', 41 },
                { 'P', 42 },
                { 'Q', 43 },
                { 'R', 44 },
                { 'S', 45 },
                { 'T', 46 },
                { 'U', 47 },
                { 'V', 48 },
                { 'W', 49 },
                { 'X', 50 },
                { 'Y', 51 },
                { 'Z', 52 },
            };
        }
    }

    static int GetSumByLine()
    {
        var matches = new List<char>();
        foreach (string line in System.IO.File.ReadLines(@"inputDay3.txt"))
        {
            var len = line.Length;
            var median = len / 2; // assume len is an even number
            //global::System.Console.WriteLine(len);

            var map = new Dictionary<int, char>();

            // First compartment
            for (int i = 0; i < median; i++)
            {
                if (!map.ContainsValue(line[i]))
                {
                    map[i] = line[i];
                }
            }
            // Second compartment
            for (int i = median; i < len; i++)
            {
                if (map.ContainsValue(line[i]))
                {
                    matches.Add(line[i]);
                    var key = map.FirstOrDefault(x => x.Value == line[i]).Key;
                    map.Remove(key);
                }
            }
        }

        var mc = new RucksackReorganization();
        int sum = 0;
        foreach (char n in matches)
        {
            global::System.Console.WriteLine($"Match: {n}");
            int priority = mc.Priorities.GetValueOrDefault(n);
            sum += priority;
        }

        return sum;
    }

    static int GetSumByThreeGroups()
    {
        int sum = 0;
        var mc = new RucksackReorganization();
        var lines = new List<string>();
        foreach (string line in System.IO.File.ReadLines(@"inputDay3.txt"))
        {
            lines.Add(line);
        }

        int i = 2; // first group 
        while (i < lines.Count)
        {
            var groupMap = new Dictionary<int, char>();
            var groupMap1 = new Dictionary<int, char>();
            var groupMap2 = new Dictionary<int, char>();
            var groupMapCount = new Dictionary<char, int>();

            var line1 = lines[i - 2];
            var line2 = lines[i - 1];
            var line3 = lines[i];
            int j;

            for (j = 0; j < line1.Length; j++)
            {
                char item = line1[j];
                if (!groupMap.ContainsValue(item))
                {
                    groupMap[j] = item;
                    groupMap1[j] = item;
                    groupMap2[j] = item;
                    groupMapCount[item] = 1;
                }
            }

            for (j = 0; j < line2.Length; j++)
            {
                char item = line2[j];
                if (groupMap1.ContainsValue(item))
                {
                    groupMapCount[item]++;
                    var key = groupMap1.FirstOrDefault(x => x.Value == item).Key;
                    groupMap1.Remove(key);
                }
            }

            for (j = 0; j < line3.Length; j++)
            {
                char item = line3[j];
                if (groupMap2.ContainsValue(item))
                {
                    groupMapCount[item]++;
                    var key = groupMap2.FirstOrDefault(x => x.Value == item).Key;
                    groupMap2.Remove(key);
                }
            }

            foreach (var item in groupMapCount)
            {
                if (item.Value == 3)
                {
                    var key = item.Key;
                    var priority = mc.Priorities.GetValueOrDefault(key);
                    sum += priority;
                }
            }

            i += 3;
        }

        return sum;
    }
}

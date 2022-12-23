using System;
using System.Collections.Generic;

class RucksackReorganization
{
    static void Main(string[] args)
    {
        var r = Solution();
        System.Console.WriteLine($"Sum:{r}");
    }

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

    static int Solution()
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

            // foreach (var item in map)
            // {
            //     global::System.Console.Write(item.Value);
            // }
            // System.Console.WriteLine();

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
}

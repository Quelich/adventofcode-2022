using System;

class CampCleanup
{
    static void Main(string[] args)
    {
        // int r = Part1();
        // Console.WriteLine("Count: " + r);
        int r = Part2();
        Console.WriteLine("Overlap: " + r);
    }

    static int Part1()
    {
        int count = 0;
        foreach (string line in System.IO.File.ReadLines(@"inputDay4.txt"))
        {
            int[] numsInt = new int[4];
            string[] numsStr = new string[4];
            int i = 0;
            // Get first number
            while (line[i] != '-')
            {
                numsStr[0] += line[i];
                i++;
            }
            i++; // pass '-'
            // Get seconds number
            while (line[i] != ',')
            {
                numsStr[1] += line[i];
                i++;
            }
            i++; // pass ','
            // Get third number
            while (line[i] != '-')
            {
                numsStr[2] += line[i];
                i++;
            }
            i++; // pass '-'
            // Get fourth number
            while (i < line.Length)
            {
                numsStr[3] += line[i];
                i++;
            }

            // First Elf
            numsInt[0] = Int32.Parse(numsStr[0]); // start
            numsInt[1] = Int32.Parse(numsStr[1]); // end
            // Second Elf
            numsInt[2] = Int32.Parse(numsStr[2]); // start
            numsInt[3] = Int32.Parse(numsStr[3]); // end

            // first elf contains second
            if (numsInt[0] <= numsInt[2] && numsInt[1] >= numsInt[3])
            {
                count++;
            }
            // second elf contains first
            else if (numsInt[0] >= numsInt[2] && numsInt[1] <= numsInt[3])
            {
                count++;
            }
            // find min and max
            System.Console.WriteLine($"{numsInt[0]} {numsInt[1]} {numsInt[2]} {numsInt[3]}");
        }
        return count;
    }

    static int Part2()
    {
        int overlapsCount = 0;
        foreach (string line in System.IO.File.ReadLines(@"inputDay4.txt"))
        {
            int[] numsInt = new int[4];
            string[] numsStr = new string[4];
            int i = 0;
            // Get first number
            while (line[i] != '-')
            {
                numsStr[0] += line[i];
                i++;
            }
            i++; // pass '-'
            // Get seconds number
            while (line[i] != ',')
            {
                numsStr[1] += line[i];
                i++;
            }
            i++; // pass ','
            // Get third number
            while (line[i] != '-')
            {
                numsStr[2] += line[i];
                i++;
            }
            i++; // pass '-'
            // Get fourth number
            while (i < line.Length)
            {
                numsStr[3] += line[i];
                i++;
            }

            // First Elf
            numsInt[0] = Int32.Parse(numsStr[0]); // start
            numsInt[1] = Int32.Parse(numsStr[1]); // end
            // Second Elf
            numsInt[2] = Int32.Parse(numsStr[2]); // start
            numsInt[3] = Int32.Parse(numsStr[3]); // end

            var overlaps = new HashSet<int>();
            // first elf is overlap condition
            int j;
            for (j = numsInt[0]; j <= numsInt[1]; j++)
            {
                if (!overlaps.Contains(j))
                {
                    overlaps.Add(j);
                }
            }
            // second elf
            for (j = numsInt[2]; j <= numsInt[3]; j++)
            {
                if (overlaps.Contains(j))
                {
                    overlapsCount++;
                    break;
                }
            }
            // find min and max
            //System.Console.WriteLine($"{numsInt[0]} {numsInt[1]} {numsInt[2]} {numsInt[3]}");
        }
        return overlapsCount;
    }
}

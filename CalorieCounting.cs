// DAY 1

internal class CalorieCounting
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(FindTopThree());
    }

    static int FindTopThree()
    {
        int maxPtr1 = 0;
        // int maxPtr2 = 0;
        var l = new List<int>();

        // Read the file and display it line by line.
        foreach (string line in System.IO.File.ReadLines(@"input.txt"))
        {
            if (line == "")
            {
                l.Add(maxPtr1);
                maxPtr1 = 0;
            }
            else
            {
                maxPtr1 += Int32.Parse(line);
            }
        }

        l.Sort();

        System.Console.WriteLine(l[l.Count - 1]);
        System.Console.WriteLine(l[l.Count - 2]);
        System.Console.WriteLine(l[l.Count - 3]);

        var total = l[l.Count - 1] + l[l.Count - 2] + l[l.Count - 3];
        return total;
    }

    static int Count()
    {
        int maxPtr1 = 0;
        int maxPtr2 = 0;
        // Read the file and display it line by line.
        foreach (string line in System.IO.File.ReadLines(@"input.txt"))
        {
            if (line == "")
            {
                if (maxPtr1 > maxPtr2)
                {
                    maxPtr2 = maxPtr1;
                    System.Console.WriteLine(maxPtr1);
                }
                maxPtr1 = 0;
            }
            else
            {
                maxPtr1 += Int32.Parse(line);
            }
        }
        return maxPtr2;
    }
}

// DAY 1

internal class CalorieCounting
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Count());
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

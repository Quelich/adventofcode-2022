using System;

class TuningTrouble
{
    static void Main(string[] args)
    {
        var r = Part1();
        Console.WriteLine("Result: " + r);
    }

    static int Part1()
    {
        string stream = System.IO.File.ReadLines(@"inputDay6.txt").First<string>();

        int i = 3;
        while (i < stream.Length)
        {
            var map = new HashSet<char>();
            map.Add(stream[i]);
            bool isDuplicates = false;
            for (int j = i - 1; j >= i - 3; j--)
            {
                if (!map.Contains(stream[j]))
                {
                    map.Add(stream[j]);
                }
                else
                {
                    isDuplicates = true;
                    break;
                }
            }
            if (isDuplicates == false)
            {
                return i + 1;
            }
            //System.Console.WriteLine("result:" + result);
            i++;
        }
        return i + 1;
    }
}

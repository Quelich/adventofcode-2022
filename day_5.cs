/*
ANSWER: VCTFTJQCG
*/
class SupplyStacks
{
    // static void Main(string[] args)
    // {
    //     Part2();
    // }

    static void Part1()
    {
        var stacks = new List<Stack<char>>();
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        // Set stack 1
        stacks[0].Push('Q');
        stacks[0].Push('M');
        stacks[0].Push('G');
        stacks[0].Push('C');
        stacks[0].Push('L');
        // Set stack 2
        stacks[1].Push('R');
        stacks[1].Push('D');
        stacks[1].Push('L');
        stacks[1].Push('C');
        stacks[1].Push('T');
        stacks[1].Push('F');
        stacks[1].Push('H');
        stacks[1].Push('G');
        // Set stack 3
        stacks[2].Push('V');
        stacks[2].Push('J');
        stacks[2].Push('F');
        stacks[2].Push('N');
        stacks[2].Push('M');
        stacks[2].Push('T');
        stacks[2].Push('W');
        stacks[2].Push('R');
        // Set stack 4
        stacks[3].Push('J');
        stacks[3].Push('F');
        stacks[3].Push('D');
        stacks[3].Push('V');
        stacks[3].Push('Q');
        stacks[3].Push('P');
        // Set stack 5
        stacks[4].Push('N');
        stacks[4].Push('F');
        stacks[4].Push('M');
        stacks[4].Push('S');
        stacks[4].Push('L');
        stacks[4].Push('B');
        stacks[4].Push('T');
        // Set stack 6
        stacks[5].Push('R');
        stacks[5].Push('N');
        stacks[5].Push('V');
        stacks[5].Push('H');
        stacks[5].Push('C');
        stacks[5].Push('D');
        stacks[5].Push('P');
        // Set stack 7
        stacks[6].Push('H');
        stacks[6].Push('C');
        stacks[6].Push('T');
        // Set stack 8
        stacks[7].Push('G');
        stacks[7].Push('S');
        stacks[7].Push('J');
        stacks[7].Push('V');
        stacks[7].Push('Z');
        stacks[7].Push('N');
        stacks[7].Push('H');
        stacks[7].Push('P');
        // Set stack 9
        stacks[8].Push('Z');
        stacks[8].Push('F');
        stacks[8].Push('H');
        stacks[8].Push('G');
        foreach (string line in System.IO.File.ReadLines(@"inputDay5.txt"))
        {
            string[] words = line.Split(' ');
            int moveCount = Int32.Parse(words[1]);
            int from = Int32.Parse(words[3]);
            int to = Int32.Parse(words[5]);

            for (int i = 0; i < moveCount; i++)
            {
                var removed = stacks[from - 1].Pop();
                stacks[to - 1].Push(removed);
            }
        }
        foreach (var stack in stacks)
        {
            Console.Write(stack.Pop());
        }
    }

    static void Part2()
    {
        var stacks = new List<Stack<char>>();
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        stacks.Add(new Stack<char>());
        // Set stack 1
        stacks[0].Push('Q');
        stacks[0].Push('M');
        stacks[0].Push('G');
        stacks[0].Push('C');
        stacks[0].Push('L');
        // Set stack 2
        stacks[1].Push('R');
        stacks[1].Push('D');
        stacks[1].Push('L');
        stacks[1].Push('C');
        stacks[1].Push('T');
        stacks[1].Push('F');
        stacks[1].Push('H');
        stacks[1].Push('G');
        // Set stack 3
        stacks[2].Push('V');
        stacks[2].Push('J');
        stacks[2].Push('F');
        stacks[2].Push('N');
        stacks[2].Push('M');
        stacks[2].Push('T');
        stacks[2].Push('W');
        stacks[2].Push('R');
        // Set stack 4
        stacks[3].Push('J');
        stacks[3].Push('F');
        stacks[3].Push('D');
        stacks[3].Push('V');
        stacks[3].Push('Q');
        stacks[3].Push('P');
        // Set stack 5
        stacks[4].Push('N');
        stacks[4].Push('F');
        stacks[4].Push('M');
        stacks[4].Push('S');
        stacks[4].Push('L');
        stacks[4].Push('B');
        stacks[4].Push('T');
        // Set stack 6
        stacks[5].Push('R');
        stacks[5].Push('N');
        stacks[5].Push('V');
        stacks[5].Push('H');
        stacks[5].Push('C');
        stacks[5].Push('D');
        stacks[5].Push('P');
        // Set stack 7
        stacks[6].Push('H');
        stacks[6].Push('C');
        stacks[6].Push('T');
        // Set stack 8
        stacks[7].Push('G');
        stacks[7].Push('S');
        stacks[7].Push('J');
        stacks[7].Push('V');
        stacks[7].Push('Z');
        stacks[7].Push('N');
        stacks[7].Push('H');
        stacks[7].Push('P');
        // Set stack 9
        stacks[8].Push('Z');
        stacks[8].Push('F');
        stacks[8].Push('H');
        stacks[8].Push('G');
        foreach (string line in System.IO.File.ReadLines(@"inputDay5.txt"))
        {
            string[] words = line.Split(' ');
            int moveCount = Int32.Parse(words[1]);
            int from = Int32.Parse(words[3]);
            int to = Int32.Parse(words[5]);

            var removed = new Stack<char>();
            for (int i = 0; i < moveCount; i++)
            {
                removed.Push(stacks[from - 1].Pop());
            }
            foreach (var item in removed)
            {
                stacks[to - 1].Push(item);
            }
        }
        foreach (var stack in stacks)
        {
            Console.Write(stack.Pop());
        }
    }
}

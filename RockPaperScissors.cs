// DAY 2

public class RockPaperScissors
{
    static void Main(string[] args)
    {
        int r = Part2();
        System.Console.WriteLine(r);
    }

    static int StrategyGuide()
    {
        // First Column
        // A - Rock - 1
        // B - Paper - 2
        // C - Scissors - 3

        // Second Column
        // X - Rock - 1
        // Y - Paper - 2
        // Z - Scissors - 3

        // 0 - Lost
        // 3 - draw
        // 6 - win

        int totalScore = 0;

        foreach (string line in System.IO.File.ReadLines(@"inputDay2.txt"))
        {
            char col1 = line[0]; // opponent
            char col2 = line[2]; // player

            if (col1 == 'A') // ROCK
            {
                if (col2 == 'X') // ROCK
                {
                    // draw
                    totalScore += 4;
                }
                if (col2 == 'Y') // PAPER
                {
                    // win
                    totalScore += 8;
                }
                if (col2 == 'Z') // SCISSORS
                {
                    // lose
                    totalScore += 3;
                }
            }
            if (col1 == 'B') // PAPER
            {
                if (col2 == 'X') // ROCK
                {
                    // lose
                    totalScore += 1;
                }
                if (col2 == 'Y') // PAPER
                {
                    // draw
                    totalScore += 5;
                }
                if (col2 == 'Z') // SCISSORS
                {
                    // win
                    totalScore += 9;
                }
            }
            if (col1 == 'C') // SCISSORS
            {
                if (col2 == 'Z') // SCISSORS
                {
                    // draw
                    totalScore += 6;
                }
                if (col2 == 'X') // ROCK
                {
                    // win
                    totalScore += 7;
                }
                if (col2 == 'Y') // PAPER
                {
                    // win
                    totalScore += 2;
                }
            }
        }

        return totalScore;
    }

    static int Part2()
    {
        // First Column
        // A - Rock - 1
        // B - Paper - 2
        // C - Scissors - 3

        // Second Column
        // X - Rock - 1
        // Y - Paper - 2
        // Z - Scissors - 3

        // 0 - Lost
        // 3 - draw
        // 6 - win

        int totalScore = 0;

        foreach (string line in System.IO.File.ReadLines(@"inputDay2.txt"))
        {
            char col1 = line[0]; // opponent
            char col2 = line[2]; // player

            if (col1 == 'A') // ROCK
            {
                if (col2 == 'X') // lose 
                {
                    // SCISSORS
                    totalScore += 3;
                }
                if (col2 == 'Y') // draw
                {
                    // ROCK
                    totalScore += 4;
                }
                if (col2 == 'Z') // win
                {
                    // PAPER
                    totalScore += 8;
                }
            }
            if (col1 == 'B') // PAPER
            {
                if (col2 == 'X') // lose
                {
                    // ROCK
                    totalScore += 1;
                }
                if (col2 == 'Y') // draw
                {
                    // PAPER
                    totalScore += 5;
                }
                if (col2 == 'Z') // win
                {
                    // SCISSORS
                    totalScore += 9;
                }
            }
            if (col1 == 'C') // SCISSORS
            {
                if (col2 == 'X') // lose
                {
                    // PAPER
                    totalScore += 2;
                }
                if (col2 == 'Y') // draw
                {
                    // SCISSORS
                    totalScore += 6;
                }
                if (col2 == 'Z') // win
                {
                    // ROCK
                    totalScore += 7;
                }
            }
        }

        return totalScore;
    }
}

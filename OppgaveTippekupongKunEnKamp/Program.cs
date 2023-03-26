namespace OppgaveTippekupongKunEnKamp;

class Program
{
    static void Main(string[] args)
    {
        RunGame();
    }

    private static void RunGame()
    {
        Console.Write("Valid tips: \r\n - H, U, B\r\n - half guard: HU, HB, UB\r\n - full guard: HUB\r\nWho have you tipped for this match? ");

        var bet = Console.ReadLine();
        var match = new Match(bet);

        while (match.IsRunning)
        {
            Console.Write("Commands: \r\n - H = scoring home team\r\n - B = scoring away team\r\n - X = match is over\r\nEnter command: ");
            var command = Console.ReadLine();

            if (command == "X") match.Stop();
            if (command == "H") match.AddGoal(true);
            else if (command == "B") match.AddGoal(false);

            Console.WriteLine(match.GetScore());
        }

        var isBetCorrect = match.IsBetCorrect();
        Console.WriteLine($"You tipped {isBetCorrect}");
    }
}
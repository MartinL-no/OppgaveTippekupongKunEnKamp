using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
namespace OppgaveTippekupongKunEnKamp;
class Program
{
    static void Main(string[] args)
    {
        RunGame();
    }

    private static void RunGame()
    {
        Console.Write("Valid tips: \r\n - H, U, B\r\n - half guard: HU, HB, UB\r\n - full guard: HUB\r\nWhat have you tipped for this match? ");
        var bet = Console.ReadLine();
        var match = new Match();
        var matchIsRunning = true;

        while (matchIsRunning)
        {
            Console.Write("Commands: \r\n - H = scoring home team\r\n - B = scoring away team\r\n - X = match is over\r\nEnter command: ");
            var command = Console.ReadLine();
            matchIsRunning = command != "X";
            if (command == "H") match.HomeGoals++;
            else if (command == "B") match.AwayGoals++;
            Console.WriteLine($"The position is {match.HomeGoals}-{match.AwayGoals}.");
        }

        var isBetCorrectText = match.isBetCorrectText(bet);
        Console.WriteLine($"You tipped {isBetCorrectText}");

    }
}


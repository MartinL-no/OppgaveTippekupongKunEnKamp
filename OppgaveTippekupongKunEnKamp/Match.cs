using System;
namespace OppgaveTippekupongKunEnKamp
{
    public class Match
    {
        public int HomeGoals;
        public int AwayGoals;
        public string Result => HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";

        public Match()
        {
            HomeGoals = 0;
            AwayGoals = 0;
        }
        public bool IsBetCorrect(string bet)
        {
            return bet.Contains(Result);
        }
        public string isBetCorrectText(string? bet)
        {
            if (bet != null && bet.Contains(Result))
            {
                return "correctly";
            }
            else
            {
                return "falsely";
            }
        }
    }
}


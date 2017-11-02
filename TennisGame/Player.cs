namespace TennisGame
{
    public class Player
    {
        public Player()
        {
            ScoringTimes = 0;
        }

        public string Name { get; set;}
        public int ScoringTimes { get; private set; }
        
        public void WonAPoint()
        {
            ScoringTimes += 1;
        }

        public string Score()
        {
            if (ScoringTimes == 0)
            {
                return "Love";
            }
            else
            {
                return "Fifteen";
            }
        }
    }
}
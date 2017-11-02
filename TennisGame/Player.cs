using System.Collections.Generic;

namespace TennisGame
{
    public class Player
    {
        public Player()
        {
            ScoringTimes = 0;
        }

        public Dictionary<int,string> ScoreMapping = new Dictionary<int, string>
        {
            { 0,"Love"},
            { 1,"Fifteen"},
            { 2,"Thirty"},
            { 3,"Forty"},
        };

        public string Name { get; set;}
        public int ScoringTimes { get; set; }
        
        public string Score()
        {
            return ScoreMapping[ScoringTimes];
        }
    }
}
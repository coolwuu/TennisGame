using System;

namespace TennisGame
{
    public class Game
    {
        private Player _firstPlayer;
        private Player _secondPlayer;

        public Game(Player firstPlayer,Player secondPlayer)
        {
            _secondPlayer = secondPlayer;
            _firstPlayer = firstPlayer;
        }
        public string ShowScore()
        {
            if(_firstPlayer.ScoringTimes == 0 && _secondPlayer.ScoringTimes ==0)
                return "Love All";

            return _firstPlayer.Score() + " " + _secondPlayer.Score();
        }
    }
}
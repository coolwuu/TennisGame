using System;

namespace TennisGame
{
    public class Game
    {
        private readonly Player _firstPlayer;
        private readonly Player _secondPlayer;

        public Game(Player firstPlayer, Player secondPlayer)
        {
            _secondPlayer = secondPlayer;
            _firstPlayer = firstPlayer;
        }
        public string ShowScore()
        {
            if (_firstPlayer.ScoringTimes == 0 && _secondPlayer.ScoringTimes == 0)
                return "Love All";
            if (_firstPlayer.ScoringTimes >= 3 && _secondPlayer.ScoringTimes >= 3)
            {
                if (_firstPlayer.ScoringTimes == _secondPlayer.ScoringTimes)
                {
                    return "Deuce";
                }
                return LateGameLogic();
            }
            return _firstPlayer.Score() + " " + _secondPlayer.Score();
        }

        private string LateGameLogic()
        {
            if (_firstPlayer.ScoringTimes - _secondPlayer.ScoringTimes == 1)
            {
                return "Advantage " + _firstPlayer.Name;
            }
            else
            {
                return "Advantage " + _secondPlayer.Name;
            }
        }

        public void FirstPlayerWinAPoint()
        {
            _firstPlayer.ScoringTimes += 1;
        }

        public void SecondPlayerWinAPoint()
        {
            _secondPlayer.ScoringTimes += 1;
        }


    }
}
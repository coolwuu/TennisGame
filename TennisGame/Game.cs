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
            if (IsNewGame())
                return "Love All";
            if (IsLateGame())
            {
                if (SameScore())
                {
                    return "Deuce";
                }
                return LateGameLogic();
            }
            return _firstPlayer.Score() + " " + _secondPlayer.Score();
        }

        private bool SameScore()
        {
            return _firstPlayer.ScoringTimes == _secondPlayer.ScoringTimes;
        }

        private bool IsLateGame()
        {
            return _firstPlayer.ScoringTimes >= 3 && _secondPlayer.ScoringTimes >= 3;
        }

        private bool IsNewGame()
        {
            return _firstPlayer.ScoringTimes == 0 && _secondPlayer.ScoringTimes == 0;
        }

        private string LateGameLogic()
        {
            if (FirstPlayerAdvantage())
            {
                return "Advantage " + _firstPlayer.Name;
            }
            if (SecondPlayerAdvantage())
            {
                return "Advantage " + _secondPlayer.Name;
            }
            return _firstPlayer.ScoringTimes > _secondPlayer.ScoringTimes ? FirstPlayerWon() : SecondPlayerWon();
        }

        private string SecondPlayerWon()
        {
            return "Game " + _secondPlayer.Name;
        }

        private string FirstPlayerWon()
        {
            return "Game " + _firstPlayer.Name;
        }

        private bool SecondPlayerAdvantage()
        {
            return _secondPlayer.ScoringTimes - _firstPlayer.ScoringTimes == 1;
        }

        private bool FirstPlayerAdvantage()
        {
            return _firstPlayer.ScoringTimes - _secondPlayer.ScoringTimes == 1;
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
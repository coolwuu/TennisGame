using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TennisGame
{

    public class TennisGameTest
    {
        private Game _tennisGame;

        [Test]
        public void StartGame_Score_should_be_LoveAll()
        {
            _tennisGame = InitialGame();
            CurrentScoreIs(_tennisGame, "Love All");
        }

        [Test] 
        public void A_Get1stPoint_Score_should_be_Fifteen_Love()
        {
            _tennisGame = InitialGame();
            A_Score(1);
            CurrentScoreIs(_tennisGame, "Fifteen Love");
        }

        [Test]
        public void A_Get2ndPoint_Score_should_be_Thirty_Love()
        {
            _tennisGame = InitialGame();
            A_Score(2);
            CurrentScoreIs(_tennisGame, "Thirty Love");
        }

        [Test]
        public void A_Get3rdPoint_Score_should_be_Forty_Love()
        {
            _tennisGame = InitialGame();
            A_Score(3);
            CurrentScoreIs(_tennisGame, "Forty Love");
        }

        [Test]
        public void Both_A_B_Get3rdPoint_Score_should_be_Deuce()
        {
            _tennisGame = InitialGame();
            A_Score(3);
            B_Score(3);
            CurrentScoreIs(_tennisGame, "Deuce");
        }

        [Test]
        public void When_A_4Points_B_3Points_Score_should_be_Advantage_A()
        {
            _tennisGame = InitialGame();
            A_Score(4);
            B_Score(3);
            CurrentScoreIs(_tennisGame, "Advantage A");
        }
        [Test]
        public void When_A_5Points_B_3Points_Score_should_be_Game_A()
        {
            _tennisGame = InitialGame();
            A_Score(5);
            B_Score(3);
            CurrentScoreIs(_tennisGame, "Game A");
        }
        [Test]
        public void When_A_5Points_B_5Points_Score_should_be_Deuce()
        {
            _tennisGame = InitialGame();
            A_Score(5);
            B_Score(5);
            CurrentScoreIs(_tennisGame, "Deuce");
        }
        [Test]
        public void When_A_5Points_B_7Points_Score_should_be_Game_B()
        {
            _tennisGame = InitialGame();
            A_Score(5);
            B_Score(7);
            CurrentScoreIs(_tennisGame, "Game B");
        }



        private static Game InitialGame()
        {
            Player a = new Player { Name = "A" };
            Player b = new Player { Name = "B" };
            Game tennisGame = new Game(a, b);
            return tennisGame;
        }

        private static void CurrentScoreIs(Game tennisGame, string expected)
        {
            var actual = tennisGame.ShowScore();
            Assert.AreEqual(expected, actual);
        }

        private void A_Score(int times)
        {
            for(var i = 1; i <= times;i++)
                _tennisGame.FirstPlayerWinAPoint();
        }
        private void B_Score(int times)
        {
            for(var i = 1; i <= times;i++)
                _tennisGame.SecondPlayerWinAPoint();
        }
    }
}

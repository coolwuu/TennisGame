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
        public void A_Get1stPoint_Score_should_be_Fifteen_All()
        {
            _tennisGame = InitialGame();
            _tennisGame.FirstPlayerScore();
            CurrentScoreIs(_tennisGame, "Fifteen Love");
        }

        private static Game InitialGame()
        {
            Player a = new Player { Name = "a" };
            Player b = new Player { Name = "b" };
            Game tennisGame = new Game(a, b);
            return tennisGame;
        }

        private static void CurrentScoreIs(Game tennisGame, string expected)
        {
            var actual = tennisGame.ShowScore();
            Assert.AreEqual(expected, actual);
        }
    }
}

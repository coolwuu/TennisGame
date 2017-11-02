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
        private Game TennisGame;

        [Test]
        public void StartGame_Score_should_be_LoveAll()
        {
            var tennisGame = InitialGame();

            var actual = tennisGame.ShowScore();
            Assert.AreEqual("Love All", actual);
        }

        [Test]
        public void A_Get1stPoint_Score_should_be_Fifteen_All()
        {
            var tennisGame = InitialGame();

            tennisGame.FirstPlayerScore();
            var actual = tennisGame.ShowScore();

            //assert
            Assert.AreEqual("Fifteen Love", actual);
        }

        private static Game InitialGame()
        {
            Player a = new Player { Name = "a" };
            Player b = new Player { Name = "b" };
            Game tennisGame = new Game(a, b);
            return tennisGame;
        }
    }
}

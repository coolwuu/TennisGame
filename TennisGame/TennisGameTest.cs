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
       
        [Test]
        public void StartGame_Score_should_be_LoveAll()
        {
            Player a = new Player { Name = "a" };
            Player b = new Player { Name = "b" };
            Game tennisGame = new Game(a, b);
            //act
            var actual = tennisGame.ShowScore();

            //assert
            Assert.AreEqual("Love All", actual);
        }

        [Test]
        public void A_Get1stPoint_Score_should_be_Fifteen_All()
        {
            Player a = new Player { Name = "a" };
            Player b = new Player { Name = "b" };
            Game tennisGame = new Game(a, b);
            //act
            tennisGame.FirstPlayerScore();
            var actual = tennisGame.ShowScore();

            //assert
            Assert.AreEqual("Fifteen Love", actual);
        }
    }
}

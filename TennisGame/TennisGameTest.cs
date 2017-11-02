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
            //arrange
            Game tennisGame = new Game();
            Player a = new Player{Name = "a"};
            Player b = new Player{Name = "b"};

            //act
            var actual = tennisGame.ShowScore(a,b);
            
            //assert
            Assert.AreEqual("Love All",actual);
        }
    }
}

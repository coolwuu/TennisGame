using NUnit.Framework;

namespace TennisGame
{

    public class TennisGameTest
    {
        private Game _tennisGame;
        [SetUp]
        public void Setup()
        {
            _tennisGame = InitialGame();
        }
        [Test]
        public void StartGame_Score_should_be_LoveAll()
        {
            CurrentScoreIs("Love All");
        }
        [Test] 
        public void PlayerA_Get1Point_Score_should_be_Fifteen_Love()
        {
            PlayerA_Score(1);
            CurrentScoreIs("Fifteen Love");
        }
        [Test]
        public void PlayerA_Get2Point_Score_should_be_Thirty_Love()
        {
            PlayerA_Score(2);
            CurrentScoreIs("Thirty Love");
        }
        [Test]
        public void PlayerA_Get3Point_Score_should_be_Forty_Love()
        {
            PlayerA_Score(3);
            CurrentScoreIs("Forty Love");
        }
        [Test]
        public void Both_Players_Get3Point_Score_should_be_Deuce()
        {
            PlayerA_Score(3);
            PlayerB_Score(3);
            CurrentScoreIs("Deuce");
        }
        [Test]
        public void When_PlayerA_4Points_PlayerB_3Points_Score_should_be_Advantage_A()
        {
            PlayerA_Score(4);
            PlayerB_Score(3);
            CurrentScoreIs("Advantage A");
        }
        [Test]
        public void When_PlayerA_5Points_PlayerB_3Points_Score_should_be_Game_A()
        {
            PlayerA_Score(5);
            PlayerB_Score(3);
            CurrentScoreIs("Game A");
        }
        [Test]
        public void When_PlayerA_5Points_PlayerB_5Points_Score_should_be_Deuce()
        {
            PlayerA_Score(5);
            PlayerB_Score(5);
            CurrentScoreIs("Deuce");
        }
        [Test]
        public void When_PlayerA_5Points_PlayerB_7Points_Score_should_be_Game_B()
        {
            PlayerA_Score(5);
            PlayerB_Score(7);
            CurrentScoreIs("Game B");
        }
        [Test]
        public void When_PlayerA_2Points_PlayerB_1Point_Score_should_be_Thirty_Fifteen()
        {
            PlayerA_Score(2);
            PlayerB_Score(1);
            CurrentScoreIs("Thirty Fifteen");
        }
        private static Game InitialGame()
        {
            var a = new Player { Name = "A" };
            var b = new Player { Name = "B" };
            return new Game(a, b);
        }
        private void CurrentScoreIs(string expected)
        {
            var actual = _tennisGame.ShowScore();
            Assert.AreEqual(expected, actual);
        }
        private void PlayerA_Score(int times)
        {
            for(var i = 1; i <= times;i++)
                _tennisGame.FirstPlayerWinAPoint();
        }
        private void PlayerB_Score(int times)
        {
            for(var i = 1; i <= times;i++)
                _tennisGame.SecondPlayerWinAPoint();
        }
    }
}

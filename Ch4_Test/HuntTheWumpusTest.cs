using Ch4_Library.HuntTheWumpus;

namespace Ch4_Test
{
    [TestClass]
    public class HuntTheWumpusTest
    {
        [TestMethod]
        public void TestMove()
        {
            WumpusGame g = new WumpusGame();
            g.Connect(4, 5, "E");
            g.SetPlayerRoom(4);
            g.East();
            Assert.AreEqual(5, g.GetPlayerRoom());
        }
    }
}
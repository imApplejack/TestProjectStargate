using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.Mock;

namespace TestProject1
{
    [TestClass]
    public class TestStargateGame
    {
        [TestMethod]
        public void TestMethod1()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame() { player1 = new Player(), Library = library };
            StargateGameMock.InitPlayer1WithMock(stargateGame);





            Assert.IsTrue(true);

        }
    }
}
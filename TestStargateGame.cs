using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.Mock;
using Stargate.Stargate.Enum;

namespace TestProject1
{
    [TestClass]
    public class TestStargateGame
    {
        [TestMethod]
        public void TestMethod1()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(1, library) ;
            StargateGameMock.InitPlayer1WithMock(stargateGame);

            
            
            StargateResult StargateResult = stargateGame.CardService.PlayMission(stargateGame.player1);
            Assert.AreEqual(StargateResult.actionResult, ActionResult.Success);


        }
    }
}
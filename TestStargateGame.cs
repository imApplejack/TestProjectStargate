using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.Mock;
using Stargate.Stargate.Enum;
using System.Diagnostics;
using Stargate.Stargate.Event;

namespace TestProject1
{
    [TestClass]
    public class TestStargateGame
    {
        [TestMethod]
        public void TestMethod1()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library) ;
            StargateGameMock.InitPlayersWithMock(stargateGame);



            //  StargateResult StargateResult = stargateGame.CardService.PlayMission(stargateGame.player1);
            //  Assert.AreEqual(StargateResult.actionResult, ActionResult.Success);




            GameState gs = stargateGame.GameState;  
            stargateGame.GameState.InitGame(1);
            
            gs.ProcessEvent(new SelectCardEvent() { Sender = gs.player2, cardModel = gs.CardRepository.Cards[0] });


            Debug.WriteLine("end");

        }
    }
}
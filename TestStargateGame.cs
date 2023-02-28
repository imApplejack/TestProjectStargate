using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.Mock;
using Stargate.Stargate.Enum;
using System.Diagnostics;
using Stargate.Stargate.Event;
using Stargate.StateMachine;

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



        [TestMethod]
        public void TestMethod2()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library);
            StargateGameMock.InitPlayersWithMock(stargateGame);



            //  StargateResult StargateResult = stargateGame.CardService.PlayMission(stargateGame.player1);
            //  Assert.AreEqual(StargateResult.actionResult, ActionResult.Success);




            GameState gs = stargateGame.GameState;
            stargateGame.GameState.InitGame(1);


            PrintStackRec((StargatePhase)gs.GameStack);


            gs.ProcessEvent(new SelectCardEvent() { Sender = gs.player2, cardModel = gs.CardRepository.Cards[0] });

            gs.ProcessEvent(new PassEvent() { Sender = gs.player1 });
            gs.ProcessEvent(new PassEvent() { Sender = gs.player2 });



           
           

            Debug.WriteLine("end");

        }

        private void PrintStackRec(StatePhase p)
        {
            Debug.WriteLine(p);

            if(p.actions.Count > 0)
            {

                foreach(KeyValuePair<int,StateAction> action in p.actions)
                {
                    PrintStackRec((StatePhase)action.Value);
                    
                }

            }
            
        }


    }
}
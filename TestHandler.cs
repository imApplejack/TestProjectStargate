using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.StateMachine;
using System.Diagnostics;
using Stargate.Stargate.Enum;
using Stargate.Stargate.Event;

namespace TestProject1
{
    [TestClass]
    public class TestHandler
    {
        [TestMethod]
        public void TestMethod1()
        {

            //InitPhase p = new InitPhase(new GameState() { CurrentPlayer = new Player(), CardService = new Stargate.Service.CardService()});
            Phase p = new InitPhase(new GameState() { player1 = new Player(), player2 = new Player(), CardService = new Stargate.Service.CardService() });
            p.gameState.InitGame(1);

            p.gameState.StargateResultHandler += HandlerEventTestMethod;

            p.Run();




            QuestPhase mp = new QuestPhase((p.gameState));
            Assert.IsInstanceOfType(p.gameState.GameStack.Peek(), mp.GetType());
            Assert.AreEqual(3, p.gameState.CurrentPlayer.Energy);





            //p.gameState.ProcessEvent(new PlayCardEvent() { })


        }

        public void HandlerEventTestMethod(object sender, EventArgs e)
        {
         //   ((StargateResult)e).actionResult = ActionResult.Failure;
            Debug.WriteLine(e);
        }


    }
}
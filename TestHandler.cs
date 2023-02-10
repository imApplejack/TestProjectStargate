using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.StateMachine;
using System.Diagnostics;
using Stargate.Stargate.Enum;

namespace TestProject1
{
    [TestClass]
    public class TestHandler
    {
        [TestMethod]
        public void TestMethod1()
        {

            //InitPhase p = new InitPhase(new GameState() { CurrentPlayer = new Player(), CardService = new Stargate.Service.CardService()});
            Phase p = new InitPhase(new GameState() { CurrentPlayer = new Player(), CardService = new Stargate.Service.CardService() });
            p.gameState.StargateResultHandler += HandlerEventTestMethod;

            p.Run();


        }

        public void HandlerEventTestMethod(object sender, EventArgs e)
        {
            ((StargateResult)e).actionResult = ActionResult.Failure;
            Debug.WriteLine(e);
        }


    }
}
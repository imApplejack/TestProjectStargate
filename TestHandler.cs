using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.StateMachine;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    public class TestHandler
    {
        [TestMethod]
        public void TestMethod1()
        {

            //InitPhase p = new InitPhase(new GameState() { CurrentPlayer = new Player(), CardService = new Stargate.Service.CardService()});
            InitPhase p = new InitPhase(new GameState() { CurrentPlayer = new Player(), CardService = new Stargate.Service.CardService() });
            p.StargateResultHandler += HandlerEventTestMethod;

            p.Run();


        }

        public void HandlerEventTestMethod(object sender, EventArgs e)
        {
            Debug.WriteLine(e);
        }


    }
}
using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.StateMachine;

namespace TestProject1
{
    [TestClass]
    public class CardImporter
    {
        [TestMethod]
        public void TestMethod1()
        {



            //InitPhase p = new InitPhase(new GameState() { CurrentPlayer = new Player(), CardService = new Stargate.Service.CardService()});
            Phase p = new InitPhase(new GameState() { CurrentPlayer = new Player(), CardService = new Stargate.Service.CardService() });

            p.Run();


        }
    }
}
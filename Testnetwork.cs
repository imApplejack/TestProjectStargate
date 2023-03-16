using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.StateMachine;
using System.Diagnostics;
using Stargate.Stargate.Enum;
using Stargate.Stargate.Event;
using Stargate.Stargate.StateMachine;

namespace TestProject1
{
    [TestClass]
    public class Testnetwork
    {

        
        [TestMethod]
        public void TestMethod1()
        {

          
            NetworkManager  e = new NetworkManager();

            var retour  = e.GenerateRPCAttr(new AssignCharEvent() { CardModelId = 2, SenderId = 1 });
            StargateEvent se = e.GenerateStargateEvent((string)retour[0], (object[])retour[1]);
            Assert.AreEqual(se.SenderId, 1);
            Assert.AreEqual(((AssignCharEvent)se).CardModelId, 2);

        }

         /*
        [TestMethod]
        public void TestMethod2()
        {


            NetworkManager e = new NetworkManager();

            var retour = e.GenerateRPCAttr(new SelectCardEvent() { CardModelId = new List<int>() { 5, 6, 7 }, SenderId = 2 });
            StargateEvent se = e.GenerateStargateEvent(retour);
            Assert.AreEqual(se.SenderId, 2);
            
            Assert.AreEqual(((SelectCardEvent)se).CardModelId.Count, 2);

        }
       
        */


    }
}
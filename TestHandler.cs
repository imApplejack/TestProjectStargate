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
    public class TestHandler
    {
        [TestMethod]
        public void TestMethod1()
        {

            //StateAction myAction = new StateAction();
            // myAction.Play();



            //StatePhase myPhase = new StatePhase();
            //myPhase.AddAction(new StateAction());



            //StatePhase mySubPhase = new StatePhase();
            //mySubPhase.AddAction(new StateAction()).AddAction(new StateAction());


            //mySubPhase.AddAction(new StateAction());
            //myPhase.AddAction(mySubPhase);



            MockPhase2 i = new MockPhase2(); 
            
            
            try {

                i.Play();
               
            }catch(Exception ex) { }



            try
            {
                i.Play(new StateEvent());
            }
            catch (Exception ex) { }






            Debug.WriteLine("end");

        }

        


    }
}
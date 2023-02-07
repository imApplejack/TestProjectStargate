using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            CardImporter ci = new CardImporter() { Path = "../../../" + Const.SetFile };
            ci.Process();
            Assert.AreEqual(292, ci.list.ToList().Count);
            

        }
    }
}
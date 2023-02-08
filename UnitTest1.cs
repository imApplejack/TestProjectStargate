using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CardImporter ci = new CardImporter() { Path = "../../../" + Const.SetFile };
            ci.Load();
            Assert.AreEqual(292, ci.list.ToList().Count);

            SGCard c = ci.GetCardFromGUID("79974bc9-9b81-41e1-8868-c75f8fc58837");
            Assert.AreEqual(c.Id, "79974bc9-9b81-41e1-8868-c75f8fc58837");

            Assert.ThrowsException<Exception>(()  =>  ci.GetCardFromGUID("pouet"));

        }
    }
}
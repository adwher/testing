using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Tester
{
    [TestClass]
    public class FirstTest
    {
        [TestMethod]
        public void VariableIsTrue()
        {
            var variable = true;
            Assert.IsTrue(variable);
        }
    }
}

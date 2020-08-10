using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Test
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

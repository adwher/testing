using System.Collections.Generic;
using Domain.Invoices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Domain.Invoices
{
    [TestClass]
    public class InvoiceTest
    {
        [TestMethod]
        public void SubtotalIsCorrect()
        {
            var shoppingBag = new Dictionary<string, double>
            {
                { "papa", 1000 },
                { "cebolla", 1500 },
                { "platano", 1100 }
            };

            var invoice = new Invoice(shoppingBag);
            
            var expected = 3600;
            var actual = invoice.CalculateSubtotal();

            Assert.AreEqual(expected, actual);
        }
    }
}

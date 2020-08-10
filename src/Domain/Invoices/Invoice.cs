using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Invoices
{
    public class Invoice
    {
        private readonly Dictionary<string, double> shoppingBag;

        public Invoice(Dictionary<string, double> shoppingBag)
        {
            this.shoppingBag = shoppingBag;
        }

        public double CalculateSubtotal()
        {
            double subtotal = 0;

            foreach (var product in shoppingBag)
            {
                subtotal += product.Value;
            }

            return subtotal;
        }
    }
}

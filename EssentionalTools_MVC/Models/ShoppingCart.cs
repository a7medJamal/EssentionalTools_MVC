using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssenttionalTools_MVC.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;
        public IEnumerable<Product> Iproducts { set; get; }

        public ShoppingCart( IValueCalculator calcParam)
        {
            this.calc = calcParam;
        }

        public decimal CalculateProductsTotal ()
        {
            return calc.ValueProducts(Iproducts);
        }
    }
}
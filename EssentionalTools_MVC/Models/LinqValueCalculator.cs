using EssentionalTools_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssenttionalTools_MVC.Models
{
    public class LinqValueCalculator :IValueCalculator
    {
        private IDiscountHelper discounter;
        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            this.discounter = discountParam;
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount( products.Sum(c => c.Price));
        }
        


    }
}
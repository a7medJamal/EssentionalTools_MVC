using EssentionalTools_MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace EssenttionalTools_MVC.Models
{
    public class LinqValueCalculator :IValueCalculator
    {
        private IDiscountHelper discounter;
        private static int counter;


        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            this.discounter = discountParam;

            Debug.WriteLine(string.Format("instance {0} Creater",++counter));
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount( products.Sum(c => c.Price));
        }
        


    }
}
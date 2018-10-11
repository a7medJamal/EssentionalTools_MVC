using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentionalTools_MVC.Models
{
   public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
    public class DefaultDiscountHelper : IDiscountHelper 
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            return totalParam - (15m/100 * totalParam);
        }
    }
}
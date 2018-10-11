using EssenttionalTools_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentionalTools_MVC.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products =
{
            new Product{Name="apple",Category="Mobile Company",Price=12M},
            new Product{Name="hp",Category="Laptop Company",Price=98M},
            new Product{Name="Samsung",Category="Mobile Company",Price=25M},
            new Product{Name="Hawawi",Category="Mobile Company",Price=68M}

        };

        // GET: Home
        public ActionResult Index()
        {
            IValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { Iproducts = products };

            decimal Totalvalue = cart.CalculateProductsTotal();
            return View(Totalvalue);
        }
    }
}
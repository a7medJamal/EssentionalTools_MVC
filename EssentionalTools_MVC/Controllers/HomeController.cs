using EssenttionalTools_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
namespace EssentionalTools_MVC.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        public HomeController( IValueCalculator calcParam)
        {
            calc = calcParam;
        }

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
            
            //IKernel ninjectKernel = new StandardKernel();   // step 01
            //ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();   // step 02
            //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();      // step 03


            //   IValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { Iproducts = products };

            decimal Totalvalue = cart.CalculateProductsTotal();
            return View(Totalvalue);
        }
    }
}
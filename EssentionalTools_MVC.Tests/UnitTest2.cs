using System;
using System.Linq;
using EssentionalTools_MVC.Models;
using EssenttionalTools_MVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace EssentionalTools_MVC.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] products =
         {
            new Product{Name="apple",Category="Mobile Company",Price=12M},
            new Product{Name="hp",Category="Laptop Company",Price=98M},
            new Product{Name="Samsung",Category="Mobile Company",Price=25M},
            new Product{Name="Hawawi",Category="Mobile Company",Price=68M}
        };

        [TestMethod]
        public void Sum_Products_Correctly()
        {
            //Arrange
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();
            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);
            var target = new LinqValueCalculator(mock.Object);





        //    var discounter = new MinimumDiscountHelper();
        //    var target = new LinqValueCalculator(discounter);
        //    var goalTotal = products.Sum(p=>p.Price);
            //Act
            var result = target.ValueProducts(products);
            //Assert
            Assert.AreEqual(products.Sum(p=>p.Price), result);
        }
    }
}

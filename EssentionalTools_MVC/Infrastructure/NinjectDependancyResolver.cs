using EssentionalTools_MVC.Models;
using EssenttionalTools_MVC.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentionalTools_MVC.Infrastructure
{
    public class NinjectDependancyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependancyResolver(IKernel kernelParam)
        {
            this.kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>().WithConstructorArgument("discountParam", 50M);

        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet (serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}
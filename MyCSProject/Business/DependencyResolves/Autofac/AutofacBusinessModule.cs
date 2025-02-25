﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Utilities.Interceptors.MethodInterception;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); // program.cs alanında kullanılan singleton ile eşdeğer
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance(); // Reflection = Program çalıştığında bu classlar üzerinden oluşturuluyorlar.

            var assembly = System.Reflection.Assembly.GetExecutingAssembly(); // Attribute IoC

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

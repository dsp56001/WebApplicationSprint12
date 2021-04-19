using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIDemo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApplicationSprint12;
using WebApplicationSprint12.Controllers;
using WebApplicationSprint12.Models;

namespace UnitTestProjectMVCTests
{
    [TestClass]
    public class WarrionControllerTest
    {
        [TestMethod]
        public void WarrioControllIndecDI()
        {
            //Arrange
            var mockConfig = new Mock<IConfiguration>();
            Startup su = new Startup(mockConfig.Object);
            IServiceCollection serviceCollection;
            serviceCollection = new ServiceCollection();

            su.ConfigureServices(serviceCollection);
            ServiceProvider spTester;
            spTester = serviceCollection.BuildServiceProvider();

            //Act
            var controller = new WarriorController(spTester.GetService<IWarrior>());
            var result = (ViewResult)controller.Index();

            //Assert
            Assert.AreEqual(typeof(Samurai), result.Model.GetType());
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using WebApplicationSprint12.Controllers;
using WebApplicationSprint12.Models;
using System.Linq;

namespace UnitTestProjectMVCTests
{
    [TestClass]
    public class DogControllersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void DogControllerIndex()
        {
            //Arrange
            IEnumerable<IDog> _dogs;
            var controller = new DogController();
            //Act

            var result = (ViewResult)controller.Index();
            _dogs = (IEnumerable<IDog>)result.Model;
            //Assert
            Assert.AreEqual(_dogs.GetType(), result.Model.GetType());
            Assert.AreEqual("Fido", (_dogs.ToList()[1].Name));
        }

        [TestMethod]
        public void DogControllerUpdateDog()
        {
            //Arrange
            
            Dog changedDog = new Dog() { Name = "Milo", Age = 3 };
            DogController controller = new DogController();

            //Act

            var result = (RedirectToActionResult)controller.Edit(DogController.dogs[1].DogID, changedDog);
            
            //Assert
            Assert.AreEqual("Milo", DogController.dogs[1].Name);
        }
    }
}

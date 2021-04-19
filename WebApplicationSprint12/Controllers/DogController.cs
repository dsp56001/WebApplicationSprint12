using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationSprint12.Models;

namespace WebApplicationSprint12.Controllers
{
    public class DogController : Controller
    {

        protected static IDog _dog;

        public static List<IDog> dogs; //cheat

        public DogController()
        {
            
            _dog ??= new Dog();

            //if(_dog == null)
            //{
            //    _dog = new Dog();
            //}
            dogs ??= new List<IDog>()
            {
                new Dog(),
                new Dog() { Name="Fido", Age=2},
                new Dog() { Name="Rover", Age=3}
            };
        }
        
        // GET: DogController
        public ActionResult Index()
        {
            
            return View(dogs.ToArray());
        }

        // GET: DogController/Details/5
        public ActionResult Details(int id)
        {
            var fdog = dogs.Where<IDog>(d => d.DogID == id).FirstOrDefault();
            return View(fdog);
        }

        // GET: DogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dog dog)
        {
            try
            {
                dogs.Add(dog);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogController/Edit/5
        public ActionResult Edit(int id)
        {
            var fdog = dogs.Where<IDog>(d => d.DogID == id).FirstOrDefault();
            return View(fdog);
        }

        // POST: DogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Dog dog)
        { 
            try
            {
                var fdog = dogs.Where<IDog>(d => d.DogID == id).FirstOrDefault();
                fdog.Name = dog.Name;
                fdog.Age = dog.Age;
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

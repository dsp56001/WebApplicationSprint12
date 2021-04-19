using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSprint12.Models
{
    public class Dog : IDog, IAboutable
    {
        protected string name;
        protected int age;
        
        protected int id;

        public int DogID { get => this.id; set => this.id = value; }

        public string Name { get => this.name; set { this.name = value; } }

        public int Age { get => this.age; set { this.age = value; } }

        private static int dogCount;

        public Dog()
        {
            this.Name = "Fido";
            this.Age = 2;
            this.DogID = dogCount;
            dogCount++;
        }

        public string About()
        {
            return $"Hello my name is  {this.Name} and I'm {this.Age} old:";
        }
    }
}

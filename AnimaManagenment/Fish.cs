using System;
using System.Collections.Generic;
using System.Text;
using static AnimaManagenment.IAnimal;

namespace AnimaManagenment
{
    class Fish : IMarineAnimal
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }

        public Fish() { }
        public Fish(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        public void Move()
        {
            Console.WriteLine("Swim");
        }
        public override string ToString()
        {
             return  "ID :" + Id + " Name : " + Name + " Age : " + Age; 

        }
    }
}

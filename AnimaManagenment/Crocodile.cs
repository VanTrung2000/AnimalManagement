using System;
using System.Collections.Generic;
using System.Text;
using static AnimaManagenment.IAnimal;

namespace AnimaManagenment
{
    class Crocodile:ITerrestrialAnimal, IMarineAnimal
    {
        
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }

        public Crocodile() { }
        public Crocodile(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        public void Move()
        {
            Console.WriteLine("Swim");
        }
        public void Move1()
        {
            Console.WriteLine("Run");
        }
        public override string ToString()
        {
            Console.WriteLine(GetType());
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            return "";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace AnimaManagenment
{
    class Cat : ITerrestrialAnimal
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age {set;get;}

        public Cat() { }
        public Cat(int Id,string Name,int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        public void Move()
        {
            Console.WriteLine("Run");
        }
        public override string ToString()
        {

              return  "ID :" + Id + " Name : " + Name + " Age : " + Age; 
        }

    }
}

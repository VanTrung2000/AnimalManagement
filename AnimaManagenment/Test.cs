using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AnimaManagenment
{
    class Test
    {
        int count = 0;
        Hashtable ListAnimal = new Hashtable();
        public void AddCat()
        {
            Cat obj = new Cat();
            obj.Id = count;
            Console.Write("Name of cat:");
            obj.Name = Console.ReadLine();
            Console.Write("Age of cat:");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void AddFish()
        {
            Fish obj = new Fish();
            obj.Id = count;
            Console.Write("Name of fish:");
            obj.Name = Console.ReadLine();
            Console.Write("Age of fish:");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void AddCrocodile()
        {
            Crocodile obj = new Crocodile();
            obj.Id = count;
            Console.Write("Name of crocodile: ");
            obj.Name = Console.ReadLine();
            Console.Write("Age of crocodile: ");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }



        public void ViewTerrestrialAnimals()
        {
            Cat c = new Cat();
            for (int i = 0; i < ListAnimal.Count; i++)
                if (ListAnimal[i].GetType().Equals(c.GetType()))
                {
                    ListAnimal[i].ToString();
                    c.Move();
                }
        }
                    public void ViewMarineAnimals()
                    {
                        Fish f = new Fish();
                        for (int i = 0; i < ListAnimal.Count; i++)
                            if (ListAnimal[i].GetType().Equals(f.GetType()))
                            {
                                ListAnimal[i].ToString();
                                f.Move();
                            }
                    } 
                  public  void ViewAllAnimals()
                    {
                        Crocodile cr = new Crocodile();
                        for (int i = 0; i < ListAnimal.Count; i++)
                         if (ListAnimal[i].GetType().Equals(cr.GetType()))
                {
                            ListAnimal[i].ToString();
                            cr.Move();
                            cr.Move1();
                }


        }
                  public void DeleteAnimals()
                    {
                        int n;
                        Console.Write("Please select a key: ");
                        int.TryParse(Console.ReadLine(), out n);
                        foreach (DictionaryEntry de in ListAnimal)
                            if (de.Key.Equals(n))
                            {
                                ListAnimal.Remove(n);
                                break;
                            }
                        Console.WriteLine(ListAnimal.Count);
                    }








                }
        }
  

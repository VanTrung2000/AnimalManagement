using System;

namespace AnimaManagenment
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Cat c = new Cat();
            int choice;
            Console.WriteLine("1.Create a Crocodile");
            Console.WriteLine("2.Create a Cat");
            Console.WriteLine("3.Create a Fish");
            Console.WriteLine("4.View Terrestrial Animals");
            Console.WriteLine("5.View Marine Animals");
            Console.WriteLine("6.View All Animals");
            Console.WriteLine("7.Delete Animal");
            Console.WriteLine("8.Exit");
            do
            {
                Console.Write("\nPlease select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        t.AddCrocodile();
                        break;
                    case 2:
                        t.AddCat();
                        break;
                    case 3:
                        t.AddFish();
                        break;
                    case 4:
                        t.ViewAllAnimals();
                        break;
                    case 5:
                        t.ViewMarineAnimals();
                        break;
                    case 6:
                        t.ViewTerrestrialAnimals();
                        break;
                    case 7:
                        t.DeleteAnimals();
                        break;
                    case 8: return;
                }
            } while (choice != 8);



        }
    }
}

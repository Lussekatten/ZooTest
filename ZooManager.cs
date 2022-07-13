using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTest
{
    internal class ZooManager
    {
        public ZooManager()
        {
            AvailableFunds = 15000000;
            AnimalList = new List<Animal>();
            CreateAnimalList();
        }

        private Animal _flagedForRemoval;
        public int AvailableFunds { get; set; }

        public List<Animal> AnimalList { get; set; }
        public void Start()
        {
            Console.WriteLine("I am the Zoo manager and I am going to run the show from now on");
        }

        private void CreateAnimalList()
        {
            Ostrich ostrich = new Ostrich("Ostrich",12,"Africa",10000000);
            Ostrich ostrich2 = new Ostrich("Ostrich2", 14, "Africa", 8000000);
            Oragutan or = new Oragutan("Morgan", 24, "Africa", 7000000);
            AnimalList.Add(or);
            or = new Oragutan("BigMorgan", 34, "Africa", 12000000);
            AnimalList.Add(or);

            AnimalList.Add(ostrich);
            AnimalList.Add(ostrich2);

            Console.WriteLine("Animal list created");
        }
        public void PurchaseAnimal()
        {
            Console.WriteLine($"\nYou have {AvailableFunds} kr at your disposal");
            Console.Write("Use the Id to purchase animal from the list: ");
            int val= int.Parse(Console.ReadLine());
            foreach (var item in AnimalList)
            {
                if (item.Id == val)
                {
                    if (item.CurrentValue <= AvailableFunds)
                    {
                        Console.WriteLine("Purchase successfull");
                        AvailableFunds -= item.CurrentValue;
                        _flagedForRemoval = item;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Available funds too low. You only have: {AvailableFunds} kr");
                    }
                }
            }
            CompletePurchaseTransaction();
        }
        private void  CompletePurchaseTransaction()
        {
            //Remove animal from collection
            AnimalList.Remove(_flagedForRemoval);
            ShowAnimalList();
        }

        public void ShowAnimalList()
        {
            Console.WriteLine();
            Console.WriteLine("Available animals for purchase:");
            foreach (var item in AnimalList)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Origin: {item.Origin}, Age: {item.Age}, Value: {item.CurrentValue}");
            }
        }
    }
}

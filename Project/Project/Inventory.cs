using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Inventory
    {
        private List<Pet> pets;
        private int nextId;
        public Inventory()
        {
            pets = new List<Pet>()
            {
                new Pet { Id = 1, Type = "Dog", Price = 5000, Quantity = 5},
                new Pet { Id = 2, Type = "Cat", Price = 3000, Quantity = 3},
                new Pet { Id = 3, Type = "Bird", Price = 1000, Quantity = 2}
            };
        }
        private int GenerateNextId()
        {
            return ++nextId;
        }

        // --- View Inventory Part ------->
        public void ViewInventory()
        {
            Console.WriteLine("Pet Shop Inventory");
            Console.WriteLine("Id\tType\tPrice\tQuantity");
            foreach (var pet in pets)
            {
                Console.WriteLine($"{pet.Id}\t{pet.Type}\t{pet.Price}\t{pet.Quantity}");
            }
            Console.WriteLine();
        }

        // --- Purchase Pet Part ------->
        public void PurchasePet(string purchaseName, decimal purchasePrice, int purchaseQuantity)
        {
            Pet existingPet = pets.Find(x => x.Type == purchaseName && x.Price == purchasePrice);
            if(existingPet != null)
            {
                existingPet.Quantity += purchaseQuantity;
            }
            else
            {
                pets.Add(new Pet { Id = GenerateNextId(), Type = purchaseName, Price = purchasePrice, Quantity = purchaseQuantity });   
            }
            Console.WriteLine($"{purchaseQuantity} {purchaseName}'s purchased successfully!");
            Console.WriteLine();
        }

        // --- Sale Pet Part ------->
        public void SalePet()
        {

        }

        // --- View Monthly Report Part ------->
        public void ViewReport()
        {

        }
    }
}

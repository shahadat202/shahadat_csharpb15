using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Purchase
    {
        PetDbContext context = new PetDbContext();

        public static void PurchasePet(List<Pet> pets, string type, int price, int quantity)
        {
            int index = pets.Count + 1;
            pets.Add(new Pet { Id = index, Type = type, Price = price, Quantity = quantity });

            Console.WriteLine($"{quantity} {type} purchased successfully!");
            Console.WriteLine();
        }
    }
}

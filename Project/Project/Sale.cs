using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Sale
    {
        public static void SalePet(List<Pet> pets, int id, int quantity)
        {
            Pet existingPet = pets.Find(x => x.Id == id);
            if(existingPet != null && existingPet.Quantity >= quantity)
            {
                existingPet.Quantity -= quantity;
                Console.WriteLine($"{quantity} {existingPet.Type} sold successfully!");
            }
            else
            {
                Console.WriteLine("Insufficient quantity or pet not found.");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final        // --- Complete --->
{
    public class View
    {
        public static void ViewInventory(List<Pet> pets)
        {
            Console.WriteLine("Pet Shop Inventory");
            Console.WriteLine("Id\tType\tPrice\tQuantity");
            Console.WriteLine("--\t----\t-----\t--------");
            foreach (var pet in pets)
            {
                Console.WriteLine($"{pet.Id}\t{pet.Type}\t${pet.Price}\t{pet.Quantity} pice");
            }
            Console.WriteLine();
        }
    }
}
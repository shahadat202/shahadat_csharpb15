using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class PurchaseManager
    {
        private readonly PetDbContext context;
        private readonly View view;
        public PurchaseManager(PetDbContext dbContext, View view)
        {
            context = dbContext;          
            this.view = view;
        }
        public List<Pet> PurchasePet(List<Pet> pets, string type, int price, int quantity)
        {
            var newPet = new Pet()
            {
                Type = type,
                Price = price,
                Quantity = quantity
            };
            context.Pets.Add(newPet);

            context.SaveChanges();

            Console.WriteLine($"{quantity} {type} purchased successfully!");
            Console.WriteLine();

            return context.Pets.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class FeedingManager
    {
        private PetDbContext context;
        public FeedingManager(PetDbContext context)
        {
            this.context = context;
        }
        public void AddFeeding(int petId, int quantity, TimeSpan timeSpan)
        {
            var feedings = new Feeding()
            {
                PetId = petId,
                QuantityOfFeed = quantity,
                TimeOfFeeding = timeSpan
            };
            context.Feedings.Add(feedings);
            context.SaveChanges();

            Console.WriteLine("\nFeeding Schedule added successfully!");
            Console.WriteLine();
        }
        public void ViewFeeding()
        {
            var feedings = context.Feedings.ToList();

            if (feedings.Count == 0)
            {
                Console.WriteLine("\nNo feeding schedule available.\n");
                return;
            }

            Console.WriteLine("\nFeeding Schedule-");
            Console.WriteLine("Pet Id\tQuantity(KG)\tTime of Feeding");
            Console.WriteLine("------\t------------\t---------------");

            foreach (var feeding in feedings)
            {
                Console.WriteLine($"{feeding.PetId}\t   {feeding.QuantityOfFeed}\t\t{feeding.TimeOfFeeding}");
            }
            Console.WriteLine();
        }
    }
}

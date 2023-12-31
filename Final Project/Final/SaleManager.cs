using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class SaleManager
    {
        private readonly PetDbContext context;
        private readonly ReportManager reportManager;

        public SaleManager(PetDbContext context, ReportManager reportManager)
        {
            this.context = context;
            this.reportManager = reportManager;
        }
        public static void SalePet(List<Pet> pets, int id, int quantity, ReportManager reportManager) //PetDbContext context
        {
            Pet existingPet = pets.Find(x => x.Id == id);
            if (existingPet != null && existingPet.Quantity >= quantity)
            {
                existingPet.Quantity -= quantity;

                int revenue = quantity * existingPet.Price;
                int totalRevenue = revenue;
                reportManager.AddRecords(id, quantity, totalRevenue);

                Console.WriteLine($"{quantity} {existingPet.Type} sold successfully!");
                
                //context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Insufficient quantity or pet not found.");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class FeedingScheduleManager
    {
        private List<FeedingSchedule> feedingSchedules;
        public FeedingScheduleManager()
        {
            feedingSchedules = new List<FeedingSchedule>();
        }
        public void AddFeeding(int petId, decimal quantity, TimeSpan timeSpan)
        {
            feedingSchedules.Add(new FeedingSchedule()
            {
                PetId = petId,
                Quantity = quantity,
                TimeOfFeeding = timeSpan
            });
            Console.WriteLine("\nFeeding Schedule added successfully!\n");
        }
        public void ViewFeeding()
        {
            Console.WriteLine("\nFeeding Schedule-");
            Console.WriteLine("Pet Id\tQuantity(KG)\tTime of Feeding");
            Console.WriteLine("------\t------------\t---------------");

            foreach (var schedule in feedingSchedules)
            {
                Console.WriteLine($"{schedule.PetId}\t   {schedule.Quantity}\t\t {schedule.TimeOfFeeding}");
            }
        }
    }
}

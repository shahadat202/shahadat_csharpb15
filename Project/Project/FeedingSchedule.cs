using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class FeedingSchedule
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public decimal Quantity { get; set; }
        public TimeSpan TimeOfFeeding { get; set; }

    }
}

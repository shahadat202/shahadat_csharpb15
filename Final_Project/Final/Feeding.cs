﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Feeding
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public int QuantityOfFeed { get; set; }
        public TimeSpan TimeOfFeeding { get; set; }
    }
}

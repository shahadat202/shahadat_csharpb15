using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Pet 
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

    }
}

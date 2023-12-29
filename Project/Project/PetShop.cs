using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class PetShop
    {
        private List<Pet> inventory;

        public PetShop()
        {
            inventory = new List<Pet>
            {
            new Pet { Id = 1, Type = "Dog", Price = 200, Quantity = 5 },
            new Pet { Id = 2, Type = "Cat", Price = 100, Quantity = 3 },
            new Pet { Id = 3, Type = "Bird", Price = 50, Quantity = 8 }
            };
        }
    }
}

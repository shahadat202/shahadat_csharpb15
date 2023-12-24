using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Login System ----->
            string CorrectUsername = "admin";
            string CorrectPassword = "123456";

            Login login = new Login(CorrectUsername, CorrectPassword);

            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                Console.Write("Enter Username: ");
                string enterUsername = Console.ReadLine();

                Console.Write("Enter Password: ");
                string enterPassword = Console.ReadLine();

                isLoggedIn = login.Authenticate(enterUsername, enterPassword);

                if (isLoggedIn)
                    Console.WriteLine("\nLogin successful.\n");
                else
                    Console.WriteLine("Invalid username or password. Please try again.");
            }

            // --- Inventory Part ----->
            Inventory petInventory = new Inventory();

            List<Pet> pets = new List<Pet>()
            {
                new Pet { Id = 1, Type = "Dog", Price = 200, Quantity = 5},
                new Pet { Id = 2, Type = "Cat", Price = 100, Quantity = 3},
                new Pet { Id = 3, Type = "Bird", Price = 50, Quantity = 8}
            };

            while (true)
            {
                Console.WriteLine("What you want to do?\n");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Purchase Pet");
                Console.WriteLine("3. Sale Pet");
                Console.WriteLine("4. View Monthly Report");
                Console.WriteLine("5. Logout");

                Console.Write("\nEnter your choice (1-5): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        View.ViewInventory(pets);
                        break;
                    case "2":
                        Console.Write("Enter Pet type/name: ");
                        string purchaseName = Console.ReadLine();
                        Console.Write("Enter Pet price: ");
                        decimal purchasePrice = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter quantity/pieces: ");
                        int purchaseQuantity = int.Parse(Console.ReadLine());
                        Purchase.PurchasePet(pets, purchaseName, purchasePrice, purchaseQuantity);
                        break;
                    case "3":
                        Console.Write("Pet Id for sale: ");
                        int saleId = int.Parse(Console.ReadLine());
                        Console.Write("Quantity for sell: ");
                        int saleQuantity = int.Parse(Console.ReadLine());
                        Sale.SalePet(pets, saleId, saleQuantity);
                        break;
                    case "4":
                        petInventory.ViewReport();
                        break;
                    case "5":
                        Console.WriteLine("Logout Successful.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between (1-5): ");
                        break;
                }
            }
        }
    }
}


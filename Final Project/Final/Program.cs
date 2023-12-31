using System;
using System.Collections.Generic;

namespace Final
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

            // --- All Created Instance --->
            PetDbContext context = new PetDbContext();
            View view = new View();
            PurchaseManager purchaseManager = new PurchaseManager(context, view);
            ReportManager reportManager = new ReportManager(context);

            // --- Inventory Part ---> 
            List<Pet> pets = new List<Pet>
            {
                new Pet { Id = 1, Type = "Dog", Price = 100, Quantity = 5 },
                new Pet { Id = 2, Type = "Cat", Price = 50, Quantity = 8 },
                new Pet { Id = 3, Type = "Bird", Price = 30, Quantity = 6 }
            };

            while (true)
            {
                Console.WriteLine("What you want to do?\n");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Purchase Pet");
                Console.WriteLine("3. Sale Pet");
                Console.WriteLine("4. View Report");
                Console.WriteLine("5. Change Password");
                Console.WriteLine("6. Logout");
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
                        string purchaseType = Console.ReadLine();
                        Console.Write($"Enter {purchaseType} price: ");
                        int purchasePrice = int.Parse(Console.ReadLine());
                        Console.Write("Enter quantity/pieces: ");
                        int purchaseQuantity = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        pets = purchaseManager.PurchasePet(pets, purchaseType, purchasePrice, purchaseQuantity);
                        break;
                    case "3":
                        Console.Write("Pet Id for sale: ");
                        int saleId = int.Parse(Console.ReadLine());
                        Console.Write("Quantity for sale: ");
                        int saleQuantity = int.Parse(Console.ReadLine());
                        SaleManager.SalePet(pets, saleId, saleQuantity, reportManager); //context
                        reportManager.SaveChanges();
                        break;
                    case "4":
                        reportManager.DisplayReport();
                        break;
                    case "5":
                        Console.Write("Enter current password: ");
                        string currentPassword = Console.ReadLine();

                        if (login.Authenticate(CorrectUsername, currentPassword))
                        {
                            Console.Write("Enter new password: ");
                            string newPassword = Console.ReadLine();
                            login.ChangePassword(newPassword);
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid password. Change password failed.\n");
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("\nLogout Successful.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between (1-4)\n");
                        break;
                }
            }
        }
    }
}
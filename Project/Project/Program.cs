using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        // --- Feeding Schedule --->
        static FeedingScheduleManager feedingScheduleManager = new FeedingScheduleManager();
        
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
            PetDbContext context = new PetDbContext();
            MonthlyReport monthlyReport = new MonthlyReport();

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
                Console.WriteLine("4. View Feeding Schedule");
                Console.WriteLine("5. View Monthly Report");
                Console.WriteLine("6. Change Password");
                Console.WriteLine("7. Logout");

                Console.Write("\nEnter your choice (1-7): ");
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
                        //context.Pets.Add(new Pet()
                        //{
                        //    Type = purchaseName,
                        //    Price = purchasePrice,
                        //    Quantity = purchaseQuantity
                        //});
                        //context.SaveChanges();
                        break;
                    case "3":
                        Console.Write("Pet Id for sale: ");
                        int saleId = int.Parse(Console.ReadLine());
                        Console.Write("Quantity for sell: ");
                        int saleQuantity = int.Parse(Console.ReadLine());
                        Sale.SalePet(pets, saleId, saleQuantity, monthlyReport);
                        break;
                    case "4":
                        Console.WriteLine("Feeding Schedule options: ");
                        Console.WriteLine("1. Add Feed for Pet");
                        Console.WriteLine("2. View feeding schedule");
                        Console.Write("\nEnter your choice (1-2): ");
                        int scheduleChoice = int.Parse(Console.ReadLine());

                        switch (scheduleChoice)
                        {
                            case 1:
                                Console.Write("\nEnter Pet Id for feeding: ");
                                int PetIdForFeeding = int.Parse(Console.ReadLine());
                                Console.Write("Enter quantity(KG) for feeding: ");
                                decimal QuantityForFeeding = decimal.Parse(Console.ReadLine());
                                Console.Write("Enter time to feeding(HH:mm): ");
                                TimeSpan TimeForFeeding = TimeSpan.Parse(Console.ReadLine());
                                feedingScheduleManager.AddFeeding(PetIdForFeeding, QuantityForFeeding, TimeForFeeding);
                                break;
                            case 2:
                                feedingScheduleManager.ViewFeeding();
                                break;
                            default:
                                Console.WriteLine("Invalid choice for feeding schedule. Please enter (1-2): ");
                                break;
                        }
                        break;
                    case "5":
                        monthlyReport.DisplayReport();
                        break;
                    case "6":
                        Console.Write("Enter current password: ");
                        string currentPassword = Console.ReadLine();

                        if(login.Authenticate(CorrectUsername, currentPassword))
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
                    case "7":
                        Console.Clear();
                        Console.WriteLine("\nLogout Successful.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between (1-6)\n");
                        break;
                }
            }
        }
    }
}


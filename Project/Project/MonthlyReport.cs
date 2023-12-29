using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MonthlyReport
    {
        private List<decimal> records;
        public MonthlyReport()
        {
            records = new List<decimal>();
        }
        public void AddRecords(decimal amount)
        {
            records.Add(amount);
        }
        public void DisplayReport()
        {
            Console.WriteLine("Monthly Report: ");
            Console.WriteLine("Transaction\tAmount");
            Console.WriteLine("-----------\t------");

            foreach (var amount in records)
            {
                Console.WriteLine($"Revenue\t\t{Math.Abs(amount)}");
            }
            decimal total = records.Sum();
            Console.WriteLine($"\nTotal Revenue - ${total}\n");
        }
    }
}

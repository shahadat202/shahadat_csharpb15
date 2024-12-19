using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class ReportManager
    {
        private readonly PetDbContext context;
        private readonly List<Report> records;
        public ReportManager(PetDbContext context)
        {
            records = new List<Report>();
            this.context = context;
        }
        public void AddRecords(int id, int quantity, int amount)
        {
            records.Add(new Report()
            {
                PetId = id, 
                Quantity = quantity,
                Revenue = amount
            });
        }
        public void SaveChanges()
        {
            context.Reports.AddRange(records);
            context.SaveChanges();
        }
        public void DisplayReport()
        {
            Console.WriteLine("Sale Report: ");
            Console.WriteLine("PetId\tQuantity\tAmount");
            Console.WriteLine("----\t--------\t------");

            foreach (var record in records)
            {
                Console.WriteLine($"{record.PetId}\t  {record.Quantity}\t\t{Math.Abs(record.Revenue)}");
            }

            int total = records.Sum(record => record.Revenue);
            Console.WriteLine($"\nTotal Revenue - ${total}\n");
        }
    }
}

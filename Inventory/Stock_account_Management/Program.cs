using System;

namespace Stock_account_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stock management");
            StockReport objectStock = new StockReport();
            objectStock.Report();
        }
    }
}

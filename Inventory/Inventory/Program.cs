using System;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to inventory management");
            Calculate objCalclate = new Calculate();
            objCalclate.CalculationOfInventory();
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stock_account_Management
{
    class StockReport
    {
        public void Report()
        {
            var json = File.ReadAllText(@"C:\Users\Priyanka\Desktop\C#\InventoryManage\Inventory-Data-Management.net\Inventory\Stock_account_Management\StockManagement.json");
            var objectJson = JObject.Parse(json);
            var stockOne = objectJson["StockOne"];
            Console.WriteLine("Stock-Name is : "+stockOne["Stock_name"]);
            Console.WriteLine("Amount of "+stockOne["Stock_share"]+ " share :" +stockOne["Share_prise"] );
            Console.WriteLine("How many share Yo want??");
            long stockOnePrise = (long)stockOne["Share_prise"];
            long userShare = Convert.ToInt32(Console.ReadLine());
            double totalAmoutStockOne = (double)(stockOnePrise *(long)userShare);
            Console.WriteLine("Youur invested amount :"+totalAmoutStockOne);
            Console.WriteLine("##########################################################################################");

            var stockTwo = objectJson["StockTwo"];
            Console.WriteLine("Stock-Name is : " + stockOne["Stock_name"]);
            Console.WriteLine("Amount of " + stockTwo["Stock_share"] + " share :" + stockTwo["Share_prise"]);
            Console.WriteLine("How many share do You want??");
            long stockTwoPrise = (long)stockTwo["Share_prise"];
            long userShareTwo = Convert.ToInt32(Console.ReadLine());
            double totalAmoutStockTwo = (double)(stockTwoPrise * (double)userShareTwo);
            Console.WriteLine("Youur invested amount :" + totalAmoutStockTwo);
            Console.WriteLine("##########################################################################################");

            var stockThree = objectJson["StockThree"];
            Console.WriteLine("Stock-Name is : " + stockThree["Stock_name"]);
            Console.WriteLine("Amount of " + stockThree["Stock_share"] + " share :" + stockThree["Share_prise"]);
            Console.WriteLine("How many share Yo want??");
            long stockThreePrise = (long)stockThree["Share_prise"];
            long userShareThree = Convert.ToInt32(Console.ReadLine());
            double totalAmoutStockThree = (double)(stockThreePrise * (long)userShareThree);
            Console.WriteLine("Youur invested amount :" + totalAmoutStockThree);
            Console.WriteLine("##########################################################################################");
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Inventory
{
    class Calculate
    {
        public void CalculationOfInventory()
        {
            var json = File.ReadAllText(@"C:\Users\Priyanka\Desktop\C#\InventoryManage\Inventory-Data-Management.net\Inventory\Inventory\InventoryJsonFile.json");
            var objectJson = JObject.Parse(json);

            var riceInfo = objectJson["Rice"];
            Console.WriteLine("Name of rice="+riceInfo["name"]);
            Console.WriteLine("Weight of the "+riceInfo["name"]+ " Type rice "+riceInfo["weight"]+"KG");
            Console.WriteLine("Prise per KG of "+riceInfo["name"]+ "rice is "+riceInfo["prise"]+"KG");
            int valueOne =(int)riceInfo["weight"];
            int valueTwo =(int)riceInfo["prise"];
            int calculations = valueOne * valueTwo;
            Console.WriteLine("Calclating Rice inventory:"+calculations);
            Console.WriteLine("##########################################################################################");

            var pulsesInfo = objectJson["Pulses"];
            Console.WriteLine("Name of pulses=" + pulsesInfo["name"]);
            Console.WriteLine("Weight of the " + pulsesInfo["name"] + " Type pulses " + pulsesInfo["weight"]+"KG");
            Console.WriteLine("Prise per KG of " + pulsesInfo["name"] + " pilses is " +pulsesInfo["prise"]+"KG");
            int valueOnePulses = (int)pulsesInfo["weight"];
            int valueTwoPulses = (int)pulsesInfo["prise"];
            int calculationsPulses = valueOnePulses * valueTwoPulses;
            Console.WriteLine("Calclating Rice inventory:" + calculationsPulses);
            Console.WriteLine("##########################################################################################");

            var wheatInfo = objectJson["Wheat"];
            Console.WriteLine("Name of Wheat=" + wheatInfo["name"]);
            Console.WriteLine("Weight of the " + wheatInfo["name"] + " Type wheat " + wheatInfo["weight"] + "KG");
            Console.WriteLine("Prise per KG of " + wheatInfo["name"] + " wheat is " + wheatInfo["prise"] + "KG");
            int valueOneWheat = (int)wheatInfo["weight"];
            int valueTwoWheat = (int)wheatInfo["prise"];
            int calculationsWheat = valueOneWheat * valueTwoWheat;
            Console.WriteLine("Calclating Rice inventory:" + calculationsWheat);
            Console.WriteLine("##########################################################################################");

        }
        
    }
}

using System;
using System.Collections.Generic;

namespace hashset_practice {
    class Program {
        static void Main (string[] args) {
            List<string> Inventory = new List<string> () {
                "camry",
                "F-150",
                "MDX",
                "Camry",
                "Camry",
                "Taurus",
                "F-150",
                "MDX",
                "Camry",
                "XteRra",
                "Mustang",
                "Suburban",
                "Santa Fe",
                "F-150",
                "Camry",
                "F-150",
                "F-150",
                "mustang",
                "Camry",
                "Camry",
                "Camry",
                "escalade",
                "Q30",
                "Camry",
                "MDX",
            };

            HashSet<string> allModels = new HashSet<string> ();

            foreach (string model in Inventory) {
                allModels.Add (model.ToLower());
            }

            // Display all unique model names
            foreach (string vehicle in allModels) {
                Console.WriteLine ($"{vehicle}");
            }

            Console.WriteLine("--------------------------------------");

            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Corolla");
            Showroom.Add("Civic");
            Showroom.Add("Sentra");
            Showroom.Add("Altima");

            foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }

            Console.WriteLine("--------------------------------------");

            Showroom.Add("Corolla");

            foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }

            HashSet<string> UsedCars = new HashSet<string>();
            UsedCars.Add("Camry");
            UsedCars.Add("Brodozer");
            UsedCars.Add("Tundra");
            Showroom.UnionWith(UsedCars);

            foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }

            Showroom.Remove("Brodozer");

            Console.WriteLine("--------------------------------------");

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Corolla");
            Junkyard.Add("Civic");
            Junkyard.Add("Sentra");
            Junkyard.Add("Bumblebee");
            Junkyard.Add("Optimus Prime");
            Junkyard.Add("Starscream");

            HashSet<string> clone = new HashSet<string>(Showroom);

            clone.IntersectWith(Junkyard);

            foreach (string model in clone)
            {
                Console.WriteLine(model);
            }

            Console.WriteLine("---------------------------------------");
            
            Showroom.UnionWith(Junkyard);

            Showroom.Remove("Starscream");

            foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }


        }
    }
}
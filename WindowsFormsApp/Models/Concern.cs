using System;
using System.Collections.Generic;

namespace WindowsFormsApp.Models
{
    public class Concern
    {
        public int id;
        public string name;
        public List<Production> productionList = new List<Production>();
        public Warehouse warehouse;
        public int availableElectricity;

        public void RunCycle(int days)
        {
            for (int day = 1; day <= days; day++)
            {
                availableElectricity = 0;
                Console.WriteLine($"\n=== День {day} ===");

                foreach (var p in productionList)
                    if (p is PowerStation)
                        p.Produce(warehouse, ref availableElectricity);

                Console.WriteLine($"  Електрика: {availableElectricity}");

                foreach (var p in productionList)
                    if (!(p is PowerStation))
                        p.Produce(warehouse, ref availableElectricity);

                Console.WriteLine("  [Склад]");
                foreach (var r in warehouse.resourceList)
                    if (r.amount > 0)
                        Console.WriteLine($"    {r.resourceType}: {r.amount:F1}");
            }
        }
    }
}
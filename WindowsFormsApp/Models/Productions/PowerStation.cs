using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class PowerStation : Production
    {
        public int maxCapacity;

        public override void Produce(Warehouse warehouse, ref int availableElectricity)
        {
            if (activeRecipe == null) return;

         
            if (!warehouse.HasResources(activeRecipe.requiredResourcesList))
            {
                Console.WriteLine($"  [{name}] Нема вугілля");
                return;
            }

           
            warehouse.RemoveResources(activeRecipe.requiredResourcesList);

            
            foreach (var resource in activeRecipe.receivedResourcesList)
            {
                int generated = (int)(resource.amount * (efficiency / 100.0));
                availableElectricity += generated;
                Console.WriteLine($"  [{name}] Згенеровано {generated} електрики. Всього: {availableElectricity}");
            }
        }
    }
}
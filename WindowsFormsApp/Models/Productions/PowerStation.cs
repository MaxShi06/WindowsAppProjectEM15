using System;

namespace WindowsFormsApp.Models
{
    public class PowerStation : Production
    {
        public int maxCapacity;

        public override void Produce(Warehouse warehouse, ref int availableElectricity, Action<string> log = null)
        {
            if (activeRecipe == null) return;
            if (!warehouse.HasResources(activeRecipe.RequiredResources))
            {
                log?.Invoke($"  [{name}] Нема палива");
                return;
            }

            warehouse.RemoveResources(activeRecipe.RequiredResources);

            foreach (var resource in activeRecipe.ReceivedResources)
            {
                int generated = (int)(resource.amount * (efficiency / 100.0));
                availableElectricity += generated;
                log?.Invoke($"  [{name}] Згенеровано {generated} електрики");
            }
        }
    }
}

using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class PowerStation : Production
    {
        public int maxCapacity;

        public PowerStation(int id, string name) : base(id, name) { }

        public override ProductionType GetProductionType() => ProductionType.PowerStation;

        public override void Produce(Warehouse warehouse, List<string> log)
        {
            if (activeRecipe == null)
            {
                log.Add($"  [{name}] Рецепт не встановлено");
                return;
            }

            if (!warehouse.HasResources(activeRecipe.RequiredResources))
            {
                log.Add($"  [{name}] Нема палива");
                return;
            }

            warehouse.RemoveResources(activeRecipe.RequiredResources);

            foreach (var resource in activeRecipe.ReceivedResources)
            {
                int generated = (int)(resource.amount * (efficiency / 100.0));
                List<ResourceAmount> electricity = new List<ResourceAmount>();
                electricity.Add(new ResourceAmount(ResourceType.Electricity, generated));
                warehouse.AddResources(electricity);
                log.Add($"  [{name}] Згенеровано {generated} електрики");
            }
        }

        public static PowerStation Create(int id, string name)
        {
            PowerStation production = new PowerStation(id, name);
            Recipe recipe = new RecipeBuilder(id, "Вугілля -> Електрика", 1)
                .Require(ResourceType.Coal, 1)
                .Receive(ResourceType.Electricity, 10)
                .Build();
            production.recipeList.Add(recipe);
            production.SetActiveRecipe(recipe);
            return production;
        }
    }
}
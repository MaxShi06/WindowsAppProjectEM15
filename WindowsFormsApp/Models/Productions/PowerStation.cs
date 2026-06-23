using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class PowerStation : Production
    {
        public int maxCapacity;

        public PowerStation(int id, string name) : base(id, name) { }

        public override void Produce(Concern concern)
        {
            if (activeRecipe == null) return;
            if (!concern.warehouse.HasResources(activeRecipe.RequiredResources))
            {
                concern.log.Add($"  [{name}] Нема палива");
                return;
            }

            concern.warehouse.RemoveResources(activeRecipe.RequiredResources);

            foreach (var resource in activeRecipe.ReceivedResources)
            {
                int generated = (int)(resource.amount * (efficiency / 100.0));
                concern.availableElectricity += generated;
                concern.log.Add($"  [{name}] Згенеровано {generated} електрики");
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
